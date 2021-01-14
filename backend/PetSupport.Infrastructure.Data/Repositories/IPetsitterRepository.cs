using System.Collections.Generic;
using System.Threading.Tasks;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;
using PetSupport.Core.ResourceParameters;

namespace Petsupport.SharedKernel.Interfaces
{
    public interface IPetsitterRepository : IRepositoryBase<Petsitter>
    {
        Task<IEnumerable<Petsitter>> GetAllPetsitersBySearchPatametersAsync
            (PetsittersSearchParameters petsittersSearchParameters);
    }
}