using PetSupport.Core.Entities;
using PetSupport.Core.ResourceParameters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetSupport.Core.Interfaces
{
    public interface IPetsitterRepository : IBaseRepository<BasicPetsitterProfileId>
    {
        
        //TODO check if it is ok - maybe it should return User that fulfill some conditions
        Task<IEnumerable<BasicPetsitterProfileId>> GetAllPetsittersBySearchParametersAsync
            (PetsittersSearchParameters petsittersSearchParameters);
        
    }
}