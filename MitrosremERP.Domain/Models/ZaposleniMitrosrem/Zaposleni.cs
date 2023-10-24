using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using MitrosremERP.Domain.Enum;
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
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Ime { get; set; } = null!;
        [StringLength(50)]
        public string Prezime { get; set; } = null!;
        [StringLength(50)]
        public string Email { get; set; } = null!;
        [StringLength(50)]
        public string JMBG { get; set; } = null!;
        public DateTime DatumRodjenja { get; set; }
        [StringLength(50)]
        public string Profesija { get; set; } = null!;
        [StringLength(50)]
        public string RadnoMesto { get; set; } = null!;
        [StringLength(50)]
        public string Grad { get; set; } = null!;
        [StringLength(50)]
        public string Adresa { get; set; } = null!;
        [StringLength(50)]
        public string? Fiksni { get; set; }
        [StringLength(50)]
        public string Mobilni { get; set; } = null!;
        public string? Napomena { get; set; }       
        public string? ImageUrl { get; set; }

        [ForeignKey("StepenStrucneSpremeId")]
        public int StepenStrucneSpremeId { get; set; }      
        public StepenStrucneSpreme? StepenStrucneSpreme { get; set; }

        public PolOsobe PolOsobe { get; set; }
        public ICollection<Ugovor>? Ugovori { get; set; }
        public ICollection<Bolovanje>? Bolovanja { get; set; }
        public ICollection<GodisnjiOdmor>? GodisnjiOdmori { get; set; }
        public ICollection<DokumentiZaposleni>? DokumentiZaposleni { get; set; }
    }
}
