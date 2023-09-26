using MitrosremERP.Aplication.Data;
using MitrosremERP.Aplication.Interfaces;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Infrastructure.Repositories
{
    public class PolRepository : Repository<Pol>, IPolRepository
    {
        public PolRepository(ApplicationDbContext repository) : base(repository)
        {
        }
    }
}
