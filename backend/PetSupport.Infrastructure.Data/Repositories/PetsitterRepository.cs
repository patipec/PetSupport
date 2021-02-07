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

        public override async Task<Petsitter> GetByIdAsync(int id)
        {
            return await _context.Petsitters
                .Include(p => p.Services)
                .Include(p => p.Coordinates)
                .FirstOrDefaultAsync(p=>p.Id == id);
        }

        public async Task<IEnumerable<Petsitter>> GetAllPetsittersBySearchParametersAsync(
            PetsittersSearchParameters petsittersSearchParameters)
        {
            if (petsittersSearchParameters == null)
            {
                throw new ArgumentNullException(nameof(petsittersSearchParameters));
            }

            //filtering by City and ServiceId
            if (string.IsNullOrWhiteSpace(petsittersSearchParameters.Street)
                && petsittersSearchParameters.MaxPrice.Equals(Int32.MaxValue)
                && petsittersSearchParameters.MinPrice.Equals(0))
            {
                var conditionCity = petsittersSearchParameters.City.Trim();

                var query = _context.Petsitters
                    .AsQueryable()
                    .Include(p => p.Services)
                    .Include(p=>p.Coordinates)
                    .Where(p => p.City.Contains(conditionCity))
                    .Where(p => p.Services
                        .All(s => (int) s.Name == petsittersSearchParameters.ServiceId))
                    .ToListAsync();

                return await query;
            }
            
            //filtering by City, ServiceId and Price
            if (string.IsNullOrWhiteSpace(petsittersSearchParameters.Street))
            {
                var conditionCity = petsittersSearchParameters.City.Trim();

                var query = _context.Petsitters
                    .AsQueryable()
                    .Include(p => p.Services)
                    .Include(p=>p.Coordinates)
                    .Where(p => p.City.Contains(conditionCity))
                    .Where(p => p.Services
                        .All(s => (int) s.Name == petsittersSearchParameters.ServiceId))
                    .Where(p => p.Services
                        .All(s => s.Price >= petsittersSearchParameters.MinPrice))
                    .Where(p => p.Services
                        .All(s => s.Price <= petsittersSearchParameters.MaxPrice))
                    .ToListAsync();
                return await query;
            }
             
            //filtering by City, ServiceId, street 
            if (!string.IsNullOrWhiteSpace(petsittersSearchParameters.Street)
                && petsittersSearchParameters.MaxPrice.Equals(Int32.MaxValue)
                && petsittersSearchParameters.MinPrice.Equals(0))
            {
                var conditionCity = petsittersSearchParameters.City.Trim();
                var conditionStreet = petsittersSearchParameters.Street.Trim();

                var query = _context.Petsitters
                    .AsQueryable()
                    .Include(p => p.Services)
                    .Include(p=>p.Coordinates)
                    .Where(p => p.City == conditionCity)
                    .Where(p => p.Street.Contains(conditionStreet))
                    .Where(p => p.Services
                        .All(s => (int) s.Name == petsittersSearchParameters.ServiceId))
                    .ToListAsync();

                return await query;
            }
            
            //filtering by City, SerrviceId, Street and  Prices
            if (!string.IsNullOrWhiteSpace(petsittersSearchParameters.Street))
            {
                var conditionCity = petsittersSearchParameters.City.Trim();
                var conditionStreet = petsittersSearchParameters.Street.Trim();

                var query = _context.Petsitters
                    .AsQueryable()
                    .Include(p => p.Services)
                    .Include(p=>p.Coordinates)
                    .Where(p => p.City.Contains(conditionCity))
                    .Where(p => p.Street.Contains(conditionStreet))
                    .Where(p => p.Services
                        .All(s => (int) s.Name == petsittersSearchParameters.ServiceId))
                    .Where(p => p.Services
                        .All(s => s.Price >= petsittersSearchParameters.MinPrice))
                    .Where(p => p.Services
                        .All(s => s.Price <= petsittersSearchParameters.MaxPrice))
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