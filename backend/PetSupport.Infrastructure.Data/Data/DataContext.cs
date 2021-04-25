using Microsoft.EntityFrameworkCore;
using PetSupport.Core.Entities;
using PetSupport.Infrastructure.Data.Seed;

namespace PetSupport.Infrastructure.Data.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User.Client> Clients { get; set; }
        public DbSet<User.Petsitter> Petsitters { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<BookingMessage> BookingMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedFakeData();
        }
    }
}