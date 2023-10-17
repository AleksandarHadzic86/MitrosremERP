using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MitrosremERP.Aplication.IRepositories;
using MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM;
using MitrosremERP.Domain.Enum;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;

namespace MitrosremERP.Controllers
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

                    return View(bolovanjeVM);
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
        public async Task<IActionResult> Create(KreirajDokumenteZaposleniVM kreirajDokumenteZaposleniVM, IFormFile? file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HandleFileUpload(kreirajDokumenteZaposleniVM, file);

                    var dokument = _autoMapper.Map<DokumentiZaposleni>(kreirajDokumenteZaposleniVM.DokumentiZaposleniVM);
                    dokument.ZaposleniId = kreirajDokumenteZaposleniVM.ZaposleniVM.Id;
                    _unitOfWork.DokumentiRepository.Insert(dokument);
                    await _unitOfWork.SaveAsync();
                    TempData["success"] = "Dokument uspešno kreiran";
                    return RedirectToAction("Create");
                }
                return View(kreirajDokumenteZaposleniVM);

            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
                return View("InternalServerError");
            }
        }
        private void HandleFileUpload(KreirajDokumenteZaposleniVM kreirajDokumenteZaposleniVM, IFormFile? file)
        {
            string filePath = _webHostEnvironment.WebRootPath;

            if (file != null && file.Length > 0)
            {
                var allowedExtensions = new[] { ".docx", ".pdf" };
                var fileExtension = Path.GetExtension(file.FileName);

                if (allowedExtensions.Contains(fileExtension, StringComparer.OrdinalIgnoreCase))
                {
                    var uploads = Path.Combine(filePath, "dokumenti", "zaposleni");
                    var filename = Guid.NewGuid().ToString() + fileExtension;
                    var fullPath = Path.Combine(uploads, filename);

                    // Handle naming conflicts by checking if the file already exists
                    if (System.IO.File.Exists(fullPath))
                    {
                        // You may want to handle this case differently, e.g., generate a new filename
                        // or overwrite the existing file based on your requirements.
                        ModelState.AddModelError("DokumentiZaposleniVM.PutanjaDokumenta", "Fajl sa istim imenom već postoji.");
                    }
                    else
                    {
                        // Perform the file upload
                        using (var fileStream = new FileStream(fullPath, FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                        }

                        kreirajDokumenteZaposleniVM.DokumentiZaposleniVM.PutanjaDokumenta = Path.Combine("dokumenti", "zaposleni", filename);
                    }
                }
                else
                {
                    ModelState.AddModelError("DokumentiZaposleniVM.PutanjaDokumenta", "Dozvoljeni su samo .docx i .pdf fajlovi.");
                }
            }
            //string filePath = _webHostEnvironment.WebRootPath;

            //if (file != null && file.Length > 0)
            //{
            //    var allowedExtensions = new[] { ".docx", ".pdf" };
            //    var fileExtension = Path.GetExtension(file.FileName);

            //    if(allowedExtensions.Contains(fileExtension, StringComparer.OrdinalIgnoreCase))
            //    {

            //        var uploads = Path.Combine(filePath, "dokumenti", "zaposleni");
            //        var filename = Guid.NewGuid().ToString() + fileExtension;

            //        kreirajDokumenteZaposleniVM.DokumentiZaposleniVM.PutanjaDokumenta = Path.Combine("dokumenti", "zaposleni", filename);

            //        if (!string.IsNullOrEmpty(kreirajDokumenteZaposleniVM.DokumentiZaposleniVM.PutanjaDokumenta))
            //        {
            //            var staraPutanja = Path.Combine(filePath, kreirajDokumenteZaposleniVM.DokumentiZaposleniVM.PutanjaDokumenta.TrimStart('\\'));
            //            if (System.IO.File.Exists(staraPutanja))
            //            {
            //                System.IO.File.Delete(staraPutanja);
            //            }

            //        }
            //        using (var fileStreams = new FileStream(Path.Combine(uploads, filename), FileMode.Create))
            //        {
            //            file.CopyTo(fileStreams);
            //        }
            //    }
            //    else
            //    {
            //        ModelState.AddModelError("DokumentiZaposleniVM.PutanjaDokumenta", "Dozvoljeni su samo .docx i .pdf fajlovi");
            //        return;
            //    }
            //}


        }
    }
}
