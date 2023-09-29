﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MitrosremERP.Aplication.Data;
using MitrosremERP.Aplication.IRepositories;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
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

        public GenericRepository(ApplicationDbContext repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.Set<T>().ToListAsync();
        }


        public async Task<T?> GetByIdAsync(int id)
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

        //public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression)
        //{
        //    return await _repository.Set<T>().FirstOrDefaultAsync(expression);
        //}

        public virtual IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate)
        {
            return _repository.Set<T>();
        }
    }
}
