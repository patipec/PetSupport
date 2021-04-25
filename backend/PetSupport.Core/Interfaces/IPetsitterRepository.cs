using PetSupport.Core.Entities;
using PetSupport.Core.ResourceParameters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetSupport.Core.Interfaces
{
    public interface IPetsitterRepository : IBaseRepository<User.Petsitter>
    {

        Task<IEnumerable<User.Petsitter>> GetAllPetsittersBySearchParametersAsync

            (PetsittersSearchParameters petsittersSearchParameters);
        Task<User.Petsitter> GetByAzureId(string azureId);

    }
}