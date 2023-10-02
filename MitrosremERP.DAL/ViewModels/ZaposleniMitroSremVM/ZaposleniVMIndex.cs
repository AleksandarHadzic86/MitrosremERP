using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM
{
    public class ZaposleniVMIndex
    {
        public Guid Id { get; set; }
        public string Ime { get; set; } = null!;
        public string Prezime { get; set; } = null!;
        public string Profesija { get; set; } = null!;
        public string RadnoMesto { get; set; } = null!;
        public string Mobilni { get; set; } = null!;
        public string? ImageUrl { get; set; }
       
    }
}
