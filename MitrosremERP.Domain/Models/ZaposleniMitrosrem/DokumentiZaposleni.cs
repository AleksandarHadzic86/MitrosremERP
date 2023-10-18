using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.ZaposleniMitrosrem
{
    public class DokumentiZaposleni
    {
        [Key]
        public Guid Id { get; set; }
        public string ImeDokumenta { get; set; } = null!;     
        public string PutanjaDokumenta { get; set; } = null!;
        public string? Napomena { get; set; }

        [ForeignKey("ZaposleniId")]
        public Guid ZaposleniId { get; set; }
        public Zaposleni Zaposleni { get; set; } = null!;
    }
}
