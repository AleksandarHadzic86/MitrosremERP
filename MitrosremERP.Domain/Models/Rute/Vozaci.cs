using MitrosremERP.Domain.Enum;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.Rute
{
    public class Vozaci
    {
        [Key]
        public Guid Id { get; set; }
        public int SifraVozaca { get; set; }
        public DateTime LekarskoUverenjeDo { get; set; }
        public DateTime VozackaDozvolaDo { get; set; }
        public DateTime KarticaTahografaDo { get; set; }
        public DateTime KvalifikacionaKarticaDo { get; set; }
        public Vozacka Vozacka { get; set; }
        public Zaposleni Zaposleni { get; set; } = null!;
        public ICollection<PutniNalogVozac> PutniNalogVozac { get; set; } = new List<PutniNalogVozac>();
    }
}
