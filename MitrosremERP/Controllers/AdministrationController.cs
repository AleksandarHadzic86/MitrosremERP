using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MitrosremERP.Aplication.ViewModels.IdentityVM;
using MitrosremERP.Domain.Models.IdentityModel;

namespace MitrosremERP.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> ListUsers()
        {
            var users = await _userManager.Users.ToListAsync(); // Fetch the list of users

            var model = new List<ApplicationUserVM>();

            foreach (var user in users)
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                var userVM = new ApplicationUserVM
                {
                    Email = user.Email,
                    Ime = user.ImeKorisnik,
                    Prezime = user.PrezimeKorisnik,
                    Adresa = user.AdresaKorisnik,
                    Grad = user.GradKorisnik,
                    Mobilni = user.MobilniKorisnik,
                    Role = userRoles.FirstOrDefault() // Assuming a user has only one role, you can modify this if needed
                };

                model.Add(userVM);
            }

            return View(model);
        }
    }
}
