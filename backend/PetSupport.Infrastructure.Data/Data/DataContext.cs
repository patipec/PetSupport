using Microsoft.EntityFrameworkCore;
using PetSupport.Core.Entities;
using PetSupport.Infrastructure.Data.Seed;

namespace PetSupport.Infrastructure.Data.Data
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        

        private DbSet<Client> Clients { get; set; }
        private DbSet<Petsitter> Petsitters { get; set; }
        private DbSet<Service> Services { get; set; }
        private DbSet<PetsitterService> PetSupportServices { get; set; }
        private DbSet<BookingMessage> BookingMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedFakeData();
        }
    }
}