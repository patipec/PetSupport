using System.Collections.Generic;
using System.Threading.Tasks;
using PetSupport.Core.Entities;
using PetSupport.Core.ResourceParameters;

namespace PetSupport.Core.Interfaces
{
    public interface IPetsitterRepository : IBaseRepository<Petsitter>
    {

        Task<IEnumerable<Petsitter>> GetAllPetsittersBySearchParametersAsync

            (PetsittersSearchParameters petsittersSearchParameters);

        Task<Petsitter> GetByAzureId(string azureId);
    }
}