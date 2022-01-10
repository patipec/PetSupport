using Microsoft.EntityFrameworkCore;
using PetSupport.Core.Entities;

namespace PetSupport.Infrastructure.Data.Seed
{
    public static class FakeDataModelBuilder
    {
        public static void SeedFakeData(this ModelBuilder modelBuilder)
        {
            var fakeData = new FakeData();
            
            modelBuilder.Entity<BasicPetsitterProfile>().HasData(fakeData.FakeBasicPetsitterProfiles);
            modelBuilder.Entity<PetService>().HasData(fakeData.FakePetServices);
            modelBuilder.Entity<BookingMessage>().HasData(fakeData.FakeBookingMessages);
            modelBuilder.Entity<BasicUserInfo>().HasData(fakeData.FakeBasicUserInfos);
            modelBuilder.Entity<AddressDetails>().HasData(fakeData.FakeAddressDetails);
            modelBuilder.Entity<PetPreference>().HasData(fakeData.FakePetPreferences);
            modelBuilder.Entity<Animal>().HasData(fakeData.FakeAnimals);
            modelBuilder.Entity<User>().HasData(fakeData.FakeUsers);
            
        }
    }
}