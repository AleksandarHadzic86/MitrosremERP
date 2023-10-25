using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM
{
    public class KreirajDokumenteZaposleniVM
    {
        
        public DokumentiZaposleniVM DokumentiZaposleniVM { get; set; }

        [ValidateNever]
        public List<DokumentiZaposleniVM> DokumentiZaposleniVMlista { get; set; }

        [ValidateNever]
        public ZaposleniVM ZaposleniVM { get; set; } = null!;
    }
}
