using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MitrosremERP.Aplication.IRepositories;
using MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using AutoMapper;
using MitrosremERP.Aplication.ViewModels;
using Microsoft.AspNetCore.Authorization;
using MitrosremERP.Domain.Models.IdentityModel;
using MitrosremERP.Domain.Enum;

namespace MitrosremERP.Controllers
{
    [Authorize(Roles = Roles.Role_SuperAdmin +","+ Roles.Role_AdminZaposleni)]
    public class ZaposleniController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _autoMapper;
        private readonly ILogger _logger;

        public ZaposleniController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, IMapper autoMapper, ILogger<ZaposleniController> logger)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _autoMapper = autoMapper;
            _logger = logger;
        }
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            try
            {
                var pageSize = 3;
                var zaposleniLista = await _unitOfWork.ZaposleniRepository.GetZaposleniPaginationAsync(sortOrder, searchString, pageNumber ?? 1, 8);
                var zaposleniVMs = _autoMapper.Map<IEnumerable<ZaposleniVM>>(zaposleniLista);

                var zaposleniVMPaginatedList = new PaginatedList<ZaposleniVM>(
                    zaposleniVMs.ToList(),
                    zaposleniLista.Count,
                    pageNumber ?? 1,
                    pageSize
                );

                return View(zaposleniVMPaginatedList);

            }          
              catch(Exception ex)
            {
                Response.StatusCode = 500;
                _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
                return View("../ErrorCodes/InternalServerError");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            try
            {

                var zaposleni = await _unitOfWork.ZaposleniRepository.GetByIdAsync(id);

                if (zaposleni == null)
                {
                    Response.StatusCode = 404;
                    _logger.LogError($"Zaposleni sa Id{id}, nije pronadjen");
                    return View("ZaposleniNijePronadjen");
                }
                else
                {
                    var zaposleniVMMapper = _autoMapper.Map<ZaposleniVM>(zaposleni);
                    zaposleniVMMapper.StepenStrucneSpremeLista = await LoadStepenStrucneSpremeListItems();
                    return View(zaposleniVMMapper);

                }
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
                return View("../ErrorCodes/InternalServerError");
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(ZaposleniVM zaposleniVM, IFormFile? file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var postojiZaposleni = _unitOfWork.ZaposleniRepository.GetQueryable(z => z.Id == zaposleniVM.Id);

                    if (postojiZaposleni == null)
                    {
                        Response.StatusCode = 404;
                        _logger.LogError($"Zaposleni sa Id{zaposleniVM.Id} nije pronadjen");
                        return View("ZaposleniNijePronadjen");
                    }
                    else
                    {
                        HandleImageUpload(zaposleniVM, file);
                        var zaposleni = _autoMapper.Map<Zaposleni>(zaposleniVM);
                        _unitOfWork.ZaposleniRepository.Update(zaposleni);
                        TempData["success"] = "Uspešno izmenjeni podaci";
                        await _unitOfWork.SaveAsync();
                    }
                    return RedirectToAction("Update");
                }
                else
                {
                    zaposleniVM.StepenStrucneSpremeLista = await LoadStepenStrucneSpremeListItems();
                    return View(zaposleniVM);
                }
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
                return View("InternalServerError");

            }
        }
        [HttpGet]
        [Route("Zaposleni/Create")]
        public async Task<IActionResult> Create()
        {
            try
            {
                ZaposleniVM zaposleniVM = new ZaposleniVM();
                zaposleniVM.StepenStrucneSpremeLista = await LoadStepenStrucneSpremeListItems();
                return View(zaposleniVM);
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
        public async Task<IActionResult> Create(ZaposleniVM zaposleniVM, IFormFile? file)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HandleImageUpload(zaposleniVM, file);

                    var zaposleniMapper = _autoMapper.Map<Zaposleni>(zaposleniVM);
                    _unitOfWork.ZaposleniRepository.Insert(zaposleniMapper);
                    await _unitOfWork.SaveAsync();
                    TempData["success"] = "Zaposleni uspešno kreiran";
                    return RedirectToAction("Index");
                }
                return View(zaposleniVM);

            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
                return View("InternalServerError");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var zaposleni = await _unitOfWork.ZaposleniRepository.GetByIdAsync(id);

                if (zaposleni == null)
                {
                    Response.StatusCode = 404;
                    _logger.LogError($"Zaposleni sa Id{id}, nije pronadjen");
                    return View("ZaposleniNijePronadjen");
                }
                else
                {
                    var zaposleniVMMapper = _autoMapper.Map<ZaposleniVM>(zaposleni);
                    zaposleniVMMapper.StepenStrucneSpremeLista = await LoadStepenStrucneSpremeListItems();
                    return View(zaposleniVMMapper);
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
        public async Task<IActionResult> DeletePost(ZaposleniVM zaposleniVM)
        {
            try
            {
                var zaposleni =  _unitOfWork.ZaposleniRepository.GetQueryable(z => z.Id == zaposleniVM.Id).FirstOrDefault();
                if (zaposleni == null)
                {
                    Response.StatusCode = 404;
                    _logger.LogError($"Zaposleni sa Id{zaposleniVM.Id}, nije pronadjen");
                    return View("ZaposleniNijePronadjen");
                }

                else
                {
                    if (!string.IsNullOrEmpty(zaposleni.ImageUrl))
                    {
                        var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, zaposleni.ImageUrl.TrimStart('\\'));
                        List<string> exclusions = new List<string>
                                     {  "user.jpg", "userW.jpg" };
                        if (!exclusions.Contains(Path.GetFileName(oldImagePath)))
                        {
                            if (System.IO.File.Exists(oldImagePath))
                            {
                                System.IO.File.Delete(oldImagePath);
                            }
                        }
                    }
                    var zaposleniMapper = _autoMapper.Map<Zaposleni>(zaposleni);
                    _unitOfWork.ZaposleniRepository.Delete(zaposleniMapper);
                    await _unitOfWork.SaveAsync();
                    TempData["success"] = "Zaposleni uspesno obrisan";
                    return RedirectToAction("Index");
                }
            }

            
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
                return View("InternalServerError");
            }
        }

        private void HandleImageUpload(ZaposleniVM zaposleniVM, IFormFile? file)
        {
            string imagePath = _webHostEnvironment.WebRootPath;
            if (file != null && file.Length > 0)
            {
                string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                var uploads = Path.Combine(imagePath, @"images\zaposleni");

                if (!string.IsNullOrEmpty(zaposleniVM.ImageUrl))
                {
                    var oldImagePath = Path.Combine(imagePath, zaposleniVM.ImageUrl.TrimStart('\\'));
                    List<string> images = new List<string>
                        {
                            "user.jpg",
                            "userW.jpg"
                        };
                    if (!images.Contains(Path.GetFileName(oldImagePath)))
                    {
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                }
                using (var fileStreams = new FileStream(Path.Combine(uploads, filename), FileMode.Create))
                {
                    file.CopyTo(fileStreams);
                }
                zaposleniVM.ImageUrl = @"\images\zaposleni\" + filename;
            }
            else
            {
                if (zaposleniVM.PolOsobe == PolOsobe.Musko && zaposleniVM.ImageUrl == null)
                {
                    zaposleniVM.ImageUrl = @"\images\default\user.jpg";
                }
                if (zaposleniVM.PolOsobe == PolOsobe.Zensko && zaposleniVM.ImageUrl == null)
                {
                    zaposleniVM.ImageUrl = @"\images\default\userW.jpg";
                }
            }
        }
        private async Task<IEnumerable<SelectListItem>> LoadStepenStrucneSpremeListItems()
        {
            var stepenStrucneSpremeEntities = await _unitOfWork.StepenStrucneSpremeRepository.GetAllAsync();
            return _autoMapper.Map<IEnumerable<SelectListItem>>(stepenStrucneSpremeEntities);
        }

        
    }
}
