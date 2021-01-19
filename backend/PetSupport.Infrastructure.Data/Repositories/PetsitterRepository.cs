using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;
using PetSupport.Core.ResourceParameters;
using PetSupport.Infrastructure.Data.Data;

namespace PetSupport.Infrastructure.Data.Repositories
{
    public class PetsitterRepository : BaseRepository<Petsitter>, IPetsitterRepository
    {
        public PetsitterRepository(DataContext _context) : base(_context)
        {
        }


        public override async Task<IEnumerable<Petsitter>> GetAllAsync()
        {
            return await _context.Petsitters
                .OrderBy(p => p.Name)
                .ToListAsync();
        }

        public async Task<IEnumerable<Petsitter>> GetAllPetsitersBySearchPatametersAsync(
            PetsittersSearchParameters petsittersSearchParameters)
        {
            if (petsittersSearchParameters == null)
            {
                throw new ArgumentNullException(nameof(petsittersSearchParameters));
            }
            

            if (string.IsNullOrEmpty(petsittersSearchParameters.Address)
                && string.IsNullOrEmpty(petsittersSearchParameters.City) 
                && petsittersSearchParameters.ServiceId.Equals(null))
            {
                return await GetAllAsync();
            }

            if (string.IsNullOrEmpty(petsittersSearchParameters.Address))
            {
                    var query = _context.Petsitters
                        .AsQueryable()
                        .Include(p => p.Services)
                        .ThenInclude(s => s.Service)
                        .Where(p => p.City.Contains(petsittersSearchParameters.City))
                        .Where(p => p.Services
                            .Any(s => (int) s.Service.Name == petsittersSearchParameters.ServiceId))
                        .ToListAsync();
                    return await query;
            }

            else
                {
                    var query = _context.Petsitters
                        .AsQueryable()
                        .Include(p => p.Services)
                        .ThenInclude(s => s.Service)
                        .Where(p => p.City.Contains(petsittersSearchParameters.City))
                        .Where(p => p.Address.Contains(petsittersSearchParameters.Address))
                        .Where(p => p.Services
                            .Any(s => (int) s.Service.Name == petsittersSearchParameters.ServiceId))
                        .Where(p => p.Services
                            .Any(s => s.Price >= petsittersSearchParameters.MinPrice))
                        .Where(p => p.Services
                            .Any(s => s.Price <= petsittersSearchParameters.MaxPrice))
                        .ToListAsync();
                    return await query;
                }
        }
    }
}
