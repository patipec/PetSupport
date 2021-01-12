using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetSupport.Core.Entities;
using PetSupport.Core.Enums;
using PetSupport.Core.Interfaces;
using PetSupport.Infrastructure.Data.Data;

namespace PetSupport.Infrastructure.Data.Repository
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

        public async Task<IEnumerable<Petsitter>> GetAllPetsitersByCityAndService(string city, int serviceId)
        {
            var query = _context.Petsitters
                .AsQueryable()
                .Include(p => p.Services)
                .ThenInclude(s => s.Service)
                .Where(p => p.City.Contains(city))
                .Where(p=>p.Services
                    .Any(s=>(int)s.Service.Name == serviceId))
                .ToListAsync();
            return await query;





            //
            // var expression = from petsitter in petsitters.Where(p => p.City == city)
            //     from ps in petsitterServices.Where(ps => ps.ServiceId == serviceId)
            //     select new {petsitters};
            // expression.ToList();
            // return await expression.ToListAsync();
        }
    }
}