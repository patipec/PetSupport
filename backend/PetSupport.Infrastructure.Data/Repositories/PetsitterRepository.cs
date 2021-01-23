using System;
using System.Collections.Generic;
using System.Linq;
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

            //empty conditions
            if (string.IsNullOrWhiteSpace(petsittersSearchParameters.Street)
                && string.IsNullOrWhiteSpace(petsittersSearchParameters.City)
                && petsittersSearchParameters.ServiceId.Equals(null)
                && petsittersSearchParameters.MaxPrice.Equals(Int32.MaxValue)
                && petsittersSearchParameters.MinPrice.Equals(0))
            {
                return await GetAllAsync();
            }


            //filtering only by Street
            if (!string.IsNullOrWhiteSpace(petsittersSearchParameters.Street)
                && string.IsNullOrWhiteSpace(petsittersSearchParameters.City)
                && petsittersSearchParameters.ServiceId.Equals(null)
                && petsittersSearchParameters.MaxPrice.Equals(Int32.MaxValue)
                && petsittersSearchParameters.MinPrice.Equals(0))
            {
                var conditionStreet = petsittersSearchParameters.Street.Trim();
                return await base.FindByConditionAsync
                    (p => p.Street == conditionStreet);
            }

            //filtering only by City
            if (string.IsNullOrWhiteSpace(petsittersSearchParameters.Street)
                && !string.IsNullOrWhiteSpace(petsittersSearchParameters.City)
                && petsittersSearchParameters.ServiceId.Equals(null)
                && petsittersSearchParameters.MaxPrice.Equals(Int32.MaxValue)
                && petsittersSearchParameters.MinPrice.Equals(0))
            {
                var conditionCity = petsittersSearchParameters.City.Trim();

                return await base.FindByConditionAsync
                    (p => p.City == conditionCity);
            }
            
            //filtering only by ServiceId
            if (string.IsNullOrWhiteSpace(petsittersSearchParameters.Street)
                && string.IsNullOrWhiteSpace(petsittersSearchParameters.City)
                && !petsittersSearchParameters.ServiceId.Equals(null)
                && petsittersSearchParameters.MaxPrice.Equals(Int32.MaxValue)
                && petsittersSearchParameters.MinPrice.Equals(0))
            {
                var query = _context.Petsitters
                    .AsQueryable()
                    .Include(p => p.Services)
                    .ThenInclude(s => s.Service)
                    .Where(p => p.Services
                        .Any(s => (int) s.Service.Name == petsittersSearchParameters.ServiceId))
                    .ToListAsync();

                return await query;
            }

            //filtering by City and ServiceId
            if (string.IsNullOrWhiteSpace(petsittersSearchParameters.Street)
                && !string.IsNullOrWhiteSpace(petsittersSearchParameters.City)
                && !petsittersSearchParameters.ServiceId.Equals(null)
                && petsittersSearchParameters.MaxPrice.Equals(Int32.MaxValue)
                && petsittersSearchParameters.MinPrice.Equals(0))
            {
                var conditionCity = petsittersSearchParameters.City.Trim();

                var query = _context.Petsitters
                    .AsQueryable()
                    .Include(p => p.Services)
                    .ThenInclude(s => s.Service)
                    .Where(p => p.City == conditionCity)
                    .Where(p => p.Services
                        .Any(s => (int) s.Service.Name == petsittersSearchParameters.ServiceId))
                    .ToListAsync();

                return await query;
            }

            //filtering by City and Street
            if (!string.IsNullOrWhiteSpace(petsittersSearchParameters.Street)
                && !string.IsNullOrWhiteSpace(petsittersSearchParameters.City)
                && petsittersSearchParameters.ServiceId.Equals(null)
                && petsittersSearchParameters.MaxPrice.Equals(Int32.MaxValue)
                && petsittersSearchParameters.MinPrice.Equals(0))
            {
                var conditionCity = petsittersSearchParameters.City.Trim();
                var conditionStreet = petsittersSearchParameters.Street.Trim();

                return await base.FindByConditionAsync
                (p => p.City == conditionCity
                      && p.Street == conditionStreet);
            }
            
            //filtering by City, Street and prices
            if (!string.IsNullOrWhiteSpace(petsittersSearchParameters.Street)
                && !string.IsNullOrWhiteSpace(petsittersSearchParameters.City)
                && petsittersSearchParameters.ServiceId.Equals(null))
            {
                var conditionCity = petsittersSearchParameters.City.Trim();
                var conditionStreet = petsittersSearchParameters.Street.Trim();

                var query = _context.Petsitters
                    .AsQueryable()
                    .Include(p => p.Services)
                    .ThenInclude(s => s.Service)
                    .Where(p => p.City == conditionCity)
                    .Where(p => p.Street == conditionStreet)
                    .Where(p => p.Services
                        .Any(s => (int) s.Service.Name == petsittersSearchParameters.ServiceId))
                    .Where(p => p.Services
                        .Any(s => s.Price >= petsittersSearchParameters.MinPrice))
                    .Where(p => p.Services
                        .Any(s => s.Price <= petsittersSearchParameters.MaxPrice))
                    .ToListAsync();

                return await query;
            }

            //filtering by min and max Price
            if (string.IsNullOrWhiteSpace(petsittersSearchParameters.Street)
                && string.IsNullOrWhiteSpace(petsittersSearchParameters.City)
                && petsittersSearchParameters.ServiceId.Equals(null))
            {
                var query = _context.Petsitters
                    .AsQueryable()
                    .Include(p => p.Services)
                    .ThenInclude(s => s.Service)
                    .Where(p => p.Services
                        .Any(s => s.Price >= petsittersSearchParameters.MinPrice))
                    .Where(p => p.Services
                        .Any(s => s.Price <= petsittersSearchParameters.MaxPrice))
                    .ToListAsync();
                return await query;
            }
            
            
            //filtering by min, max Price and City
            if (string.IsNullOrWhiteSpace(petsittersSearchParameters.Street)
                && !string.IsNullOrWhiteSpace(petsittersSearchParameters.City)
                && petsittersSearchParameters.ServiceId.Equals(null))
            {
                var conditionCity = petsittersSearchParameters.City.Trim();
                
                var query = _context.Petsitters
                    .AsQueryable()
                    .Where(p => p.City == conditionCity)
                    .Include(p => p.Services)
                    .ThenInclude(s => s.Service)
                    .Where(p => p.Services
                        .Any(s => s.Price >= petsittersSearchParameters.MinPrice))
                    .Where(p => p.Services
                        .Any(s => s.Price <= petsittersSearchParameters.MaxPrice))
                    
                    .ToListAsync();
                return await query;
            }
            
            //filtering by min, max Price and Street
            if (!string.IsNullOrWhiteSpace(petsittersSearchParameters.Street)
                && string.IsNullOrWhiteSpace(petsittersSearchParameters.City)
                && petsittersSearchParameters.ServiceId.Equals(null))
            {
                var conditionStreet = petsittersSearchParameters.Street.Trim();
                
                var query = _context.Petsitters
                    .AsQueryable()
                    .Where(p => p.Street == conditionStreet)
                    .Include(p => p.Services)
                    .ThenInclude(s => s.Service)
                    .Where(p => p.Services
                        .Any(s => s.Price >= petsittersSearchParameters.MinPrice))
                    .Where(p => p.Services
                        .Any(s => s.Price <= petsittersSearchParameters.MaxPrice))
                    
                    .ToListAsync();
                return await query;
            }


            //filtering by City, Street and SerrviceId and prices

            if (!string.IsNullOrWhiteSpace(petsittersSearchParameters.Street)
                && !string.IsNullOrWhiteSpace(petsittersSearchParameters.City)
                && !petsittersSearchParameters.ServiceId.Equals(null))
            {
                var conditionCity = petsittersSearchParameters.City.Trim();
                var conditionStreet = petsittersSearchParameters.Street.Trim();

                var query = _context.Petsitters
                    .AsQueryable()
                    .Include(p => p.Services)
                    .ThenInclude(s => s.Service)
                    .Where(p => p.City.Contains(conditionCity))
                    .Where(p => p.Street.Contains(conditionStreet))
                    .Where(p => p.Services
                        .Any(s => (int) s.Service.Name == petsittersSearchParameters.ServiceId))
                    .Where(p => p.Services
                        .Any(s => s.Price >= petsittersSearchParameters.MinPrice))
                    .Where(p => p.Services
                        .Any(s => s.Price <= petsittersSearchParameters.MaxPrice))
                    .ToListAsync();
                return await query;
            }

            else
            {
                return await GetAllAsync();
            }
        }
    }
}
