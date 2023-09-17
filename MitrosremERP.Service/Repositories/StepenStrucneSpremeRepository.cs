using MitrosremERP.Aplication.Data;
using MitrosremERP.Aplication.Interfaces;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Infrastructure.Repositories
{
    public class StepenStrucneSpremeRepository : Repository<StepenStrucneSpreme>, IStepenStrucneSpremeRepository
    {
        private readonly ApplicationDbContext _context;
        public StepenStrucneSpremeRepository(ApplicationDbContext repository) : base(repository)
        {
            _context = repository;
        }

   
        public void Update(StepenStrucneSpreme stepenStrucneSpreme)
        {
            _context.StepenStrucneSpreme.Update(stepenStrucneSpreme);
        }

    }
}
