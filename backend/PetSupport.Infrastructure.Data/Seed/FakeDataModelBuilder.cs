using Microsoft.EntityFrameworkCore;
using PetSupport.Core.Entities;

namespace PetSupport.Infrastructure.Data.Seed
{
    public static class FakeDataModelBuilder
    {
        public static void SeedFakeData(this ModelBuilder modelBuilder)
        {
            var fakeData = new FakeData();

            modelBuilder.Entity<User.Client>().HasData(fakeData.FakeClients);
            modelBuilder.Entity<User.Petsitter>().HasData(fakeData.FakePetsitters);
            modelBuilder.Entity<Service>().HasData(fakeData.FakeServices);
            modelBuilder.Entity<BookingMessage>().HasData(fakeData.FakeBookingMessages);
            modelBuilder.Entity<User.Coordinate>().HasData(fakeData.FakeCoordinates);

        }
    }
}