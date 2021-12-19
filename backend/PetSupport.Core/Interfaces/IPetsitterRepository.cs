using PetSupport.Core.Entities;
using PetSupport.Core.ResourceParameters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetSupport.Core.Interfaces
{
    public interface IPetsitterRepository : IBaseRepository<BasicPetsitterProfile>
    {
        Task<IEnumerable<BasicPetsitterProfile>> GetAllPetsittersBySearchParametersAsync
            (PetsittersSearchParameters petsittersSearchParameters);

        Task<BasicPetsitterProfile> GetByAzureId(string azureId);
    }
}