using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.Rute
{
    public class KategorijaVozila
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string NazivKategorije { get; set; } = null!;
        public decimal Vrednost { get; set; }
    }
}
