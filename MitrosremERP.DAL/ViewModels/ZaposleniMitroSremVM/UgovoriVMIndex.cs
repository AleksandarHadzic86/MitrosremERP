using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM
{
    public class UgovoriVMIndex
    {
        [ValidateNever]
        public List<UgovoriVM> UgovoriVMlista { get; set; }
        [ValidateNever]

        public ZaposleniVM? ZaposleniVM { get; set; }
    }
}
