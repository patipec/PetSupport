using PetSupport.Core.Entities;

namespace PetSupport.Core.Interfaces
{
    public interface IPetsitterRepository : IRepository<Petsitter>
    {
        public string GetPetsiterServices(int petsitterId);
    }
}