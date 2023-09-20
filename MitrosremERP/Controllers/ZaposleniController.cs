
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MitrosremERP.Aplication.Data;
using MitrosremERP.Aplication.Interfaces;
using MitrosremERP.Aplication.ViewModels;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using MitrosremERP.Infrastructure.Repositories;

namespace MitrosremERP.Controllers
{
    public class ZaposleniController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ZaposleniController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            IEnumerable<Zaposleni> lista = _unitOfWork.ZaposleniRepository.GetAll();
            return View(lista);
        }
        [HttpGet]
        public IActionResult Upsert(int? id)
        {
            ZaposleniVM zaposleniVM = new()
            {
                StepenStrucneSpremeLista = _unitOfWork.StepenStrucneSpremeRepository.GetAll().Select(i => new SelectListItem
                {
                    Text = i.StepenObrazovanja,
                    Value = i.Id.ToString()
                }),
                OdaberiPolLista = new List<SelectListItem>
                {
                    new SelectListItem { Value = "Musko", Text = "Musko" },
                    new SelectListItem { Value = "Zensko", Text = "Zensko" }
                },
                Zaposleni = new Zaposleni()
            };
           if(id == null || id == 0)
            {
                return View(zaposleniVM);
            }
            else
            {
                zaposleniVM.Zaposleni = _unitOfWork.ZaposleniRepository.GetFirstOrDefault(i => i.Id == id);
                return View(zaposleniVM);
            }
        }
        [HttpPost]
        public IActionResult Upsert(ZaposleniVM zaposleniVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string imagePath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    var uploads = Path.Combine(imagePath, @"images\zaposleni");

                    if (!string.IsNullOrEmpty(zaposleniVM.Zaposleni.ImageUrl))
                    {
                        var oldImagePath = Path.Combine(imagePath, zaposleniVM.Zaposleni.ImageUrl.TrimStart('\\'));
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
                    zaposleniVM.Zaposleni.ImageUrl = @"\images\zaposleni\" + filename;
                }
                else
                {
                    if(zaposleniVM.Zaposleni.Pol == "Musko")
                    {
                        zaposleniVM.Zaposleni.ImageUrl = @"\images\default\user.jpg";
                    }
                    else if(zaposleniVM.Zaposleni.Pol == "Zensko")
                    {
                        zaposleniVM.Zaposleni.ImageUrl = @"\images\default\userW.jpg";
                    }
                }
                if (zaposleniVM.Zaposleni.Id == 0)
                {
                    _unitOfWork.ZaposleniRepository.Add(zaposleniVM.Zaposleni);
                    TempData["success"] = "Zaposleni uspesno kreiran";
                }
                else
                {
                    _unitOfWork.ZaposleniRepository.Update(zaposleniVM.Zaposleni);
                    TempData["success"] = "Uspesno izmenjeni podaci";
                }
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            else
            {
                zaposleniVM.StepenStrucneSpremeLista = _unitOfWork.StepenStrucneSpremeRepository.GetAll().Select(i => new SelectListItem
                {
                    Text = i.StepenObrazovanja,
                    Value = i.Id.ToString()
                });
                return View(zaposleniVM);
            }
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            ZaposleniVM zaposleniVM = new()
            {
                StepenStrucneSpremeLista = _unitOfWork.StepenStrucneSpremeRepository.GetAll().Select(i => new SelectListItem
                {
                    Text = i.StepenObrazovanja,
                    Value = i.Id.ToString()
                }),
                OdaberiPolLista = new List<SelectListItem>
                {
                    new SelectListItem { Value = "Musko", Text = "Musko" },
                    new SelectListItem { Value = "Zensko", Text = "Zensko" }
                },
                Zaposleni = new Zaposleni()
            };
            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                zaposleniVM.Zaposleni = _unitOfWork.ZaposleniRepository.GetFirstOrDefault(i => i.Id == id);
                return View(zaposleniVM);
            }
        }
        [HttpPost]
        public IActionResult DeletePost(int? id)
        {
            var zaposleniObrisi = _unitOfWork.ZaposleniRepository.GetFirstOrDefault(u => u.Id == id);
            if(zaposleniObrisi == null)
            {
                return NotFound();
            }
            var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, zaposleniObrisi.ImageUrl.TrimStart('\\'));
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }
            _unitOfWork.ZaposleniRepository.Remove(zaposleniObrisi);
            _unitOfWork.Save();
            TempData["success"] = "Zaposleni uspesno obrisan";
            return RedirectToAction("Index");
        }
    }
}
