using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.ZaposleniMitrosrem
{
    public class StepenStrucneSpreme
    {
        [Key]
        public int Id { get; set; }
        public string StepenObrazovanja { get; set; }

        public ICollection<Zaposleni> Zaposleni { get; set; }
    }
}
