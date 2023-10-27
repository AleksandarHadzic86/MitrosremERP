using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MitrosremERP.Domain.Enum;

namespace MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM
{
    public class BolovanjeVM
    {
        public BolovanjeVM()
        {
            DatumPocetkaBolovanja = DateTime.Today;
        }
        [Key]
        public Guid Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MMMM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum pocetka bolovanja")]
        [Required(ErrorMessage = "Datum je obavezan")]
        public DateTime DatumPocetkaBolovanja { get; set; }
      
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum Zavrsetka")]
        public DateTime? DatumZavrsetkaBolovanja { get; set; }

        [Required(ErrorMessage = "Obavezan unos, broj dana bolovanja")]
        public int? BrojDanaBolovanja { get; set; }

        [StringLength(250)]
        public string? Napomena { get; set; }


        [ForeignKey("ZaposleniId")]
        public Guid ZaposleniId { get; set; }
        public ZaposleniVM ZaposleniVM { get; set; } = null!;

        public StatusBolGod StatusBolGod { get; set; }
    }
}
