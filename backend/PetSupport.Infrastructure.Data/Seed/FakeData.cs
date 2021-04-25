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
        public List<User.Client> FakeClients { get; }
        public List<Service> FakeServices { get; protected set; } = new List<Service>();
        public List<User.Coordinate> FakeCoordinates { get; }
        public List<User.Petsitter> FakePetsitters { get; protected set; } = new List<User.Petsitter>();
        public List<BookingMessage> FakeBookingMessages { get; }

        public FakeData()
        {
            //Set the randomizer seed if you wish to generate repeatable data sets.
            Randomizer.Seed = new Random(8675309);

            var clientId = 1;
            var clientFaker = new Faker<User.Client>()
                .RuleFor(c => c.Id, f => clientId++)
                .RuleFor(c => c.Name, f => f.Person.FirstName)
                .RuleFor(c => c.Surname, f => f.Person.LastName)
                .RuleFor(c => c.Email, (f, u) => f.Internet.Email(u.Name, u.Surname))
                .RuleFor(c => c.PhoneNumber, f => f.Person.Phone)
                .RuleFor(c => c.AzureId, f => Guid.NewGuid().ToString());
            FakeClients = clientFaker.Generate(NumberOfFakeDataToGenerate);


            var serviceId = 1;
            var serviceFaker = new Faker<Service>()
                .RuleFor(s => s.Id, f => serviceId++)
                .RuleFor(s => s.Name, f => f.PickRandom<ServiceType>())
                .RuleFor(s => s.Unit, f => f.PickRandom<Unit>())
                .RuleFor(p => p.Price, f => double.Parse(f.Commerce.Price(min: 10, max: 50, 0)))
                .RuleFor(s => s.PetType, f => f.PickRandom<PetType>())
                .RuleFor(s => s.PetWeight, f => f.PickRandom<PetWeight>());


            // Petsitter and Client entity inherit for user class so they have the same column with Id on the data table.
            var petsitterId = clientId;
            var petsitterFaker = new Faker<User.Petsitter>()
                .StrictMode(false)
                .RuleFor(p => p.Id, f => petsitterId++)
                .RuleFor(p => p.AzureId, f => Guid.NewGuid().ToString())
                .RuleFor(p => p.Name, f => f.Person.FirstName)
                .RuleFor(p => p.Surname, f => f.Person.LastName)
                .RuleFor(p => p.Email, (f, u) => f.Internet.Email(u.Name, u.Surname))
                .RuleFor(p => p.PhoneNumber, f => f.Person.Phone)
                .RuleFor(p => p.Description, f => f.Lorem.Sentence(30))
                .RuleFor(p => p.PhotoId, f => f.Image.PicsumUrl())
                //.RuleFor(p => p.City, f => f.PickRandomParam("Radom", "Warsaw", "Gdynia"))
                .Rules((f, pet) =>
                {
                    if (petsitterId >= 1001 && petsitterId <= 2000)
                    {
                        pet.City = "Radom";
                    }
                    if (petsitterId >= 2001 && petsitterId <= 3000)
                    {
                        pet.City = "Warsaw";
                    }
                    if (petsitterId >= 3001 && petsitterId <= 4002)
                    {
                        pet.City = "Gdynia";
                    }
                })
                .RuleFor(p => p.Street, f => f.Address.StreetName())
                .RuleFor(p => p.ParcelAndHouseNumbers, f => f.Address.BuildingNumber())
                .RuleFor(p => p.ZipCode, f => f.Address.ZipCode())
                .RuleFor(p => p.Country, f => f.Address.Country())
                .RuleFor(p => p.Rate, f => f.Random.Double(1, 5))
                .RuleFor(p => p.AvailabilityFrom, f => f.Date.Recent())
                .RuleFor(p => p.AvailabilityTo, f => f.Date.Future())
                .RuleFor(p => p.DateOfBirth, f => f.Person.DateOfBirth)
                .RuleFor(p => p.Title, f => f.Lorem.Sentence(2))
                .RuleFor(p => p.Environment, f => f.Lorem.Sentence(5))
                .RuleFor(p => p.Experience, f => f.Lorem.Sentence(7))
                .RuleFor(p => p.Services, (f, p) =>
                {
                    serviceFaker.RuleFor(s => s.PetsitterId, _ => p.Id);
                    var fakeServices = serviceFaker.GenerateBetween(1, 3);
                    FakeServices.AddRange(fakeServices);
                    return null; // Petsitter.Services is a getter only. The return value has no impact.
                });
            var fakePetsitters = petsitterFaker.Generate(NumberOfFakeDataToGenerate * 3);
            FakePetsitters.AddRange(fakePetsitters);


            var coordinateId = 1;
            var petsitterPriamaryId = 1001;
            var coordinateFaker = new Faker<User.Coordinate>()
                .StrictMode(false)
                .RuleFor(c => c.Id, f => coordinateId++)
                .RuleFor(c => c.PetsitterId, f => petsitterPriamaryId++)

                .Rules((f, o) =>
                {
                    //Radom city coordinates
                    if (coordinateId >= 1 && coordinateId <= 1000)
                    {
                        o.Latitude = f.Address.Latitude(51.39, 51.41);
                        o.Longitude = f.Address.Longitude(21.12, 21.19);
                    }
                    //Warsaw city coordinates
                    if (coordinateId >= 1000 && coordinateId <= 2000)
                    {
                        o.Latitude = f.Address.Latitude(52.17, 52.27);
                        o.Longitude = f.Address.Longitude(20.91, 21.19);
                    }
                    //Gdynia city coordinates
                    if (coordinateId >= 2000 && coordinateId <= 3002)
                    {
                        o.Latitude = f.Address.Latitude(54.47, 54.50);
                        o.Longitude = f.Address.Longitude(18.52, 18.55);
                    }
                });
            FakeCoordinates = coordinateFaker.Generate(3000);

            var bookingMessageId = 1;
            var bookingMessageFaker = new Faker<BookingMessage>()
                .RuleFor(bm => bm.Id, f => bookingMessageId++)
                .RuleFor(bm => bm.PetsitterId, f => f.PickRandom(FakePetsitters).Id)
                .RuleFor(bm => bm.ClientId, f => f.PickRandom(FakeClients).Id)
                .RuleFor(bm => bm.Text, f => f.Lorem.Paragraphs(4));
            FakeBookingMessages = bookingMessageFaker.Generate(NumberOfFakeDataToGenerate / 2);

        }
    }

}