﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MitrosremERP.Aplication.IRepositories;
using MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM;

namespace MitrosremERP.Controllers
{
    public class BolovanjeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _autoMapper;
        private readonly ILogger _logger;
        public BolovanjeController(IUnitOfWork unitOfWork, IMapper autoMapper, ILogger<BolovanjeController> logger)
        {
            _unitOfWork = unitOfWork;
            _autoMapper = autoMapper;
            _logger = logger;
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
                    var bolovanjeZaposleniId = _unitOfWork.BolovanjeRepository.GetQueryable(bolovanje => bolovanje.ZaposleniId == zaposleni.Id).ToList();

                    KreirajBolovanjeVM bolovanjeVM = new KreirajBolovanjeVM();

                    bolovanjeVM.BolovanjeVM = new BolovanjeVM();
                    bolovanjeVM.BolovanjeVMlista = _autoMapper.Map<List<BolovanjeVM>>(bolovanjeZaposleniId);
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
    }
}
