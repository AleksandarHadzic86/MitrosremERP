using MitrosremERP.Application.ViewModels;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Application.IRepositories
{
    public interface IUgovoriRepository:IGenericRepository<Ugovor>
    {
        Task<PaginatedList<Ugovor>> GetUgovorPaginationAsync(string sortOrder, string searchString, int pageNumber, int pageSize);
    }
}
