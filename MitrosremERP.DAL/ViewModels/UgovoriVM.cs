using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.ViewModels
{
    public class UgovoriVM
    {
        public Ugovor Ugovor { get; set; }
        public IEnumerable<Zaposleni> Zasposleni { get; set; }
    }
}
