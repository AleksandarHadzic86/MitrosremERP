using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using MitrosremERP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Resources;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.ZaposleniMitrosrem
{
    public class Zaposleni
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Morate uneti Ime")]
        [DataType(DataType.Text)]
        public string Ime { get; set; } = null!;
        [StringLength(50)]
        [Required(ErrorMessage = "Morate uneti Prezime")]
        public string Prezime { get; set; } = null!;

        [StringLength(13)]
        [Required(ErrorMessage = "JMBG je obavezan.")]
        [RegularExpression(@"^\d{13}$", ErrorMessage = "JMBG mora sadržavati tačno 13 cifara.")]
        public string JMBG { get; set; } = null!;

        
        private DateTime? _datumRodjenja;

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum Rodjenja")]
        public DateTime DatumRodjenja 
        {
            get
            {
                if (_datumRodjenja == null)
                {
                    // If _datumRodjenja is null, set it to DateTime.Now
                    _datumRodjenja = DateTime.Now;
                }
                return _datumRodjenja.Value;
            }
            set
            {
                _datumRodjenja = value;
            }
        }



        [StringLength(50)]
        [Required(ErrorMessage = "Morate odabrati pol")]
        public string Pol { get; set; } = null!;

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

        [Required(ErrorMessage = "Obavezan unos")]
        [Display(Name = "Stepen strucne spreme")]
        [ForeignKey("StepenStrucneSpremeId")]
        public int StepenStrucneSpremeId { get; set; }

        [ValidateNever]
        public StepenStrucneSpreme? StepenStrucneSpreme { get; set; }
        [ValidateNever]
        public ICollection<Ugovor>? Ugovori { get; set; }
        [ValidateNever]
        public ICollection<Bolovanje>? Bolovanja { get; set; }
        [ValidateNever]
        public ICollection<GodisnjiOdmor>? GodisnjiOdmori { get; set; }
    }
}
