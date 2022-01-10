using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetSupport.Core.Entities;

namespace PetSupport.Infrastructure.Data.Seed
{
    public static class FakeDataModelBuilder
    {
        public static void SeedFakeData(this ModelBuilder modelBuilder)
        {
            var fakeData = new FakeData();
        
            modelBuilder.Entity<BasicUserInfo>().HasData(fakeData.FakeBasicUserInfo);
            modelBuilder.Entity<AddressDetails>().HasData(fakeData.FakeAddressDetails);
            modelBuilder.Entity<BasicPetsitterProfile>().HasData(fakeData.FakeBasicPetsitterProfile);
            modelBuilder.Entity<Animal>().HasData(fakeData.FakeAnimals);
            modelBuilder.Entity<BookingMessage>().HasData(fakeData.FakeBookingMessages);
            
            modelBuilder.Entity<PetPreference>().HasData(fakeData.FakePetPreferences);
            modelBuilder.Entity<PetService>().HasData(fakeData.FakePetServices);
            modelBuilder.Entity<User>().HasData(fakeData.FakeUsers); 




            // modelBuilder.Entity<BasicUserInfo>().HasData(fakeData.FakeBasicUserDetails);

            // modelBuilder.Entity<AddressDetails>().HasData(fakeData.FakeAddresses);

            //.HasData(fakeData.FakeUsers);
            // modelBuilder.Entity<BasicUserInfo>().HasData(fakeData.FakeBasicUserDetails);
            // modelBuilder.Entity<Animal>().HasData(fakeData.FakeAnimals);

            //
            // modelBuilder.Entity<Client>().HasData(fakeData.FakeClients);
            // modelBuilder.Entity<Petsitter>().HasData(fakeData.FakePetsitters);
            // modelBuilder.Entity<Service>().HasData(fakeData.FakeServices);
            // modelBuilder.Entity<BookingMessage>().HasData(fakeData.FakeBookingMessages);
            // modelBuilder.Entity<Coordinate>().HasData(fakeData.FakeCoordinates);

        }

        public static void InitializeKeys(this ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<User>()
            //     .HasOne<BasicUserInfo>(s => s.BasicUserInfo);

        }
    }
}
