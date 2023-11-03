using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MitrosremERP.Application.IRepositories;
using MitrosremERP.Application.ViewModels;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using MitrosremERP.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _repository;
        private readonly ILogger _logger;

        public GenericRepository(ApplicationDbContext repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<T?> GetByIdAsync(Guid? id)
        {
            return await _repository.Set<T>().FindAsync(id);
        }
        public void Delete(T entity)
        {
            _repository.Set<T>().Remove(entity);          
        }
        public void Insert(T entity)
        {
            _repository.Set<T>().AddAsync(entity);
        }
        public void Update(T entity)
        {
            _repository.Set<T>().Update(entity);    
        }

        public virtual IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate)
        {
            return _repository.Set<T>().Where(predicate);
        }

        public async Task<IEnumerable<T>> GetPaginatedAsync(string sortOrder, string searchString, int pageNumber, int pageSize)
        {
            return await _repository.Set<T>().Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        }

        public IQueryable<T> GetQueryable()
        {
            return _repository.Set<T>().AsQueryable();
        }

       
    }
}
