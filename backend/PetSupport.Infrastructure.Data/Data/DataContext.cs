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

        public DbSet<AddressDetails> AddressDetails { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<BasicPetsitterProfile> BasicPetsitterProfiles { get; set; }
        public DbSet<BasicUserInfo> BasicUserInfos { get; set; }
        public DbSet<BookingMessage> BookingMessages { get; set; }
        public DbSet<PetPreference> PetPreferences { get; set; }
        public DbSet<PetService> Services { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BasicPetsitterProfile> Petsitters { get; set; }
       
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedFakeData();
        }
    }
}