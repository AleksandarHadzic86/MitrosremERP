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
    public class BolovanjeRepository : GenericRepository<Bolovanje>, IBolovanjeRepository
    {
        private readonly ApplicationDbContext _repository;
        private readonly ILogger _logger;
        public BolovanjeRepository(ApplicationDbContext repository, ILogger logger) : base(repository, logger)
        {
            _logger = logger;
            _repository = repository;
        }

        public void Update(Bolovanje ugovori)
        {
            throw new NotImplementedException();
        }
    }
}
