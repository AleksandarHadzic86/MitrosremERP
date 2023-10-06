using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.IdentityModel
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "Ime je obavezno")]
        [Display(Name = "Ime")]
        public string ImeKorisnik { get; set; } = null!;
        [Required(ErrorMessage = "Prezime je obavezno")]
        [Display(Name = "Prezime")]
        public string PrezimeKorisnik { get; set; } = null!;

        [Required(ErrorMessage = "Adresa obavezna")]
        [Display(Name = "Adresa")]
        public string AdresaKorisnik { get; set; } = null!;

        [Required(ErrorMessage = "Grad je obavezan")]
        [Display(Name = "Grad")]
        public string GradKorisnik { get; set; } = null!;

        [Required(ErrorMessage = "Mobilni obavezan")]
        [Display(Name = "Mobilni")]
        public string MobilniKorisnik { get; set; } = null!;
    }
}
