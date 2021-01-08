using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PetSupport.Core.Entities;

namespace PetSupport.Core.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<List<Petsitter>> FindByConditionAsync(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Update(T entity);
        Task<bool> SaveChangesAsync();
    }
}