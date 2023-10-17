﻿using MitrosremERP.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.ZaposleniMitrosrem
{
    public class GodisnjiOdmor
    {
        [Key]
        public Guid Id { get; set; }

        private DateTime _pocetakGodisnjeg = DateTime.MinValue;

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum pocetka godisnjeg")]
        [Required(ErrorMessage = "Datum je obavezan")]
        public DateTime DatumPocetkaGodisnjeg
        {
            get
            {

                return (_pocetakGodisnjeg == DateTime.MinValue) ? DateTime.Now : _pocetakGodisnjeg;
            }
            set
            {
                _pocetakGodisnjeg = value;
            }
        }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datum zavrsetka godisnjeg")]
        [Required(ErrorMessage = "Datum je obavezan")]
        public DateTime DatumZavrsetkaGodisnjeg
        {
            get
            {

                return (_pocetakGodisnjeg == DateTime.MinValue) ? DateTime.Now : _pocetakGodisnjeg;
            }
            set
            {
                _pocetakGodisnjeg = value;
            }
        }
        public int BrojDanaGodisnjeg { get; set; }
        public string? Napomena { get; set; }

        [ForeignKey("ZaposleniId")]
        public Guid ZaposleniId { get; set; }
        public Zaposleni Zaposleni { get; set; } = null!;

        public StatusBolGod StatusBolGod { get; set; }
    }
}
