using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;

namespace PetSupport.Infrastructure.Data.Repositories
{
    class ServiceRepository: IServiceRepository, IRepository<Service>
    {
        public IEnumerable<Service> GetAll()
        {
            throw new NotImplementedException();
        }

        public Service Get(long id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Service entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Service entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Service entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Service entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
