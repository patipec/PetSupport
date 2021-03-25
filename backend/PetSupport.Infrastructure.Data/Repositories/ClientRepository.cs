using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;
using PetSupport.Infrastructure.Data.Data;

namespace PetSupport.Infrastructure.Data.Repositories
{
    public class ClientRepository: BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(DataContext context) : base(context)
        {
        }
    }
}