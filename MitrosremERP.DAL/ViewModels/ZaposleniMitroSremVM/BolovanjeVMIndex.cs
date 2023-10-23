using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MitrosremERP.Domain.Enum;

namespace MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM
{
    public class BolovanjeVMIndex
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime DatumPocetkaBolovanja { get; set; }
        public DateTime? DatumZavrsetkaBolovanja { get; set; }
        public int? BrojDanaBolovanja { get; set; }
        public string? Napomena { get; set; }


        [ForeignKey("ZaposleniId")]
        public Guid ZaposleniId { get; set; }
        public ZaposleniVM ZaposleniVM { get; set; } = null!;
        public StatusBolGod StatusBolGod { get; set; }
        public string ZaposleniIme { get; set; } = null!;
        public string ZaposleniPrezime { get; set; } = null!;
        public string? ZaposleniImageUrl { get; set; }
    }
}
