using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.ZaposleniMitrosrem
{
    public class Bolovanje
    {
        [Key]
        public int Id { get; set; }
        public DateOnly PocetakBolovanja { get; set; }
        public DateOnly? ZakljucenoBolovanje { get; set; }
        public int? BrojDanaBolovanja { get; set; }
        public string StatusBolovanja { get; set; } = null!;
        public string? Napomena { get; set; }


        [ForeignKey("ZaposleniId")]
        public int ZaposleniId { get; set; }
        public Zaposleni Zaposleni { get; set; } = null!;
    }
}
