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
        public int Id { get; set; }
        public DateOnly PocetakGodisnjegOdmora { get; set; }
        public DateOnly ZavrsetakGodisnjegOdmora { get; set; }
        public int BrojDanaGodisnjeg { get; set; }
        public string StatusGodisnjeg { get; set; } = null!;
        public string? Napomena { get; set; }

        [ForeignKey("ZaposleniId")]
        public int ZaposleniId { get; set; }
        public Zaposleni Zaposleni { get; set; } = null!;
    }
}
