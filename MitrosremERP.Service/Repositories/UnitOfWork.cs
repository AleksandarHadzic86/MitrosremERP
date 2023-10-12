using Microsoft.Extensions.Logging;
using MitrosremERP.Aplication.Data;
using MitrosremERP.Aplication.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Infrastructure.Repositories
{
    public class UnitOfWork:IUnitOfWork,IDisposable
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<UnitOfWork> _logger;

        public UnitOfWork(ApplicationDbContext context, ILogger<UnitOfWork> logger)
        {
            _context = context;
            _logger = logger;
            ZaposleniRepository = new EmployeeRepository(_context, logger);
            StepenStrucneSpremeRepository = new StepenStrucneSpremeRepository(_context, logger);
            PolRepository = new PolRepository(_context, logger);
            UgovoriRepository = new UgovorRepository(_context, logger);
        }
        public IEmployeeRepository ZaposleniRepository { get; private set; }

        public IStepenStrucneSpremeRepository StepenStrucneSpremeRepository { get; private set; }   

        public IPolRepository PolRepository { get; private set; }
        public IUgovoriRepository UgovoriRepository { get; private set; }

        public async Task SaveAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch(Exception ex) 
            {
                _logger.LogError(ex, "Doslo je do greske prilikom cuvanja");
            }
        }
        public async void Dispose()
        {
           await _context.DisposeAsync();
        }
    }

}
