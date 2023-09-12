using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models
{
    public class Zaposleni
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Morate uneti Ime")]
        public string Ime { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Morate uneti Prezime")]
        public string Prezime { get; set; }
        [Range(13,13, ErrorMessage = "JMBG mora da sadrzi 13 cifara")]
        public UInt64 JMBG { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Morate uneti mesto prebivalista")]
        public string Grad { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Morate uneti adresu")]
        public string Adresa { get; set; }
        [StringLength(50)]
        public string? Fiksni { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Morate uneti mobilni telefon")]
        public string Mobilni { get; set; }
        public string? Napomena { get; set; }
        public ICollection<Ugovor>? Ugovori { get; set; }

        public ICollection<Bolovanje>? Bolovanja { get; set; }

        public ICollection<GodisnjiOdmor>? GodisnjiOdmori { get; set; }
    }
}
