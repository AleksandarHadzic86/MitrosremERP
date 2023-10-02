using MitrosremERP.Aplication.ViewModels;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace MitrosremERP.Aplication.IRepositories
{
    public interface IEmployeeRepository:IGenericRepository<Zaposleni>
    {   
        void Update(Zaposleni zaposleni);
        Task<PaginatedList<Zaposleni>> GetZaposleniPaginationAsync(string sortOrder, string searchString, int pageNumber, int pageSize);

    }
}
