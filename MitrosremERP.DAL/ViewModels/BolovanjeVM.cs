using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.ViewModels
{
    public class BolovanjeVM
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Obavezan unos pocetak bolovanja")]
        [Display(Name = "Datum od: ")]
        public DateOnly PocetakBolovanja { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Obavezan unos zavrstek bolovanja")]
        [Display(Name = "Datum do: ")]
        public DateOnly? ZakljucenoBolovanje { get; set; }

        [Required(ErrorMessage = "Obavezan unos, broj dana bolovanja")]
        public int? BrojDanaBolovanja { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Obavezan unos status bolovanja")]
        public string StatusBolovanja { get; set; } = null!;

        [StringLength(250)]
        public string? Napomena { get; set; }


        [ForeignKey("ZaposleniId")]
        public int ZaposleniId { get; set; }
        public Zaposleni Zaposleni { get; set; } = null!;
      

    }
}
