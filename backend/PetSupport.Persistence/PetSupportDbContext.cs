using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetSupport.Application.Contracts_Interfaces.Persistence;
using PetSupport.Domain.Common;
using PetSupport.Domain.Entities;
using PetSupport.Domain.Enums;
using PetSupport.Persistence.EnumConverters;

namespace PetSupport.Persistence
{
    public class PetSupportDbContext : DbContext ,IPetSupportDbContext
    {
        public PetSupportDbContext(DbContextOptions<PetSupportDbContext> options) : base(options)
        {
        }
        
        public DbSet<PetSupportUser> PetSupportUsers { get; set; }
        public DbSet<PetService> PetServices { get; set; }
        
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PetSupportUser>().OwnsOne(p=>p.BasicUserInfo);
            modelBuilder.Entity<PetSupportUser>().OwnsOne(p => p.AddressDetail);
            
            modelBuilder.Entity<PetSpecification>()
                .Property(ps => ps.PetType)
                .HasConversion<string>();
            
            modelBuilder.Entity<Animal>()
                .Property(a => a.PetType)
                .HasConversion<string>();
            modelBuilder.Entity<Animal>()
                .Property(a => a.PetWeight)
                .HasConversion<string>();
            
            modelBuilder.Entity<PetService>()
                .Property(ps => ps.Name)
                .HasConversion<string>();
            
            //Enum collection serialization in .NET Core and Entity Framework Core
            var converter = new EnumCollectionJsonValueConverter<PetWeight>();
            var comparer = new CollectionValueComparer<PetWeight>();
            modelBuilder.Entity<PetSpecification>()
                .Property(psc => psc.PetWeights)
                .HasConversion(converter)
                .Metadata.SetValueComparer(comparer);
            
            
            
            



        }        
        
        
    }
}