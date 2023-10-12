﻿using Microsoft.AspNetCore.Mvc;
using MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM;
using MitrosremERP.Aplication.ViewModels;
using AutoMapper;
using MitrosremERP.Aplication.IRepositories;

namespace MitrosremERP.Controllers
{
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
    }
}