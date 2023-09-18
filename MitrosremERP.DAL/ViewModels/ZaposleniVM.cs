﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.ViewModels
{
    public class ZaposleniVM
    {
   
        public Zaposleni Zaposleni { get; set; }
        [ValidateNever]      
        public IEnumerable<SelectListItem> StepenStrucneSpremeLista { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> OdaberiPolLista { get; set; }
    }
}