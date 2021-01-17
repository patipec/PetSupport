using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetSupport.Core.Interfaces;
using PetSupport.Infrastructure.Data.Data;

namespace PetSupport.Infrastructure.Data.Repository
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        protected DataContext _context;
        
        public GenericRepository(DataContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _context.FindAsync<T>(id);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<List<T>> FindByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>()
                .AsQueryable()
                .Where(expression).ToListAsync();
        }

        public virtual void Add(T entity)
        {
            _context.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _context.Update(entity);
        }
        

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;

        }

    }
}