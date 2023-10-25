using MitrosremERP.Domain.Enum;
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
    public class GodisnjiVMIndex
    {
        public Guid Id { get; set; }
        public DateTime DatumPocetkaGodisnjeg { get; set; }

        public DateTime DatumZavrsetkaGodisnjeg { get; set; }
        public int BrojDanaGodisnjeg { get; set; }
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
