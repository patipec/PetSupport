using System.Collections.Generic;
using System.Threading.Tasks;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;
using PetSupport.Infrastructure.Data.Data;

namespace PetSupport.Infrastructure.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {
        }

        public bool CheckIfUserIsAPetsitter()
        {
            throw new System.NotImplementedException();
        }
        public Task<IEnumerable<Animal>> FindAllAnimalsOfUser()
        {
            throw new System.NotImplementedException();
        }
        public Task<User> GetByAzureId(string azureId)
        {
            throw new System.NotImplementedException();
        }
    }
}