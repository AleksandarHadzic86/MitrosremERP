using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM
{
    public class KreirajBolovanjeVM
    {

        [ValidateNever]
        public BolovanjeVM BolovanjeVM { get; set; } = new BolovanjeVM();
        [ValidateNever]
        public List<BolovanjeVM> BolovanjeVMlista { get; set; } = new List<BolovanjeVM>();

        [ValidateNever]
        public ZaposleniVM ZaposleniVM { get; set; } = new ZaposleniVM();
    }
}
