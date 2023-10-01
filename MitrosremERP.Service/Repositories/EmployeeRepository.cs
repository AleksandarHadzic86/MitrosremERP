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


        //public async Task<PaginatedList<Zaposleni>> GetZaposleniPaginationAsync(string sortOrder, string searchString, int pageNumber, int pageSize)
        //{
        //    try
        //    {
        //        var zaposleni = _context.Zaposleni.AsQueryable();

        //        if (!string.IsNullOrEmpty(searchString))
        //        {
        //            zaposleni = zaposleni.Where(c => c.Ime.Contains(searchString));
        //        }

        //        switch (sortOrder)
        //        {
        //            case "name_desc":
        //                zaposleni = zaposleni.OrderByDescending(c => c.Ime);
        //                break;
        //            case "Date":
        //                zaposleni = zaposleni.OrderBy(c => c.Prezime);
        //                break;
        //            case "date_desc":
        //                zaposleni = zaposleni.OrderByDescending(c => c.Prezime);
        //                break;
        //            default:
        //                zaposleni = zaposleni.OrderBy(c => c.Ime);
        //                break;
        //        }

        //        return await PaginatedList<Zaposleni>.CreateAsync(zaposleni.AsNoTracking(), pageNumber, pageSize);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "{Repo} All method error", typeof(Zaposleni));
        //        throw;
        //    }
        //}

        public override IQueryable<Zaposleni> GetQueryable(Expression<Func<Zaposleni, bool>> predicate)
        {
            return _context.Zaposleni.Where(predicate);

        }
        public void Update(Zaposleni zaposleni)
        {
            var zaposleniFromDb = _context.Zaposleni.FirstOrDefault(u => u.Id == zaposleni.Id);
            if(zaposleniFromDb != null)
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
    }
}
