using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using MitrosremERP.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Application.ViewModels.ZaposleniMitroSremVM
{
    public class UgovoriVMIndex
    {
        public Guid Id { get; set; }
        public string BrojUgovora { get; set; } = null!;

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DatumPocetka { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DatumZavrsetka { get; set; }
        public int BrojDanaGodisnjeg { get; set; }
        public string? Napomena { get; set; }
        public TipUgovora TipoviUgovora { get; set; }
        public Guid ZaposleniId { get; set; }
        public string ZaposleniIme { get; set; } = null!;
        public string ZaposleniPrezime { get; set; } = null!;
        public string? ZaposleniImageUrl { get; set; }
    }
}
