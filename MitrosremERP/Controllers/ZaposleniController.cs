using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MitrosremERP.Aplication.Data;
using MitrosremERP.Aplication.Interfaces;
using MitrosremERP.Aplication.ViewModels;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using MitrosremERP.Infrastructure.Repositories;
using AutoMapper;

namespace MitrosremERP.Controllers
{
    public class ZaposleniController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _autoMapper;

        public ZaposleniController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment, IMapper autoMapper)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _autoMapper = autoMapper;
        }
        public IActionResult Index()
        {
            IEnumerable<Zaposleni> lista = _unitOfWork.ZaposleniRepository.GetAll();
            var zaposleniVM = _autoMapper.Map<IEnumerable<ZaposleniVM>>(lista);
            return View(zaposleniVM);
        }
        [HttpGet]
        public IActionResult Upsert(int? id)
        {
            ZaposleniVM zaposleniVM = new ZaposleniVM(); 
            zaposleniVM.StepenStrucneSpremeLista = LoadStepenStrucneSpremeListItems("Zaposleni");
            zaposleniVM.PolOsobaLista = LoadPolOsobeListItems();

            if (id == null || id == 0) 
            {
                return View(zaposleniVM);
            }
            else 
            {
                var zaposleni = _unitOfWork.ZaposleniRepository.GetFirstOrDefault(i => i.Id == id);
                if (zaposleni == null)
                {
                    Response.StatusCode = 404;
                    return View("ZaposleniNijePronadjen");
                }
                else
                {
                    var zaposleniVMMapper = _autoMapper.Map<ZaposleniVM>(zaposleni);
                    zaposleniVMMapper.StepenStrucneSpremeLista = LoadStepenStrucneSpremeListItems();
                    zaposleniVMMapper.PolOsobaLista = LoadPolOsobeListItems();
                    return View(zaposleniVMMapper);
                }
            }
        }
        [HttpPost]
        public IActionResult Upsert(ZaposleniVM zaposleniVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                HandleImageUpload(zaposleniVM, file);

                if (zaposleniVM.Id == 0 )  //ako nema iD kreiraj zaposlenog
                {
                    var zaposleniMapper = _autoMapper.Map<Zaposleni>(zaposleniVM);
                    _unitOfWork.ZaposleniRepository.Add(zaposleniMapper);
                    TempData["success"] = "Zaposleni uspešno kreiran";
                }

                else  //alo ima update
                {
                    var postojiZaposleni = _unitOfWork.ZaposleniRepository.GetFirstOrDefault(i => i.Id == zaposleniVM.Id);
                    if (postojiZaposleni == null)
                    {
                        Response.StatusCode = 404;
                        return View("ZaposleniNijePronadjen");
                    }
                    else
                    {
                        _autoMapper.Map(zaposleniVM, postojiZaposleni);
                        TempData["success"] = "Uspešno izmenjeni podaci";
                    }                   
                }
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            else
            {
                zaposleniVM.StepenStrucneSpremeLista = LoadStepenStrucneSpremeListItems();
                zaposleniVM.PolOsobaLista = LoadPolOsobeListItems();
                return View(zaposleniVM);
            }
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                Response.StatusCode = 404;
                return View("ZaposleniNijePronadjen");
            }

            var zaposleni = _unitOfWork.ZaposleniRepository.GetFirstOrDefault(i => i.Id == id);
            if (zaposleni != null)
            {
                var zaposleniVMMapper = _autoMapper.Map<ZaposleniVM>(zaposleni);
                zaposleniVMMapper.StepenStrucneSpremeLista = LoadStepenStrucneSpremeListItems();
                zaposleniVMMapper.PolOsobaLista = LoadPolOsobeListItems();
                return View(zaposleniVMMapper);
            }
            else
            {
                Response.StatusCode = 404;
                return View("ZaposleniNijePronadjen");
            }
        }
        [HttpPost]
        public IActionResult DeletePost(int? id)
        {
            var zaposleniObrisi = _unitOfWork.ZaposleniRepository.GetFirstOrDefault(u => u.Id == id);
            if (zaposleniObrisi == null)
            {
                Response.StatusCode = 404;
                return View("ZaposleniNijePronadjen");
            }
            var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, zaposleniObrisi.ImageUrl.TrimStart('\\'));
            List<string> exclusions = new List<string>
            {  "user.jpg", "userW.jpg" };
            if (!exclusions.Contains(Path.GetFileName(oldImagePath)))
            {
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            
            _unitOfWork.ZaposleniRepository.Remove(zaposleniObrisi);
            _unitOfWork.Save();
            TempData["success"] = "Zaposleni uspesno obrisan";
            return RedirectToAction("Index");
        }

        /*        HandleImageUpload         */
        private void HandleImageUpload(ZaposleniVM zaposleniVM, IFormFile? file)
        {
            string imagePath = _webHostEnvironment.WebRootPath;
            if (file != null)
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
                if (zaposleniVM.PolOsobeId == 1 && zaposleniVM.ImageUrl == null)
                {
                    zaposleniVM.ImageUrl = @"\images\default\user.jpg";
                }
                if (zaposleniVM.PolOsobeId == 2 && zaposleniVM.ImageUrl == null)
                {
                    zaposleniVM.ImageUrl = @"\images\default\userW.jpg";
                }
            }
        }

        /*   LoadDropDownStrucnaSprema i pol   */

        private IEnumerable<SelectListItem> LoadStepenStrucneSpremeListItems(string? includeProperties = null)
        {
            var stepenStrucneSpremeEntities = _unitOfWork.StepenStrucneSpremeRepository.GetAll(includeProperties);
            return _autoMapper.Map<IEnumerable<SelectListItem>>(stepenStrucneSpremeEntities);
        }

        private IEnumerable<SelectListItem> LoadPolOsobeListItems()
        {
            var polosobeLista = _unitOfWork.PolRepository.GetAll();
            return _autoMapper.Map<IEnumerable<SelectListItem>>(polosobeLista);
        }

    }
}
