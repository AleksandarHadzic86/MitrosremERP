using Microsoft.AspNetCore.Mvc;
using MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM;
using MitrosremERP.Aplication.ViewModels;
using AutoMapper;
using MitrosremERP.Aplication.IRepositories;
using Microsoft.EntityFrameworkCore;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using Microsoft.AspNetCore.Authorization;

namespace MitrosremERP.Controllers
{
    [AllowAnonymous]
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
                var ugovoriVM = _autoMapper.Map<IEnumerable<UgovoriVM>>(ugovoriLista);

                var ugovoriVMPaginatedList = new PaginatedList<UgovoriVM>(
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

                    ugovoriVM.UgovoriVM = new UgovoriVM();
                    ugovoriVM.UgovoriVMlista = _autoMapper.Map<List<UgovoriVM>>(ugovorZaposleniId);
                    ugovoriVM.ZaposleniVM = _autoMapper.Map<ZaposleniVM>(zaposleni);
                    
                    return View(ugovoriVM);
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
        public async Task<IActionResult> Create(KreirajUgovorVM kreirajugovorVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var ugovor = _autoMapper.Map<Ugovor>(kreirajugovorVM.UgovoriVM);
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
                return View("InternalServerError");
            }
        }
        //[HttpGet]
        //public async Task<IActionResult> Create(Guid? id)
        //{
        //    try
        //    {
        //        var zaposleni = await _unitOfWork.ZaposleniRepository.GetByIdAsync(id);

        //        if (zaposleni == null)
        //        {
        //            Response.StatusCode = 404;
        //            return View("../Zaposleni/ZaposleniNijePronadjen");
        //        }
        //        else
        //        {
        //            ViewBag.Id = zaposleni.Id;
        //            UgovoriVM ugovoriVM = new()
        //            {
        //                ZaposleniVM = _autoMapper.Map<ZaposleniVM>(zaposleni)
        //            };
        //            return View(ugovoriVM);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        Response.StatusCode = 500;
        //        _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
        //        return View("InternalServerError");
        //    }                            
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(UgovoriVM ugovoriVM)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            var ugovor = _autoMapper.Map<Ugovor>(ugovoriVM);
        //            ugovor.ZaposleniId = ugovoriVM.ZaposleniVM.Id;
        //            _unitOfWork.UgovoriRepository.Insert(ugovor);
        //            await _unitOfWork.SaveAsync();
        //            TempData["success"] = "Ugovor uspešno kreiran";
        //            return RedirectToAction("Create");
        //        }
        //        return View(ugovoriVM);

        //    }
        //    catch (Exception ex)
        //    {
        //        Response.StatusCode = 500;
        //        _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
        //        return View("InternalServerError");
        //    }
        //}
    }
}
