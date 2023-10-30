using Microsoft.Extensions.Logging;
using MitrosremERP.Application.IRepositories;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using MitrosremERP.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Infrastructure.Repositories
{
    public class DokumentiRepository : GenericRepository<DokumentiZaposleni>, IDokumentiRepository
    {
        private readonly ILogger _logger;
        private readonly ApplicationDbContext _context;
        public DokumentiRepository(ApplicationDbContext repository, ILogger logger) : base(repository, logger)
        {
            _logger = logger;
            _context = repository;       
        }
    }
}
