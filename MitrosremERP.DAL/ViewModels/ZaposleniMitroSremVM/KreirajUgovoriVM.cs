using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM
{
    public class KreirajUgovoriVM
    {
        public UgovoriVM UgovoriVM { get; set; }
        public List<UgovoriVM> UgovoriVMlista { get; set; }

        [ValidateNever]
        public ZaposleniVM ZaposleniVM { get; set; } = null!;


    }
}
