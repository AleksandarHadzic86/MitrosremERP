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
        [StringLength(250)]
        [Required(ErrorMessage = "Stepen obrazovanja obavezan!")]
        [Display(Name = "Stepen obrazovanja")]
        public string StepenObrazovanja { get; set; } = null!;

        public ICollection<Zaposleni> Zaposleni { get; set; }
    }
}
