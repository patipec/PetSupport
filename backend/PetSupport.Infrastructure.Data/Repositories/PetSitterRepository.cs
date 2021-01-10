using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetSupport.Core.Entities;
using PetSupport.Infrastructure.Data.Data;

namespace PetSupport.Infrastructure.Data.Repository
{
    public class PetSitterRepository : GenericRepository<Petsitter>
    {
        public PetSitterRepository(DataContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Petsitter>> FindByConditionAsync(Expression<Func<Petsitter, bool>> expression)
        {
            return  _context.Petsitters
                .Include(p => p.Services)
                .ThenInclude(s => s.Service)
                .Where(expression);
        }

        public override async Task<IEnumerable<Petsitter>> GetAllAsync()
        {
            return await _context.Petsitters
                .OrderBy(p => p.Name)
                .ToListAsync();
        }

        // public async Task<Petsitter[]> GetAllPetsitersByCityAndService(string city, int serviceId)
        // {
        //     IQueryable<Petsitter> query = _context.Petsitters
        //         .Include(p => p.Services)
        //         .Where(p => p.City == city);
        //     return await query.ToArrayAsync();
        //  }
    }
}