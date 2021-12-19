using Microsoft.EntityFrameworkCore;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;
using PetSupport.Core.ResourceParameters;
using PetSupport.Infrastructure.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetSupport.Infrastructure.Data.Repositories
{
    public class PetsitterRepository : BaseRepository<BasicPetsitterProfile>, IPetsitterRepository
    {
        public PetsitterRepository(DataContext _context) : base(_context)
        {
        }

        public Task<IEnumerable<BasicPetsitterProfile>> GetAllPetsittersBySearchParametersAsync(
            PetsittersSearchParameters petsittersSearchParameters)
        {
            throw new NotImplementedException();
        }

        public Task<BasicPetsitterProfile> GetByAzureId(string azureId)
        {
            throw new NotImplementedException();
        }
    }
}