using Microsoft.AspNetCore.Mvc;
using MitrosremERP.Application.ViewModels.ZaposleniMitroSremVM;
using MitrosremERP.Application.ViewModels;
using AutoMapper;
using MitrosremERP.Application.IRepositories;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using Microsoft.AspNetCore.Authorization;
using MitrosremERP.Domain.Models.IdentityModel;


namespace MitrosremERP.Web.Controllers
{
    [Authorize(Roles = Roles.Role_SuperAdmin + "," + Roles.Role_AdminZaposleni)]
    public class UgovorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _autoMapper;
        private readonly ILogger _logger;

        public UgovorController(IUnitOfWork unitOfWork, IMapper autoMapper, ILogger<UgovorController> logger)
        {
            _unitOfWork = unitOfWork;
            _autoMapper = autoMapper;
            _logger = logger;
        }
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            try
            {
                var pageSize = 3;
                var ugovoriLista = await _unitOfWork.UgovoriRepository.GetUgovorPaginationAsync(sortOrder, searchString, pageNumber ?? 1, 8);
                var ugovoriVM = _autoMapper.Map<IEnumerable<UgovoriVMIndex>>(ugovoriLista);


                var ugovoriVMPaginatedList = new PaginatedList<UgovoriVMIndex>(
                    ugovoriVM.ToList(),
                    ugovoriLista.Count,
                    pageNumber ?? 1,
                    pageSize
                );

                return View(ugovoriVMPaginatedList);

            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
                return View("../ErrorCodes/InternalServerError");
            }
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
                    var ugovorZaposleniId =  _unitOfWork.UgovoriRepository.GetQueryable(ugovor => ugovor.ZaposleniId == zaposleni.Id).ToList();

                    KreirajUgovorVM ugovoriVM = new KreirajUgovorVM();

                    //ugovoriVM.UgovoriVM = new UgovoriVM();
                    ugovoriVM.UgovoriVMlista = _autoMapper.Map<List<UgovoriVM>>(ugovorZaposleniId);
                    ugovoriVM.ZaposleniVM = _autoMapper.Map<ZaposleniVM>(zaposleni);
                    
                    return View(ugovoriVM);
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
        public async Task<IActionResult> Create(KreirajUgovorVM kreirajugovorVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var ugovor = _autoMapper.Map<Ugovor>(kreirajugovorVM);
                    ugovor.ZaposleniId = kreirajugovorVM.ZaposleniVM.Id;
                    _unitOfWork.UgovoriRepository.Insert(ugovor);
                    await _unitOfWork.SaveAsync();
                    TempData["success"] = "Ugovor uspešno kreiran";
                    return RedirectToAction("Create");
                }
                return View(kreirajugovorVM);

            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
                return View("../ErrorCodes/InternalServerError");
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetUgovor(Guid? id)
        {
            try
            {
                var ugovorId = await _unitOfWork.UgovoriRepository.GetByIdAsync(id);

                if (ugovorId == null)
                {
                    _logger.LogError($"Ugovor nije pronadjen, ugovor ID: {id}");
                    Response.StatusCode = 404;
                    TempData["error"] = "Ugovor nije pronadjen";
                    return Json(new { error = true });
                }
                else
                {
                    var ugovorVM = _autoMapper.Map<KreirajUgovorVM>(ugovorId);
                    return PartialView("_EditUgovorPartial", ugovorVM);
                }                
            }
            catch (Exception ex)
            {

                Response.StatusCode = 500;
                _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
                TempData["error"] = "Prekid sa serverom";
                return Json(new { error = true });
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(KreirajUgovorVM kreirajUgovorVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var ugovorPostoji = _unitOfWork.UgovoriRepository.GetQueryable(u => u.Id == kreirajUgovorVM.UgovorId);

                    if (ugovorPostoji == null)
                    {
                        _logger.LogError($"Ugovor nije pronadjen, ugovor ID: {ugovorPostoji}");
                        Response.StatusCode = 404;
                        TempData["error"] = "Ugovor nije pronadjen";
                        return Json(new { error = true });
                    }
                    else
                    {

                        var ugovor = _autoMapper.Map<Ugovor>(kreirajUgovorVM);
                        _unitOfWork.UgovoriRepository.Update(ugovor);
                        TempData["success"] = "Uspesno izmenjeni podaci";
                    }
                    await _unitOfWork.SaveAsync();
                    return Json(new { success = true });
                }
                else
                {

                    return View(kreirajUgovorVM);
                }
            }
            catch (Exception ex)
            {

                Response.StatusCode = 500;
                _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
                TempData["error"] = "Prekid sa serverom";
                return Json(new { error = true });
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteUgovor(Guid id)
        {
            try
            {
                var ugovorVM = await _unitOfWork.UgovoriRepository.GetByIdAsync(id);
                if (ugovorVM == null)
                {
                    _logger.LogError($"Ugovor nije pronadjen, ugovor ID: {id}");
                    Response.StatusCode = 404;
                    TempData["error"] = "Ugovor nije pronadjen";
                    return Json(new { error = true });
                }

                _unitOfWork.UgovoriRepository.Delete(ugovorVM);
                await _unitOfWork.SaveAsync();
                _logger.LogInformation($"Ugovor obrisan, broj ugovora :{ugovorVM.BrojUgovora}");
                return Json(new { success = true });
            }
              catch(Exception ex)
            {
                Response.StatusCode = 500;
                _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
                TempData["error"] = "Prekid sa serverom";
                return Json(new { error = true });
            }
         
        }
    }
}
