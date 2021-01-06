using System.Linq;
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

        // public async Task<Petsitter[]> GetAllPetsitersByCityAndService(string city, int serviceId)
        // {
        //     IQueryable<Petsitter> query = _context.Petsitters
        //         .Include(p => p.Services)
        //         .Where(p => p.City == city);
        //     return await query.ToArrayAsync();
        // }
    }
}