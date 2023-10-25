using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using MitrosremERP.Domain.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MitrosremERP.Aplication.Data;
using Microsoft.EntityFrameworkCore;
using Azure.Identity;

namespace MitrosremERP.Infrastructure.DbInitilizer
{
    public class DbInitilizer : IDbinitilizer
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<DbInitilizer> _logger;

        public DbInitilizer(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context,
            ILogger<DbInitilizer> logger)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
            _logger = logger;
        }
        public void Initilizer()
        {
            try
            {
                if(_context.Database.GetPendingMigrations().Count() > 0)
                {
                    _context.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Doslo je do greske prilikom ubacivanja podataka u bazu");
                throw;
            }

            if (!_roleManager.RoleExistsAsync(Roles.Role_SuperAdmin).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(Roles.Role_SuperAdmin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(Roles.Role_Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(Roles.Role_AdminZaposleni)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(Roles.Role_AdminVozila)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(Roles.Role_AdminMaloprodaja)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(Roles.Role_AdminCorn)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(Roles.Role_AdminFinansije)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(Roles.Role_Korisnik)).GetAwaiter().GetResult();

                var hasher = new PasswordHasher<ApplicationUser>();
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "aleksandarhadzic1986@gmail.com",
                    Email = "aleksandarhadzic1986@gmail.com",
                    ImeKorisnik = "Aleksandar",
                    PrezimeKorisnik = "Hadzic",
                    AdresaKorisnik = "Stari Sor 38",
                    GradKorisnik = "Sremska Mitrovica",
                    MobilniKorisnik = "0605574477",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Mitrosrem123!")
                }).GetAwaiter().GetResult();

                ApplicationUser user = _context.ApplicationUsers.FirstOrDefault(u => u.Email == "aleksandarhadzic1986@gmail.com");
                _userManager.AddToRoleAsync(user, Roles.Role_SuperAdmin).GetAwaiter().GetResult();
            }
            return;
        }
    }
}
