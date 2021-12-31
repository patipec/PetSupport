using Bogus;
using Bogus.Extensions;
using PetSupport.Core.Entities;
using PetSupport.Core.Enums;
using System;
using System.Collections.Generic;


namespace PetSupport.Infrastructure.Data.Seed
{
    public class FakeData
    {
        private const int NumberOfFakeDataToGenerate = 1000;
        
        public List<PetService> FakePetServices { get; protected set; } = new List<PetService>();
        public List<Animal> FakeAnimals { get; protected set; } = new List<Animal>();
        public PetPreference[] FakePetPreference { get; protected set; } 
        public List<AddressDetails> FakeAddressDetails { get; protected set; } 
        public List<BasicUserInfo> FakeBasicBasiUserInfos { get; protected set; }
        public List<BasicPetsitterProfile> FakeBasicPetsitterProfiles { get; protected set; }
        public List<BookingMessage> FakeBookingMessages { get; }
        public List<User> FakeUsers { get; }
    }
}