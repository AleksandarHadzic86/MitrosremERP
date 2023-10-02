using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM
{
    public class UgovoriVM
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50, ErrorMessage = "Maksimalan broj karaktera 50")]
        [Required(ErrorMessage = "Broj ugovora obavezan")]
        [Display(Name = "Broj Ugovora")]
        public string BrojUgovora { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "Maksimalan broj karaktera 50")]
        [Required(ErrorMessage = "Tip Ugovora je obavezan")]
        [Display(Name = "Tip ugovora")]
        public string TipUgovora { get; set; } = null!;

        [DataType(DataType.Date, ErrorMessage = "Obavezan unos datuma")]
        [Display(Name = "Datum Pocetka")]
        [DisplayFormat(DataFormatString = "{0:dd,MM,yyyy}", ApplyFormatInEditMode = true)]
        public DateOnly DatumPocetka { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Datum Zavrsetka")]
        public DateOnly? DatumZavrsetka { get; set; }

        [Required(ErrorMessage = "Obavezan unos broj dana godisnjeg odmora")]
        [Display(Name = "Broj Dana godisnjeg odmora")]
        [Length(1, 40, ErrorMessage = "Minimum 1 dan, maksmimum 40 dana godisnjeg odmora")]
        public int BrojDanaGodisnjeg { get; set; }

        public string? Napomena { get; set; }


        [ForeignKey("ZaposleniId")]
        public Guid ZaposleniId { get; set; }
        public ZaposleniVM Zaposleni { get; set; } = null!;
    }
}
