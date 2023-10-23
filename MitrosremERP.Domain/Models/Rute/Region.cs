using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.Rute
{
    public class Region
    {
        [Key]
        public Guid Id { get; set; }
        public int SifraRegiona { get; set; }
        public string NazivRegiona { get; set; } = null!;
        public int Vrednost { get; set; }
        public decimal Dnevnica { get; set; }
    }
}
