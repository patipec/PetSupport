using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;
using PetSupport.Infrastructure.Data.Data;

namespace PetSupport.Infrastructure.Data.Repositories
{
    public class PetsitterRepository : IRepository<Petsitter>, IPetsitterRepository
    {
        public Task<Petsitter> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Petsitter>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Petsitter>> FindByConditionAsync(Expression<Func<Petsitter, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Add(Petsitter entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Petsitter entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}