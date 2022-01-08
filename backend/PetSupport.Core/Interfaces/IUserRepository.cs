using System.Collections.Generic;
using System.Threading.Tasks;
using PetSupport.Core.Entities;

namespace PetSupport.Core.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {

        public bool CheckIfUserIsAPetsitter();
        Task<IEnumerable<Animal>> FindAllAnimalsOfUser();
        Task<User> GetByAzureId(string azureId);
        

    }
}