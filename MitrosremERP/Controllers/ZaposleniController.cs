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
            };
            if (id == null || id == 0)
            {
                return View(zaposleniVM);
            }
            else
            {
                var zaposleni = _unitOfWork.ZaposleniRepository.GetFirstOrDefault(i => i.Id == id);
                if (zaposleni == null)
                {
                    return NotFound();
                }
                else
                {
                    var zaposleniVMMapper = _autoMapper.Map<ZaposleniVM>(zaposleni);
                    {
                        zaposleniVMMapper.StepenStrucneSpremeLista = _unitOfWork.StepenStrucneSpremeRepository.GetAll().Select(i => new SelectListItem
                        {
                            Text = i.StepenObrazovanja,
                            Value = i.Id.ToString()
                        });
                        zaposleniVMMapper.OdaberiPolLista = new List<SelectListItem>
                        {
                            new SelectListItem { Value = "Musko", Text = "Musko" },
                            new SelectListItem { Value = "Zensko", Text = "Zensko" }
                        };
                    };

                    return View(zaposleniVMMapper);
                }
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
                    if (zaposleniVM.Pol == "Musko")
                    {
                        zaposleniVM.ImageUrl = @"\images\default\user.jpg";
                    }
                    else if (zaposleniVM.Pol == "Zensko")
                    {
                        zaposleniVM.ImageUrl = @"\images\default\userW.jpg";
                    }
                }
                if (zaposleniVM.Id == 0)
                {
                    var zaposleniMapper = _autoMapper.Map<Zaposleni>(zaposleniVM);  
                    _unitOfWork.ZaposleniRepository.Add(zaposleniMapper);
                    TempData["success"] = "Zaposleni uspesno kreiran";
                }
                else
                {
                    var postojiZaposleni = _unitOfWork.ZaposleniRepository.GetFirstOrDefault(i => i.Id == zaposleniVM.Id);
                    if(postojiZaposleni == null)
                    {
                        return NotFound();
                    }
                    _autoMapper.Map(zaposleniVM, postojiZaposleni);
                    TempData["success"] = "Uspesno izmenjeni podaci";

                    //_unitOfWork.ZaposleniRepository.Update(zaposleniVM);
                }

                _unitOfWork.Save();
                return RedirectToAction("Index");
            }

            ///Popuni podatke dropdown liste ako model nije dobar posle post zahteva
            else
            {
                zaposleniVM.StepenStrucneSpremeLista = _unitOfWork.StepenStrucneSpremeRepository.GetAll().Select(i => new SelectListItem
                {
                    Text = i.StepenObrazovanja,
                    Value = i.Id.ToString()
                });
                zaposleniVM.OdaberiPolLista = new List<SelectListItem>
                        {
                            new SelectListItem { Value = "Musko", Text = "Musko" },
                            new SelectListItem { Value = "Zensko", Text = "Zensko" }
                        };
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
               
            };
            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                var zaposleni = _unitOfWork.ZaposleniRepository.GetFirstOrDefault(i => i.Id == id);              
                var zaposleniVMMapper = _autoMapper.Map<ZaposleniVM>(zaposleni);
                return View(zaposleniVMMapper);
            }
        }
        [HttpPost]
        public IActionResult DeletePost(int? id)
        {
            var zaposleniObrisi = _unitOfWork.ZaposleniRepository.GetFirstOrDefault(u => u.Id == id);
            if (zaposleniObrisi == null)
            {
                return NotFound();
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
    }
}
