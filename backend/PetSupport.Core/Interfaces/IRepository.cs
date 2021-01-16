using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PetSupport.Core.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<List<T>> FindByConditionAsync(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Update(T entity);
        Task<bool> SaveChangesAsync();
    }
}