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
        public string Ime { get; set; } = null!;
        [Required(ErrorMessage = "Prezime je obavezno")]
        public string Prezime { get; set; } = null!;
        [Required(ErrorMessage = "Adresa obavezna")]
        public string? Adresa { get; set; }
        [Required(ErrorMessage = "Grad je obavezan")]
        public string? Grad { get; set; }
        [Required(ErrorMessage = "Mobilni obavezan")]
        public string Mobilni { get; set; } = null!;
    }
}
