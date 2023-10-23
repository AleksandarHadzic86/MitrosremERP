using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.Rute
{
    public class PutniNalog
    {
        public Guid Id { get; set; }
        public int BrojPutnogNaloga { get; set; }
        public DateTime DatumPutnogNaloga { get; set; }
        public int BrojTovarnogLista { get; set; }
        public int BrojIstovarnihMesta { get; set; }
        public decimal NetoKg { get; set; }
        public string StanjeKMsata { get; set; } = null!;
        public string? NasutoLitara { get; set; }
        public int BrPonetihLodni { get; set; }
        public int BrVracenihLodni { get; set; }
        public int BrPonetihPaleta { get; set; }
        public int BrVracenihPaleta { get; set; }
        public ICollection<PutniNalogVozac> PutniNalogVozac { get; set; } = new List<PutniNalogVozac>();
        [ForeignKey("VozilaId")]
        public Guid VozilaId { get; set; }
        public Vozila Vozila { get; set; } = null!;
        [ForeignKey("RegionId")]
        public Guid RegionId { get; set; }
        public Region Region { get; set; } = null!;

    }
}
