using System.Collections.Generic;
using System.Threading.Tasks;
using PetSupport.Application.Common;
using PetSupport.Domain.Entities;

namespace PetSupport.Application.Contracts_Interfaces.Persistence
{
    public interface IPetsitterRepository: IAsyncRepository<PetsitterProfile>
    {
        Task<List<PetsitterProfile>> GetPetServicesListAsync(SearchOptionsPetsitter searchOptionsPetsitter);
    }
}