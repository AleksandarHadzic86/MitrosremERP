using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.ZaposleniMitrosrem
{
    public class Ugovor
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50, ErrorMessage = "Maksimalan broj karaktera 50")]
        [Required(ErrorMessage = "Broj ugovora obavezan")]
        [Display(Name = "Broj Ugovora")]
        public string? BrojUgovora { get; set; }

        [MaxLength(50, ErrorMessage = "Maksimalan broj karaktera 50")]
        [Required(ErrorMessage = "Tip Ugovora je obavezan")]
        [Display(Name = "Tip ugovora")]
        public string? TipUgovora { get; set; }

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
        public int ZaposleniId { get; set; }
        public Zaposleni Zaposleni { get; set; }
    }
}
