using System.Collections.Generic;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;
using PetSupport.Infrastructure.Data.Data;

namespace PetSupport.Infrastructure.Data.Repositories
{
    public class PetsitterRepository : IRepository<Petsitter>, IPetsitterRepository
    {
        public IEnumerable<Petsitter> GetAll()
        {
            throw new System.NotImplementedException();
        }

        Petsitter IRepository<Petsitter>.Get(long id)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Petsitter> IRepository<Petsitter>.GetAll()
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