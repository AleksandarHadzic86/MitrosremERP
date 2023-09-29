﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MitrosremERP.Aplication.Data;
using MitrosremERP.Aplication.IRepositories;
using MitrosremERP.Aplication.ViewModels;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using MitrosremERP.Infrastructure.Repositories;
using AutoMapper;
using System.Data;

namespace MitrosremERP.Controllers
{
   
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
        public async Task<IActionResult> Index()
        {
            try
            {
                IEnumerable<Zaposleni> lista = await _unitOfWork.ZaposleniRepository.GetAllAsync();
                var zaposleniVM = _autoMapper.Map<IEnumerable<ZaposleniVM>>(lista);
                return View(zaposleniVM);
            }          
              catch(Exception ex)
            {
                Response.StatusCode = 500;
                _logger.LogError(ex, "Doslo je do prekida u konekciji sa bazom");
                return View("../ErrorCodes/InternalServerError");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            try
            {
                var zaposleni = await _unitOfWork.ZaposleniRepository.GetByIdAsync(id);

                if (zaposleni == null)
                {
                    Response.StatusCode = 404;
                    return View("ZaposleniNijePronadjen");
                }
                else
                {
                    HttpContext.Session.SetInt32("ProveraIdZaposlenog", id);
                    var zaposleniVMMapper = _autoMapper.Map<ZaposleniVM>(zaposleni);
                    zaposleniVMMapper.StepenStrucneSpremeLista = await LoadStepenStrucneSpremeListItems();
                    zaposleniVMMapper.PolOsobaLista = await LoadPolOsobeListItems();
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
                    var postojiZaposleni = await _unitOfWork.ZaposleniRepository.FirstOrDefaultAsync(z => z.Id == zaposleniVM.Id);
                    int proveraZaposlenogId = HttpContext.Session.GetInt32("ProveraIdZaposlenog") ?? 0;

                    if (postojiZaposleni == null || postojiZaposleni.Id != proveraZaposlenogId)
                    {
                        Response.StatusCode = 404;
                        return View("ZaposleniNijePronadjen");
                    }
                    else
                    {
                        HandleImageUpload(zaposleniVM, file);
                        var zaposleni = _autoMapper.Map<Zaposleni>(zaposleniVM);
                        await _unitOfWork.ZaposleniRepository.UpdateAsync(zaposleni);
                        TempData["success"] = "Uspešno izmenjeni podaci";
                    }
                    
                    await _unitOfWork.SaveAsync();
                    return RedirectToAction("Index");
                }
                else
                {
                    zaposleniVM.StepenStrucneSpremeLista = await LoadStepenStrucneSpremeListItems();
                    zaposleniVM.PolOsobaLista = await LoadPolOsobeListItems();
                    return View(zaposleniVM);
                }
            }
            catch(Exception ex)
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
                zaposleniVM.PolOsobaLista = await LoadPolOsobeListItems();
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
                    await _unitOfWork.ZaposleniRepository.AddAsync(zaposleniMapper);
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
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var zaposleni = await _unitOfWork.ZaposleniRepository.GetByIdAsync(id);

                if (zaposleni == null)
                {
                    Response.StatusCode = 404;
                    return View("ZaposleniNijePronadjen");
                }
                else 
                {
                    HttpContext.Session.SetInt32("ProveraIdZaposlenog", id);
                    var zaposleniVMMapper = _autoMapper.Map<ZaposleniVM>(zaposleni);
                    zaposleniVMMapper.StepenStrucneSpremeLista = await LoadStepenStrucneSpremeListItems();
                    zaposleniVMMapper.PolOsobaLista = await LoadPolOsobeListItems();
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
        public async Task<IActionResult> DeletePost(int id)
        {
            try
            {
                var zaposleni = await _unitOfWork.ZaposleniRepository.GetByIdAsync(id);
                int proveraZaposlenogId = HttpContext.Session.GetInt32("ProveraIdZaposlenog") ?? 0;

                if (zaposleni == null || zaposleni.Id != proveraZaposlenogId)
                {
                    Response.StatusCode = 404;
                    return View("ZaposleniNijePronadjen");
                }
                else
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
                    await _unitOfWork.ZaposleniRepository.RemoveAsync(id);
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
                if (zaposleniVM.PolOsobeId == 1 && zaposleniVM.ImageUrl == null )
                {
                    zaposleniVM.ImageUrl = @"\images\default\user.jpg";
                }
                if (zaposleniVM.PolOsobeId == 2 && zaposleniVM.ImageUrl == null )
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
        private async Task<IEnumerable<SelectListItem>> LoadPolOsobeListItems()
        {
            var polosobeLista = await _unitOfWork.PolRepository.GetAllAsync();
            return _autoMapper.Map<IEnumerable<SelectListItem>>(polosobeLista);
        }

        
    }
}
