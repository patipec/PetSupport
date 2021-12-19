using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PetSupport.Infrastructure.Data.Repositories
{
    public class PetServiceRepository : IPetServiceRepository
    {
        public Task<PetService> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PetService>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PetService>> FindByConditionAsync(Expression<Func<PetService, bool>> expression)
        {
            throw new NotImplementedException();
        }


        public void Add(PetService entity)
        {
            throw new NotImplementedException();
        }

        public void Update(PetService entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}