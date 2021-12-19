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
        public List<User> FakeUsers { get; }
        public List<PetService> FakePetServices { get; protected set; } = new List<PetService>();

        public List<BasicPetsitterProfile> FakeBasicPetsitterProfiles { get; protected set; } =
            new List<BasicPetsitterProfile>();

        public List<BookingMessage> FakeBookingMessages { get; }
    }
}