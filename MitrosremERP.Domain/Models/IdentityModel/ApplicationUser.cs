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
        [Required]
        public string Ime { get; set; } = null!;
        [Required]
        public string Prezime { get; set; } = null!;
        [Required]
        public string Adresa { get; set; } = null!;
        [Required]
        public string Grad { get; set; } = null!;
    }
}
