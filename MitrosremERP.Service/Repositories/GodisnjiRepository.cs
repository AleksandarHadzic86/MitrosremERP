using Microsoft.Extensions.Logging;
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
    public class GodisnjiRepository : GenericRepository<GodisnjiOdmor>, IGodisnjiRepository
    {
        private readonly ILogger _logger;
        private readonly ApplicationDbContext _context;
        public GodisnjiRepository(ApplicationDbContext repository, ILogger logger) : base(repository, logger)
        {
            _logger = logger;
            _context = repository;
        }
    }
}
