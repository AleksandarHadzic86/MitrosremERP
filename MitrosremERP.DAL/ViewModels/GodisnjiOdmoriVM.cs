﻿
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.ViewModels
{
    public class GodisnjiOdmoriVM
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Obavezan unos pocetak Godisnjeg")]
        [Display(Name = "Datum od: ")]
        public DateOnly PocetakGodisnjegOdmora { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Obavezan unos kraj Godisnjeg")]
        [Display(Name = "Datum do: ")]
        public DateOnly ZavrsetakGodisnjegOdmora { get; set; }

        [Required(ErrorMessage = "Obavezan unos broj dana godisnjeg odmora")]
        public int BrojDanaGodisnjeg { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Obavezan unos status godisnjeg")]
        public string StatusGodisnjeg { get; set; } = null!;

        [StringLength(250)]
        public string? Napomena { get; set; }


        [ForeignKey("ZaposleniId")]
        public int ZaposleniId { get; set; }
        public Zaposleni Zaposleni { get; set; } = null!;

    }
}
