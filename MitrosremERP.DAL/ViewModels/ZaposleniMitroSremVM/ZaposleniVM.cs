using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class ZaposleniVM
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Morate uneti Ime")]
        [DataType(DataType.Text)]
        public string Ime { get; set; } = null!;
        [StringLength(50)]
        [Required(ErrorMessage = "Morate uneti Prezime")]
        public string Prezime { get; set; } = null!;

        [Required(ErrorMessage = "Potrebno je uneti email adresu")]
        [EmailAddress(ErrorMessage = "Email adresa nije validna")]
        public string Email { get; set; } = null!;

        [StringLength(13)]
        [Required(ErrorMessage = "JMBG je obavezan.")]
        [RegularExpression(@"^\d{13}$", ErrorMessage = "JMBG mora da sadrži 13 cifara.")]
        public string JMBG { get; set; } = null!;


        private DateTime _datumRodjenja = DateTime.MinValue;

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum Rodjenja")]
        [Required(ErrorMessage = "Datum je obavezan")]
        public DateTime DatumRodjenja
        {
            get
            {

                return (_datumRodjenja == DateTime.MinValue) ? DateTime.Now : _datumRodjenja;
            }
            set
            {
                _datumRodjenja = value;
            }
        }

        [StringLength(50)]
        [Required(ErrorMessage = "Morate uneti profesiju Zaposlenog")]
        public string Profesija { get; set; } = null!;

        [StringLength(50)]
        [Required(ErrorMessage = "Morate uneti radno mesto Zaposlenog")]
        public string RadnoMesto { get; set; } = null!;

        [StringLength(50)]
        [Required(ErrorMessage = "Morate uneti mesto prebivalista")]
        public string Grad { get; set; } = null!;

        [StringLength(50)]
        [Required(ErrorMessage = "Morate uneti adresu")]
        public string Adresa { get; set; } = null!;

        [StringLength(50)]
        public string? Fiksni { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Morate uneti mobilni telefon")]
        public string Mobilni { get; set; } = null!;
        public string? Napomena { get; set; }
        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "Id ne moze da bude prazan")]
        public int PolOsobeId { get; set; }
        [ValidateNever]
        public PolVM PolVM { get; set; } = null!;
        [ValidateNever]   
        public IEnumerable<SelectListItem> PolOsobaLista { get; set; } = null!;


        [Required(ErrorMessage = "Obavezan unos")]
        [Display(Name = "Stepen strucne spreme")]
        [ForeignKey("StepenStrucneSpremeId")]
        public int StepenStrucneSpremeId { get; set; }
        [ValidateNever]
        public StepenStrucneSpremeVM StepenStrucneSpremeVM { get; set; } = null!;
        [ValidateNever]      
        public IEnumerable<SelectListItem> StepenStrucneSpremeLista { get; set; } = null!;

    }
}
