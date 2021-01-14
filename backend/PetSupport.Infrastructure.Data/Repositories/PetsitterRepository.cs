using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetSupport.Core.Entities;
using PetSupport.Core.ResourceParameters;
using PetSupport.Infrastructure.Data.Data;
using PetSupport.Infrastructure.Data.Repository;
using Petsupport.SharedKernel.Interfaces;

namespace PetSupport.Infrastructure.Data.Repositories
{
    public class PetsitterRepository : RepositoryBase<Petsitter>, IPetsitterRepository
    {
        public PetsitterRepository(DataContext context) : base(context)
        {
        }
        

        /*async Task<IEnumerable<Petsitter>> FindPetsitttersByCity(string city, string serviceId)
        {

            var petsitters = _context.Petsitters
                .Include(p=>p.Services)
                as IQueryable<Petsitter>;

            petsitters = petsitters.Where(ps => ps.City == city);
            services = _context.Services as Queryable

            return  _context.Petsitters
                .Include(p => p.Services)
                .ThenInclude(s => s.Service)
                .Where(ps=>ps.City == city && ps.);
        }*/

        public override async Task<IEnumerable<Petsitter>> GetAllAsync()
        {
            return await _context.Petsitters
                .OrderBy(p => p.Name)
                .ToListAsync();
        }

        public async Task<IEnumerable<Petsitter>> GetAllPetsitersBySearchPatametersAsync(PetsittersSearchParameters petsittersSearchParameters)
        {
            if (petsittersSearchParameters == null)
            {
                throw new ArgumentNullException(nameof(petsittersSearchParameters));
            }
            
            if ((petsittersSearchParameters.MaxPrice == null)
                && (petsittersSearchParameters.MinPrice == null)
                && (string.IsNullOrEmpty(petsittersSearchParameters.Address)))
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
            
            return null;
        }

        /*public async Task<IEnumerable<Petsitter>> GetAllPetsitersByCityAndService(string city)
        {
            var query = _context.Petsitters
                .AsQueryable()
                .Include(p => p.Services)
                .ThenInclude(s => s.Service)
                .Where(p => p.City.Contains(city))
                .Where(p=>p.Services
                      .Any(s=>(int)s.Service.Name == 0))
                .ToListAsync();
            return await query;
        }*/
    }


}