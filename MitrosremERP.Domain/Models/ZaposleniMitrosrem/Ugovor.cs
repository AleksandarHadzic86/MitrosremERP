using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.ZaposleniMitrosrem
{
    public class Ugovor
    {
        [Key]
        public int Id { get; set; }
        public string BrojUgovora { get; set; } = null!;
        public string TipUgovora { get; set; } = null!;
        public DateOnly DatumPocetka { get; set; }
        public DateOnly? DatumZavrsetka { get; set; }
        public int BrojDanaGodisnjeg { get; set; }
        public string? Napomena { get; set; }


        [ForeignKey("ZaposleniId")]
        public int ZaposleniId { get; set; }
        public Zaposleni Zaposleni { get; set; } = null!;
    }
}
