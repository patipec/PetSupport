using Microsoft.EntityFrameworkCore;
using PetSupport.Core.Entities;

namespace PetSupport.Infrastructure.Data.Seed
{
    public static class FakeDataModelBuilder
    {
        public static void SeedFakeData(this ModelBuilder modelBuilder)
        {
            var fakeData = new FakeData();

            modelBuilder.Entity<Client>().HasData(fakeData.FakeClients);
            modelBuilder.Entity<Petsitter>().HasData(fakeData.FakePetsitters);
            modelBuilder.Entity<Service>().HasData(fakeData.FakeServices);
            modelBuilder.Entity<PetsitterService>().HasData(fakeData.FakePetsitterServices);
            modelBuilder.Entity<BookingMessage>().HasData(fakeData.FakeBookingMessages);
        }
    }
}