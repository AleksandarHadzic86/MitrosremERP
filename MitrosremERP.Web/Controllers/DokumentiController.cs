using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using MitrosremERP.Application.IRepositories;
using MitrosremERP.Application.ViewModels.ZaposleniMitroSremVM;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;


namespace MitrosremERP.Web.Controllers
{
    public class DokumentiController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _autoMapper;
        private readonly ILogger _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DokumentiController(IUnitOfWork unitOfWork, IMapper autoMapper, ILogger<DokumentiController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _autoMapper = autoMapper;
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Create(Guid? id)
        {
            try
            {
                var zaposleni = await _unitOfWork.ZaposleniRepository.GetByIdAsync(id);

                if (zaposleni == null)
                {
                    Response.StatusCode = 404;
                    return View("../Zaposleni/ZaposleniNijePronadjen");
                }
                else
                {
                    ViewBag.Id = zaposleni.Id;
                    var dokumentiZaposleniId = _unitOfWork.DokumentiRepository.GetQueryable(bolovanje => bolovanje.ZaposleniId == zaposleni.Id).ToList();

                    KreirajDokumenteZaposleniVM bolovanjeVM = new KreirajDokumenteZaposleniVM();

                    bolovanjeVM.DokumentiZaposleniVM = new DokumentiZaposleniVM();
                    bolovanjeVM.DokumentiZaposleniVMlista = _autoMapper.Map<List<DokumentiZaposleniVM>>(dokumentiZaposleniId);
                    bolovanjeVM.ZaposleniVM = _autoMapper.Map<ZaposleniVM>(zaposleni);

                    return View("Create",bolovanjeVM);
                }
            }
            catch (Exception ex)
            {

                Response.StatusCode = 500;
                _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
                return View("InternalServerError");
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(KreirajDokumenteZaposleniVM kreirajDokumenteZaposleniVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var allowedExtensions = new[] { ".pdf", ".docx" };
                    var fileExtension = Path.GetExtension(kreirajDokumenteZaposleniVM.DokumentiZaposleniVM.file.FileName);

                    if (!allowedExtensions.Contains(fileExtension, StringComparer.OrdinalIgnoreCase))
                    {
                        TempData["error"] = "Niste izabrali odgovarajuci dokument,odaberite word ili pdf.";
                        return RedirectToAction("Create");
                    }
                    string filePath = _webHostEnvironment.WebRootPath;
                    var uploads = Path.Combine(filePath, "dokumenti", "zaposleni");
                    var filename = Guid.NewGuid().ToString() + fileExtension;

                    kreirajDokumenteZaposleniVM.DokumentiZaposleniVM.PutanjaDokumenta = Path.Combine("dokumenti", "zaposleni", filename);
                    if (!string.IsNullOrEmpty(kreirajDokumenteZaposleniVM.DokumentiZaposleniVM.PutanjaDokumenta))
                    {
                        var staraPutanja = Path.Combine(filePath, kreirajDokumenteZaposleniVM.DokumentiZaposleniVM.PutanjaDokumenta.TrimStart('\\'));
                        if (System.IO.File.Exists(staraPutanja))
                        {
                            System.IO.File.Delete(staraPutanja);
                        }

                    }
                    using (var fileStream = new FileStream(Path.Combine(uploads, filename), FileMode.Create))
                    {
                        await kreirajDokumenteZaposleniVM.DokumentiZaposleniVM.file.CopyToAsync(fileStream);
                    }

                    var dokument = _autoMapper.Map<DokumentiZaposleni>(kreirajDokumenteZaposleniVM.DokumentiZaposleniVM);
                    dokument.ZaposleniId = kreirajDokumenteZaposleniVM.ZaposleniVM.Id;
                    _unitOfWork.DokumentiRepository.Insert(dokument);
                    await _unitOfWork.SaveAsync();
                    TempData["success"] = "Dokument uspešno kreiran";
                    return RedirectToAction("Create");
                }
                TempData["error"] = "Niste izabrali dokument!";
                return RedirectToAction("Create");
                
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
                return View("InternalServerError");
            }
        }

        
       /// Preuzimanje fajlova////     
        public async Task<string> GetFilePath(Guid fileId)
        {
            // Implement logic to retrieve the file path from your data store (e.g., a database)
            var file = await _unitOfWork.DokumentiRepository.GetByIdAsync(fileId);
            if (file != null)
            {
                string filePath = _webHostEnvironment.WebRootPath;
                return Path.Combine(filePath,file.PutanjaDokumenta.TrimStart('\\'));

            }
            else
            {
                _logger.LogError("Doslo je do greske, putanja nije pronadjena!");
                return string.Empty;
            }
        }
        public string GetMimeType(string filePath)
        {
            var provider = new FileExtensionContentTypeProvider();
            if (!provider.TryGetContentType(filePath, out var contentType))
            {
                contentType = "application/octet-stream"; 
            }
            return contentType;
        }
        public async Task<IActionResult> DownloadFile(Guid fileId)
        {
            string filePath = await GetFilePath(fileId);

            if (System.IO.File.Exists(filePath))
            {
                // Read the file into a byte array
                string mimeType = GetMimeType(filePath);

                // Read the file into a byte array
                byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);

                // Get the file name from the path (you may want to store the original file name)
                string fileName = Path.GetFileName(filePath);

                // Return the file as a FileResult
                return File(fileBytes, mimeType, fileName);
            }
            else
            {
                // Handle the case where the file does not exist
                _logger.LogWarning("File not found: {fileId}");
                return NotFound();
            }

        }
        //private void HandleFileUpload(KreirajDokumenteZaposleniVM kreirajDokumenteZaposleniVM)
        //{

        //    //string filePath = _webHostEnvironment.WebRootPath;

        //    //if (file != null && file.Length > 0)
        //    //{
        //    //    var allowedExtensions = new[] { ".docx", ".pdf" };
        //    //    var fileExtension = Path.GetExtension(file.FileName);

        //    //    if(allowedExtensions.Contains(fileExtension, StringComparer.OrdinalIgnoreCase))
        //    //    {

        //    //        var uploads = Path.Combine(filePath, "dokumenti", "zaposleni");
        //    //        var filename = Guid.NewGuid().ToString() + fileExtension;

        //    //        kreirajDokumenteZaposleniVM.DokumentiZaposleniVM.PutanjaDokumenta = Path.Combine("dokumenti", "zaposleni", filename);

        //    //        if (!string.IsNullOrEmpty(kreirajDokumenteZaposleniVM.DokumentiZaposleniVM.PutanjaDokumenta))
        //    //        {
        //    //            var staraPutanja = Path.Combine(filePath, kreirajDokumenteZaposleniVM.DokumentiZaposleniVM.PutanjaDokumenta.TrimStart('\\'));
        //    //            if (System.IO.File.Exists(staraPutanja))
        //    //            {
        //    //                System.IO.File.Delete(staraPutanja);
        //    //            }

        //    //        }
        //    //        using (var fileStreams = new FileStream(Path.Combine(uploads, filename), FileMode.Create))
        //    //        {
        //    //            file.CopyTo(fileStreams);
        //    //        }
        //    //    }
        //    //    else
        //    //    {
        //    //        ModelState.AddModelError("DokumentiZaposleniVM.PutanjaDokumenta", "Dozvoljeni su samo .docx i .pdf fajlovi");
        //    //        return;
        //    //    }
        //    //}


        //}
    }
}
