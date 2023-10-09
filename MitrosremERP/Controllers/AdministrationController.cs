using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MitrosremERP.Aplication.ViewModels.IdentityVM;
using MitrosremERP.Domain.Models.IdentityModel;

namespace MitrosremERP.Controllers
{
    [Authorize(Roles = Roles.Role_SuperAdmin)]

    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger _logger;

        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, ILogger<AdministrationController> logger)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _logger = logger;
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
                    Id = user.Id,
                    UserName = user.UserName,
                    Ime = user.ImeKorisnik,
                    Prezime = user.PrezimeKorisnik,
                    Adresa = user.AdresaKorisnik,
                    Grad = user.GradKorisnik,
                    Mobilni = user.MobilniKorisnik,
                    Role = userRoles.FirstOrDefault()
                };

                model.Add(userVM);
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if(user == null)
            {
                _logger.LogError($"User not found for ID: {id}");
                Response.StatusCode = 404;
                return View("KorisnikNijePronadjen");
            }

            if(user.Email == "aleksandarhadzic1986@gmail.com")
            {
                return View("../Administration/ZabranjenPristupAdministracija");
            }
            var userRoles = await _userManager.GetRolesAsync(user);

            var model = new ApplicationUserVM
            {
                Id = user.Id,
                UserName = user.UserName,             
                Email = user.Email,
                Ime = user.ImeKorisnik,
                Prezime = user.PrezimeKorisnik,
                Adresa = user.AdresaKorisnik,
                Grad = user.GradKorisnik,
                Mobilni = user.MobilniKorisnik,
                Role = userRoles.FirstOrDefault(),
                RoleList = _roleManager.Roles.Select(x => x.Name).Select(i => new SelectListItem
                {
                    Text = i,
                    Value = i
                })
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> UpdateUser(ApplicationUserVM applicationUserVM)
        {

            var user = await _userManager.FindByIdAsync(applicationUserVM.Id);
            if (user == null)
            {
                _logger.LogError($"User not found for ID: {applicationUserVM.Id}");
                Response.StatusCode = 404;
                return View("KorisnikNijePronadjen");
            }

            else
            {
                user.Email = applicationUserVM.Email;
                user.UserName = applicationUserVM.UserName;
                user.ImeKorisnik = applicationUserVM.Ime;
                user.PrezimeKorisnik = applicationUserVM.Prezime;
                user.AdresaKorisnik = applicationUserVM.Adresa;
                user.GradKorisnik = applicationUserVM.Grad;
                user.MobilniKorisnik = applicationUserVM.Mobilni;
                
                var result = await _userManager.UpdateAsync(user);


                if (result.Succeeded)
                {
                    TempData["success"] = "Uspešno izmenjeni podaci";
                    return RedirectToAction("ListUsers");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                

                return View(applicationUserVM);

            }                   
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                _logger.LogError($"User not found for ID: {id}");
                Response.StatusCode = 404;
                return View("KorisnikNijePronadjen");
            }
            if (user.Email == "aleksandarhadzic1986@gmail.com")
            {
                return View("../Administration/ZabranjenPristupAdministracija");
            }
            // Add any additional authorization checks here to determine if the user can be deleted

            var result = await _userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                TempData["success"] = "Zaposleni uspesno obrisan";
                return RedirectToAction("ListUsers");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View("ListUsers", id); 
        }

    }
}
