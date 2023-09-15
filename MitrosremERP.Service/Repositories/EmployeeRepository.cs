using Microsoft.EntityFrameworkCore;
using MitrosremERP.Aplication.Data;
using MitrosremERP.Aplication.Interfaces;
using MitrosremERP.Domain.Models.PaginatedList;
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
        public async Task<PaginatedList<Zaposleni>> GetCategoriesAsync(string sortOrder, string searchString, int pageNumber, int pageSize)
        {
            var products = _context.Zaposleni.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(c => c.Ime.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    products = products.OrderByDescending(c => c.Ime);
                    break;
                case "Date":
                    products = products.OrderBy(c => c.Prezime);
                    break;
                case "date_desc":
                    products = products.OrderByDescending(c => c.Prezime);
                    break;
                default:
                    products = products.OrderBy(c => c.Ime);
                    break;
            }

            return await PaginatedList<Zaposleni>.CreateAsync(products.AsNoTracking(), pageNumber, pageSize);
        }

        public void Update(Zaposleni zaposleni)
        {
            throw new NotImplementedException();
        }
    }
}
