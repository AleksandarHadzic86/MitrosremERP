using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.Rute
{
    public class Vozila
    {
        [Key]
        public Guid Id { get; set; }
        public int SifraVozila { get; set; }
        [StringLength(50)]
        public string MarkaVozila { get; set; } = null!;
        [StringLength(50)]
        public string ModelVozila { get; set; } = null!;
        [StringLength(50)]
        public string RegistarskeOznake { get; set; } = null!;
        [StringLength(50)]
        public string? GodinaProizvodnje { get; set; }
        public DateTime RegistrovanDo { get; set; }
        [StringLength(50)]
        public string? Boja { get; set; }
        [StringLength(50)]
        public string BrojSasije { get; set; } = null!;
        [StringLength(50)]
        public string? Gorivo { get; set; }
        [StringLength(50)]
        public string? BrojSedista { get; set; }
        [StringLength(50)]
        public string? Nosivost { get; set; }
        public string? Napomena { get; set; }

        [ForeignKey("KategorijaVozilaId")]
        public int KategorijaVozilaId { get; set; }
        public KategorijaVozila KategorijaVozila { get; set; } = null!;
    }
}
