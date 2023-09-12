using Microsoft.AspNetCore.Mvc;
using MitrosremERP.Aplication.Data;
using MitrosremERP.Domain.Models;

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
    }
}
