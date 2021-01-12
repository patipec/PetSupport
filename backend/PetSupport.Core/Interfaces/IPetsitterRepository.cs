using System.Collections.Generic;
using System.Threading.Tasks;
using PetSupport.Core.Entities;

namespace PetSupport.Core.Interfaces
{
    public interface IPetsitterRepository : IRepositoryBase<Petsitter>
    {
        Task<IEnumerable<Petsitter>> GetAllPetsitersByCityAndService(string city, int serviceId);
    }
}