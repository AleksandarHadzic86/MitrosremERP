using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using MitrosremERP.Domain.Enum;

namespace MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM
{
    public class UgovoriVM
    {
        public UgovoriVM()
        {
            DatumPocetka = DateTime.Today;
            ZaposleniVM = new ZaposleniVM();
        }
        [Key]
        public Guid Id { get; set; }

        [StringLength(50, ErrorMessage = "Maksimalan broj karaktera 50")]
        [Required(ErrorMessage = "Broj ugovora obavezan")]
        [Display(Name = "Broj Ugovora")]
        public string BrojUgovora { get; set; } = null!;
    
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum Pocetka")]
        [Required(ErrorMessage = "Datum je obavezan")]
        public DateTime DatumPocetka { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum Zavrsetka")]
        public DateTime? DatumZavrsetka { get; set; } 



        [Required(ErrorMessage = "Obavezan unos broj dana godisnjeg odmora")]
        [Display(Name = "Broj Dana godisnjeg odmora")]
        [Range(1, 40, ErrorMessage = "Minimum 1 dan, maksmimum 40 dana godisnjeg odmora")]
        public int BrojDanaGodisnjeg { get; set; }

        public string? Napomena { get; set; }

        public TipUgovora TipoviUgovora { get; set; }

        public Guid ZaposleniId { get; set; }
        [ValidateNever]
        public ZaposleniVM ZaposleniVM { get; set; }
        //public string ZaposleniIme { get; set; } = null!;
        //public string ZaposleniPrezime { get; set; } = null!;
    }
}
