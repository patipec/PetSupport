using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;
using PetSupport.Infrastructure.Data.Data;

namespace PetSupport.Infrastructure.Data.Repository
{
    public class PetsitterServiceRepository : RepositoryBase<PetsitterService>, IPetsitterServiceRepository
    {
        public PetsitterServiceRepository(DataContext context) : base(context)
        {
        }
    }
}