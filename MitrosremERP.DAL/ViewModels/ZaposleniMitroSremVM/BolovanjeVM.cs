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
        [Key]
        public Guid Id { get; set; }

        private DateTime _pocetakBolovanja = DateTime.MinValue;

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum pocetka bolovanja")]
        [Required(ErrorMessage = "Datum je obavezan")]
        public DateTime DatumPocetkaBolovanja
        {
            get
            {

                return (_pocetakBolovanja == DateTime.MinValue) ? DateTime.Now : _pocetakBolovanja;
            }
            set
            {
                _pocetakBolovanja = value;
            }
        }

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
