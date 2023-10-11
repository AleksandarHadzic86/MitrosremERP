// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MitrosremERP.Domain.Models.IdentityModel;

namespace MitrosremERP.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            [Display(Name = "Uloga")]
            public string Role { get; set; }
            [ValidateNever]
            public IEnumerable<SelectListItem> RoleList { get; set; }

            [Required(ErrorMessage = "Ime je obavezno")]
            public string ImeKorisnik { get; set; }

            [Required(ErrorMessage = "Prezime je obavezno")]
            public string PrezimeKorisnik { get; set; }

            [Required(ErrorMessage = "Adresa obavezna")]
            public string AdresaKorisnik { get; set; }

            [Required(ErrorMessage = "Grad je obavezan")]
            public string GradKorisnik { get; set; }

            [Required(ErrorMessage = "Mobilni obavezan")]
            public string MobilniKorisnik { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var userRoles = await _userManager.GetRolesAsync(user); 
            var ime = user.ImeKorisnik;
            var prezime = user.PrezimeKorisnik;
            var adresa = user.AdresaKorisnik;
            var grad = user.GradKorisnik;
            var mobilni = user.MobilniKorisnik;


            Username = userName;


            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                ImeKorisnik = ime,
                PrezimeKorisnik = prezime,
                AdresaKorisnik = adresa,
                GradKorisnik = grad,
                MobilniKorisnik = mobilni,
                Role = userRoles.FirstOrDefault(),
                RoleList = _roleManager.Roles.Select(x => x.Name).Select(i => new SelectListItem
                {
                    Text = i,
                    Value = i
                })
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Input = new()
            {
                RoleList = _roleManager.Roles.Select(x => x.Name).Select(i => new SelectListItem
                {
                    Text = i,
                    Value = i
                })
            };
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            var userRoles = await _userManager.GetRolesAsync(user);

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

             // Check if any properties need to be updated
            bool needUpdate = false;

            if (Input.ImeKorisnik != user.ImeKorisnik)
            {
                user.ImeKorisnik = Input.ImeKorisnik;
                needUpdate = true;
            }

            if (Input.PrezimeKorisnik != user.PrezimeKorisnik)
            {
                user.PrezimeKorisnik = Input.PrezimeKorisnik;
                needUpdate = true;
            }

            if (Input.AdresaKorisnik != user.AdresaKorisnik)
            {
                user.AdresaKorisnik = Input.AdresaKorisnik;
                needUpdate = true;
            }

            if (Input.GradKorisnik != user.GradKorisnik)
            {
                user.GradKorisnik = Input.GradKorisnik;
                needUpdate = true;
            }

            if (Input.MobilniKorisnik != user.MobilniKorisnik)
            {
                user.MobilniKorisnik = Input.MobilniKorisnik;
                needUpdate = true;
            }

            if (Input.Role != userRoles.FirstOrDefault())
            {
                // Handle role changes here if needed
                needUpdate = true;
            }

            if (needUpdate)
            {
                var updateResult = await _userManager.UpdateAsync(user);
                if (!updateResult.Succeeded)
                {
                    // Handle the error
                    StatusMessage = "Greska prilikom azuriranja profila.";
                    return Page();
                }
            }
            //var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            //if (Input.PhoneNumber != phoneNumber)
            //{
            //    var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
            //    if (!setPhoneResult.Succeeded)
            //    {
            //        StatusMessage = "Unexpected error when trying to set phone number.";
            //        return RedirectToPage();
            //    }
            //}

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
