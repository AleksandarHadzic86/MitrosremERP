using Microsoft.EntityFrameworkCore;
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
    public class EmployeeRepository : GenericRepository<Zaposleni>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context) :base(context)
        {
            _context = context; 
        }

        public async Task<Zaposleni> UpdateAsync(Zaposleni zaposleni)
        {
            var zaposleniFromDb = await _context.Zaposleni.FirstOrDefaultAsync(u => u.Id == zaposleni.Id);
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
            return zaposleniFromDb;
        }
    }
}
