using MitrosremERP.Aplication.ViewModels;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.IRepositories
{
    public interface IGodisnjiRepository:IGenericRepository<GodisnjiOdmor>
    {
        Task<PaginatedList<GodisnjiOdmor>> GetGodisnjiPaginationAsync(string sortOrder, string searchString, int pageNumber, int pageSize);

    }
}
