using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM
{
    public class DokumentiZaposleniVM
    {
        
        [Required(ErrorMessage = "Ime dokumenta obavezno")]
        public string ImeDokumenta { get; set; } = null!;

        [Required(ErrorMessage = "Niste izabrali dokument")]
        public string? PutanjaDokumenta { get; set; }
        public ZaposleniVM ZaposleniVM { get; set; } = null!;

    }
}
