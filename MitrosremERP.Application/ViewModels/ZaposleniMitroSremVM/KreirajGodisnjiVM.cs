using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Application.ViewModels.ZaposleniMitroSremVM
{
    public class KreirajGodisnjiVM
    {
        [ValidateNever]
        public GodisnjiVM GodisnjiVM { get; set; }
        [ValidateNever]
        public List<GodisnjiVM> GodisnjiVMlista { get; set; }

        [ValidateNever]
        public ZaposleniVM ZaposleniVM { get; set; } = null!;
    }
}
