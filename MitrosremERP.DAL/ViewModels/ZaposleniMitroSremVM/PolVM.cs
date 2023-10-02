using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM
{
    public class PolVM
    {
        [Required(ErrorMessage = "Id ne moze da bude prazan")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Morate odabrati pol osobe")]
        public string PolOsobe { get; set; } = null!;
    }
}
