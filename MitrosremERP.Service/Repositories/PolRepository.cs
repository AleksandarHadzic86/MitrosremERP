using MitrosremERP.Aplication.Data;
using MitrosremERP.Aplication.IRepositories;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Infrastructure.Repositories
{
    public class PolRepository : GenericRepository<Pol>, IPolRepository
    {
        public PolRepository(ApplicationDbContext repository) : base(repository)
        {
        }
    }
}
