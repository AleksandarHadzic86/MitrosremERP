using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Application.ViewModels.ZaposleniMitroSremVM
{
    public class DokumentiZaposleniVM
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Ime dokumenta obavezno")]
        [Display(Name = "Naziv dokumenta")]
        public string ImeDokumenta { get; set; } = null!;
        public string? Napomena { get; set; }
        public string? PutanjaDokumenta { get; set; }
        [ValidateNever]
        public ZaposleniVM ZaposleniVM { get; set; } = null!;

        [Required(ErrorMessage = "Niste izabrali dokument")]
        public IFormFile file { get; set; } = null!;
    }
}
