using PetSupport.Core.Entities;
using PetSupport.Infrastructure.Data.Data;

namespace PetSupport.Infrastructure.Data.Repository
{
    public class ServiceRepository: GenericRepository<Service>
    {
        public ServiceRepository(DataContext context) : base(context)
        {
        }
    }
}