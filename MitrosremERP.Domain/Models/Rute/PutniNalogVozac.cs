using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain.Models.Rute
{
    public class PutniNalogVozac
    {
        [Key]
        public Guid Id { get; set; }
        public PutniNalog PutniNalog { get; set; } = null!;
        public Vozaci Vozaci { get; set; } = null!;
    }
}
