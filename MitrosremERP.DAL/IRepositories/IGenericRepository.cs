using Microsoft.VisualBasic.FileIO;
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
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(Guid? id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> GetQueryable();
        IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetPaginatedAsync(string sortOrder, string searchString, int pageNumber, int pageSize);

        //Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);
        void Insert (T entity);
        void Delete (T entity);
        void Update(T entity);
        
    }
}
 