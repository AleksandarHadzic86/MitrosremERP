using Microsoft.AspNetCore.Mvc;
using MitrosremERP.Aplication.Data;
using MitrosremERP.Aplication.ViewModels;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;

namespace MitrosremERP.Controllers
{
    public class ZaposleniController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ZaposleniController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Zaposleni> lista = _context.Zaposleni.ToList();
            return View(lista);
        }
        [HttpGet]
        public IActionResult Upsert(int? id)
        {
            return View();
        }

        
    }
}
