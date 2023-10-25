using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MitrosremERP.Aplication.Data;
using MitrosremERP.Aplication.IRepositories;
using MitrosremERP.Aplication.ViewModels;
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
        public async Task<PaginatedList<GodisnjiOdmor>> GetGodisnjiPaginationAsync(string sortOrder, string searchString, int pageNumber, int pageSize)
        {
            try
            {
                var query = GetQueryable().Include(u => u.Zaposleni);

                if (!string.IsNullOrEmpty(searchString))
                {
                    query = query
                .Where(c => c.Zaposleni.Ime.Contains(searchString) || c.Zaposleni.Prezime.Contains(searchString))
                .Include(c => c.Zaposleni);
                }

                switch (sortOrder)
                {
                    case "name_desc":
                        query = query
                            .OrderByDescending(c => c.Zaposleni.Ime)
                            .Include(c => c.Zaposleni); // Include Zaposleni for sorting
                        break;
                    case "Date":
                        query = query
                            .OrderBy(c => c.Zaposleni.Prezime)
                            .Include(c => c.Zaposleni); // Include Zaposleni for sorting
                        break;
                    case "date_desc":
                        query = query
                            .OrderByDescending(c => c.Zaposleni.Prezime)
                            .Include(c => c.Zaposleni); // Include Zaposleni for sorting
                        break;
                    default:
                        query = query
                            .OrderBy(c => c.Zaposleni.Ime)
                            .Include(c => c.Zaposleni); // Include Zaposleni for sorting
                        break;
                }

                var count = await query.CountAsync();
                var items = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                return new PaginatedList<GodisnjiOdmor>(items, count, pageNumber, pageSize);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Greska prilikom paginacije, metoda GetZaposleniPaginationAsync", typeof(GodisnjiOdmor));
                throw;
            }
        }
    }
}
