using MitrosremERP.Domain.Enum;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.ViewModels.ZaposleniMitroSremVM
{
    public class GodisnjiVM
    {
        [Key]
        public Guid Id { get; set; }

        private DateTime _datumPocetkaGodisnjeg = DateTime.MinValue;

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum pocetka godisnjeg")]
        [Required(ErrorMessage = "Datum je obavezan")]
        public DateTime DatumPocetkaGodisnjeg
        {
            get
            {

                return (_datumPocetkaGodisnjeg == DateTime.MinValue) ? DateTime.Now : _datumPocetkaGodisnjeg;
            }
            set
            {
                _datumPocetkaGodisnjeg = value;
            }
        }
        private DateTime _datumZavrsetkaGodisnjeg = DateTime.MinValue;

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum zavrsetka godisnjeg")]
        [Required(ErrorMessage = "Datum je obavezan")]
        public DateTime DatumZavrsetkaGodisnjeg
        {
            get
            {

                return (_datumZavrsetkaGodisnjeg == DateTime.MinValue) ? DateTime.Now : _datumZavrsetkaGodisnjeg;
            }
            set
            {
                _datumZavrsetkaGodisnjeg = value;
            }
        }

        [Required(ErrorMessage = "Obavezan unos broj dana godisnjeg odmora")]
        public int BrojDanaGodisnjeg { get; set; }

        [StringLength(250)]
        public string? Napomena { get; set; }


        [ForeignKey("ZaposleniId")]
        public Guid ZaposleniId { get; set; }
        public ZaposleniVM ZaposleniVM { get; set; } = null!;

        public StatusBolGod StatusBolGod { get; set; }
    }
}
