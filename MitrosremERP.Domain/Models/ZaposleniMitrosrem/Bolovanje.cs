﻿using MitrosremERP.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.ZaposleniMitrosrem
{
    public class Bolovanje
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime DatumPocetkaBolovanja { get; set; }
        public DateTime? DatumZavrsetkaBolovanja { get; set; }
        public int? BrojDanaBolovanja { get; set; }
        public string? Napomena { get; set; }


        [ForeignKey("ZaposleniId")]
        public Guid ZaposleniId { get; set; }
        public Zaposleni Zaposleni { get; set; } = null!;

        public StatusBolGod StatusBolGod { get; set; }
    }
}
