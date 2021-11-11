using PetSupport.Domain.Entities;

namespace PetSupport.Application.Contracts_Interfaces.Persistence
{
    public interface IPetsitterRepository: IAsyncRepository<PetsitterProfile>
    {
        
    }
}