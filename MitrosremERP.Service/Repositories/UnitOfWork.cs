using MitrosremERP.Aplication.Data;
using MitrosremERP.Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Infrastructure.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            ZaposleniRepository = new EmployeeRepository(_context);
            StepenStrucneSpremeRepository = new StepenStrucneSpremeRepository(_context);
        
        }
        public IEmployeeRepository ZaposleniRepository { get; private set; }

        public IStepenStrucneSpremeRepository StepenStrucneSpremeRepository { get; private set; }   

        public void Save()
        {
            _context.SaveChanges();
        }
    }

}
