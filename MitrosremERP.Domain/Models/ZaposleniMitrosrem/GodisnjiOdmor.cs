using MitrosremERP.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.ZaposleniMitrosrem
{
    public class GodisnjiOdmor
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime DatumPocetkaGodisnjeg { get; set; }
        public DateTime DatumZavrsetkaGodisnjeg { get; set; }
        public int BrojDanaGodisnjeg { get; set; }
        public string? Napomena { get; set; }

        [ForeignKey("ZaposleniId")]
        public Guid ZaposleniId { get; set; }
        public Zaposleni Zaposleni { get; set; } = null!;

        public StatusBolGod StatusBolGod { get; set; }
    }
}
