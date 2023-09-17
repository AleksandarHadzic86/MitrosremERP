using Microsoft.EntityFrameworkCore;
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
    public class EmployeeRepository : Repository<Zaposleni>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context) :base(context)
        {
            _context = context; 
        }

        public void Update(Zaposleni zaposleni)
        {
            throw new NotImplementedException();
        }
    }
}
