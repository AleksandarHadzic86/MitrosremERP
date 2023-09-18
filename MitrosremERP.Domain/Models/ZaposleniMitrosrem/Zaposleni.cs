using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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

        [Required(ErrorMessage = "Morate uneti JMBG")]
        //[Range(13, 13, ErrorMessage = "JMBG mora da sadrzi 13 cifara")]
        public long JMBG { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Morate odabrati pol")]
        public string? Pol { get; set; }

        [StringLength(50, ErrorMessage = "Maksimalna duzina karaktera je 50")]
        [Required(ErrorMessage = "Morate uneti profesiju Zaposlenog")]   
        public string Profesija { get; set; }

        [StringLength(50, ErrorMessage = "Maksimalna duzina karaktera je 50")]
        [Required(ErrorMessage = "Morate uneti radno mesto Zaposlenog")]
        public string RadnoMesto { get; set; }

        [StringLength(50, ErrorMessage = "Maksimalna duzina karaktera je 50")]
        [Required(ErrorMessage = "Morate uneti mesto prebivalista")]
        public string Grad { get; set; }

        [StringLength(50, ErrorMessage = "Maksimalna duzina karaktera je 50")]
        [Required(ErrorMessage = "Morate uneti adresu")]
        public string Adresa { get; set; }

        [StringLength(50, ErrorMessage = "Maksimalna duzina karaktera je 50")]
        public string? Fiksni { get; set; }

        [StringLength(50, ErrorMessage = "Maksimalna duzina karaktera je 50")]
        [Required(ErrorMessage = "Morate uneti mobilni telefon")]
        public string Mobilni { get; set; }
        public string? Napomena { get; set; }

        [ValidateNever]
        public string ImageUrl { get; set; }


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
