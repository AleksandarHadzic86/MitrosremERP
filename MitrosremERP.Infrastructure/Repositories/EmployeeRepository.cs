using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MitrosremERP.Aplication.Data;
using MitrosremERP.Aplication.IRepositories;
using MitrosremERP.Aplication.ViewModels;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Infrastructure.Repositories
{
    public class EmployeeRepository : GenericRepository<Zaposleni>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger _logger;   
        public EmployeeRepository(ApplicationDbContext context, ILogger logger) :base(context, logger)
        {
            _context = context;
            _logger = logger;
        }


        public async Task<PaginatedList<Zaposleni>> GetZaposleniPaginationAsync(string sortOrder, string searchString, int pageNumber, int pageSize)
        {
            try
            {
                var query = GetQueryable();

                if (!string.IsNullOrEmpty(searchString))
                {
                    query = query.Where(c => c.Ime.Contains(searchString) || c.Prezime.Contains(searchString));
                }

                switch (sortOrder)
                {
                    case "name_desc":
                        query = query.OrderByDescending(c => c.Ime);
                        break;
                    case "Date":
                        query = query.OrderBy(c => c.Prezime);
                        break;
                    case "date_desc":
                        query = query.OrderByDescending(c => c.Prezime);
                        break;
                    default:
                        query = query.OrderBy(c => c.Ime);
                        break;
                }

                var count = await query.CountAsync();
                var items = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

                return new PaginatedList<Zaposleni>(items, count, pageNumber, pageSize);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} Greska prilikom paginacije, metoda GetZaposleniPaginationAsync", typeof(Zaposleni));
                throw;
            }
        }

        public override IQueryable<Zaposleni> GetQueryable(Expression<Func<Zaposleni, bool>> predicate)
        {
            try
            {
                return _context.Zaposleni.Where(predicate);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "{Repo} Greska prilikom izvrsavanje GetQueryable metode", typeof(Zaposleni));
                throw;
            }
        }
        public void UpdateZaposleni(Zaposleni zaposleni)
        {
            try
            {
                var zaposleniFromDb = _context.Zaposleni.FirstOrDefault(u => u.Id == zaposleni.Id);
                if (zaposleniFromDb != null)
                {
                    zaposleniFromDb.Ime = zaposleni.Ime;
                    zaposleniFromDb.Prezime = zaposleni.Prezime;
                    zaposleniFromDb.Email = zaposleni.Email;
                    zaposleniFromDb.JMBG = zaposleni.JMBG;
                    zaposleniFromDb.DatumRodjenja = zaposleni.DatumRodjenja;
                    zaposleniFromDb.Profesija = zaposleni.Profesija;
                    zaposleniFromDb.RadnoMesto = zaposleni.RadnoMesto;
                    zaposleniFromDb.Grad = zaposleni.Grad;
                    zaposleniFromDb.Adresa = zaposleni.Adresa;
                    zaposleniFromDb.Fiksni = zaposleni.Fiksni;
                    zaposleniFromDb.Mobilni = zaposleni.Mobilni;
                    zaposleniFromDb.Napomena = zaposleni.Napomena;
                    zaposleniFromDb.StepenStrucneSpremeId = zaposleni.StepenStrucneSpremeId;
                    if (zaposleniFromDb.ImageUrl != null)
                    {
                        zaposleniFromDb.ImageUrl = zaposleni.ImageUrl;
                    }

                }
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "{Repo} Greska prilikom update zaposlenog", typeof(Zaposleni));
                throw;
            }
           
        }
    }
}
