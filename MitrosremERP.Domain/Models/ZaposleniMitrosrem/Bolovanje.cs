using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.ZaposleniMitrosrem
{
    public class Bolovanje
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obavezan unos pocetak bolovanja")]
        [DataType(DataType.Date)]
        [Display(Name = "Datum pocetka bolovanja")]
        public DateOnly PocetakBolovanja { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Datum zavrsetka bolovanja")]
        public DateOnly? ZakljucenoBolovanje { get; set; }

        public int? BrojDanaBolovanja { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Obavezan unos status bolovanja")]
        public string StatusBolovanja { get; set; }
        public string? Napomena { get; set; }


        [ForeignKey("ZaposleniId")]
        public int ZaposleniId { get; set; }

        [Required(ErrorMessage = "Morate odabrati zaposlenog")]
        public Zaposleni Zaposleni { get; set; }
    }
}
