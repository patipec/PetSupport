using System.Collections.Generic;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;

namespace PetSupport.Infrastructure.Data.Repositories
{
    public class PetsitterRepository: IPetsitterRepository
    {
        private readonly PetsitterRepository _petsitterRepository;

        public IEnumerable<Petsitter> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Petsitter Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Petsitter entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Petsitter entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Petsitter entity)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Petsitter entity)
        {
            throw new System.NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}