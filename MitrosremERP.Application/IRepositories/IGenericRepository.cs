using Microsoft.VisualBasic.FileIO;
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
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(Guid? id);
        IQueryable<T> GetQueryable();
        IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetPaginatedAsync(string sortOrder, string searchString, int pageNumber, int pageSize);

        void Insert (T entity);
        void Delete (T entity);
        void Update(T entity);
        
    }
}
 