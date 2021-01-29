using System;
using System.Collections.Generic;
using Bogus;
using Bogus.Extensions;
using PetSupport.Core.Entities;
using PetSupport.Core.Enums;

namespace PetSupport.Infrastructure.Data.Seed
{
    public class FakeData
    {
        private const int NumberOfFakeDataToGenerate = 100;
        public List<Client> FakeClients { get; }
        public List<Service> FakeServices { get; protected set; } = new List<Service>();
        public List<Petsitter> FakePetsitters { get; protected set; } = new List<Petsitter>();
        public List<BookingMessage> FakeBookingMessages { get; }

        public FakeData()
        {
            //Set the randomizer seed if you wish to generate repeatable data sets.
            Randomizer.Seed = new Random(8675309);

            var clientId = 1;
            var clientFaker = new Faker<Client>()
                .RuleFor(c => c.Id, f => clientId++)
                .RuleFor(c => c.Name, f => f.Person.FirstName)
                .RuleFor(c => c.Surname, f => f.Person.LastName)
                .RuleFor(c => c.Email, (f, u) => f.Internet.Email(u.Name, u.Surname))
                .RuleFor(c => c.PhoneNumber, f => f.Person.Phone)
                .RuleFor(c => c.AzureId, f => Guid.NewGuid());
            FakeClients = clientFaker.Generate(NumberOfFakeDataToGenerate);
            
            
            var serviceId = 1;
            var serviceFaker = new Faker<Service>()
                .RuleFor(s => s.Id, f => serviceId++)
                .RuleFor(s => s.Name, f => f.PickRandom<ServiceType>())
                .RuleFor(s => s.Unit, f => f.PickRandom<Unit>())
                .RuleFor(p => p.Price, f => double.Parse(f.Commerce.Price(min: 10, max: 50, 0)));

            
            // Petsitter and Client entity inherit for user class so they have the same column with Id on the data table.
            var petsitterId = clientId;
            var petsitterFaker = new Faker<Petsitter>()
                .RuleFor(p => p.Id, f => petsitterId++)
                .RuleFor(p => p.AzureId, f => Guid.NewGuid())
                .RuleFor(p => p.Name, f => f.Person.FirstName)
                .RuleFor(p => p.Surname, f => f.Person.LastName)
                .RuleFor(p => p.Email, (f, u) => f.Internet.Email(u.Name, u.Surname))
                .RuleFor(p => p.PhoneNumber, f => f.Person.Phone)
                .RuleFor(p => p.Description, f => f.Lorem.Sentence(30))
                .RuleFor(p => p.PhotoId, f => f.Image.PicsumUrl())
                .RuleFor(p => p.City, f => f.PickRandomParam("Radom", "Warsaw", "Gdynia"))
                .RuleFor(p => p.Street, f => f.Address.StreetName())
                .RuleFor(p => p.ParcelAndHouseNumbers, f => f.Address.BuildingNumber())
                .RuleFor(p => p.ZipCode, f => f.Address.ZipCode())
                .RuleFor(p => p.Country, f => f.Address.Country())
                .RuleFor(p => p.Rate, f => f.Random.Double(1, 5))
                .RuleFor(p => p.AvailabilityFrom, f => f.Date.Recent())
                .RuleFor(p => p.AvailabilityTo, f => f.Date.Future())
                .RuleFor(p => p.Title, f => f.Lorem.Sentence(2))
                .RuleFor(p => p.Environment, f => f.Lorem.Sentence(5))
                .RuleFor(p => p.Services, (f, p) =>
                {
                    serviceFaker.RuleFor(s => s.PetsitterId, _ => p.Id);
                    var fakeServices = serviceFaker.GenerateBetween(1, 4);
                    FakeServices.AddRange(fakeServices);
                    
                    return null; // Petsitter.Services is a getter only. The return value has no impact.
                });
            var fakePetsitters = petsitterFaker.Generate(NumberOfFakeDataToGenerate);
            FakePetsitters.AddRange(fakePetsitters);

            
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