using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.ZaposleniMitrosrem
{
    public class Pol
    {
        [Key]
        public int Id { get; set; } 
        public string PolOsobe { get; set; } = null!;
        public ICollection<Zaposleni> Zaposleni { get; set; } = null!;

    }
}
