using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetSupport.Domain.Entities;

namespace PetSupport.Application.Contracts_Interfaces.Persistence
{
    public interface IPetSupportDbContext
    { 
        DbSet<PetSupportUser> PetSupportUsers { get; set; }
        
        DbSet<PetService> PetServices { get; set; }
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}