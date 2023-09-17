using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.Interfaces
{
    public interface IStepenStrucneSpremeRepository:IRepository<StepenStrucneSpreme>
    {
        void Update(StepenStrucneSpreme stepenStrucneSpreme);
    }
}
