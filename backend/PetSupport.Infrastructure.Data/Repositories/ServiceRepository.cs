using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;

namespace PetSupport.Infrastructure.Data.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        public Task<Service> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Service>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Service>> FindByConditionAsync(Expression<Func<Service, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Add(Service entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Service entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}