using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.ViewModels
{
    public class BolovanjaVM
    {
        public Bolovanje Bolovanje { get; set; }
        public IEnumerable<Zaposleni> ListaZaposleni { get; set; }
      

    }
}
