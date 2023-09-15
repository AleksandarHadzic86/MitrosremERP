using MitrosremERP.Domain.Models.PaginatedList;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.Interfaces
{
    public interface IEmployeeRepository:IRepository<Zaposleni>
    {
        Task<PaginatedList<Zaposleni>> GetCategoriesAsync(string sortOrder, string searchString, int pageNumber, int pageSize);
        void Update(Zaposleni zaposleni);
    }
}
