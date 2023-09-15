
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.ViewModels
{
    public class GodisnjiOdmoriVM
    {
        public GodisnjiOdmor GodisnjiOdmor { get; set; }
        public IEnumerable<Zaposleni> Zaposleni { get; set; }
    }
}
