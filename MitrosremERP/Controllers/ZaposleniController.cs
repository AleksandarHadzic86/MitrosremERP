
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MitrosremERP.Aplication.Data;
using MitrosremERP.Aplication.Interfaces;
using MitrosremERP.Aplication.ViewModels;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;

namespace MitrosremERP.Controllers
{
    public class ZaposleniController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ZaposleniController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Zaposleni> lista = _unitOfWork.ZaposleniRepository.GetAll();
            return View(lista);
        }
        [HttpGet]
        public IActionResult Upsert(int? id)
        {
            KreirajZaposlenogVM zaposleniVM = new()
            {
                StepenStrucneSpremeLista = _unitOfWork.StepenStrucneSpremeRepository.GetAll().Select(i => new SelectListItem
                {
                    Text = i.StepenObrazovanja,
                    Value = i.Id.ToString()
                }),
                ZaposleniVM = new Zaposleni()
            };
           if(id == null || id == 0)
            {
                return View(zaposleniVM);
            }
            else
            {
                zaposleniVM.ZaposleniVM = _unitOfWork.ZaposleniRepository.GetFirstOrDefault(i => i.Id == id);
                return View(zaposleniVM);
            }
        }

        
    }
}
