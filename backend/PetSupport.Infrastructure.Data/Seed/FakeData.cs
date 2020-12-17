using System;
using System.Collections.Generic;
using Bogus;
using PetSupport.Core.Entities;
using PetSupport.Core.Enums;

namespace PetSupport.Infrastructure.Data.Seed
{
    public class FakeData
    {
        private const int NumberOfFakeDataToGenerate = 30;
        public List<Client> FakeClients { get; }
        public List<Petsitter> FakePetsitters { get; }
        public List<Service> FakeServices { get; }
        public List<PetsitterService> FakePetsitterServices { get; }
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
                .RuleFor(c => c.PhoneNumber, f => f.Person.Phone);
            FakeClients = clientFaker.Generate(NumberOfFakeDataToGenerate);


            var serviceId = 1;
            var serviceFaker = new Faker<Service>()
                .RuleFor(s => s.Id, f => serviceId++)

                //TODO: Add/verify icons for services.
                .RuleFor(s => s.ImageId, f => f.Image.LoremFlickrUrl())
                .RuleFor(s => s.Name, f => f.PickRandom<ServiceType>())
                .RuleFor(s => s.Description, f => f.Lorem.Sentence(5))
                .RuleFor(s => s.Unit, f => f.PickRandom<Unit>());
            FakeServices = serviceFaker.Generate(NumberOfFakeDataToGenerate);
            
            
            // Petsitter and Client entity inherit for user class so they have the same column with Id on the data table.
            var petsitterId = clientId;
            var petsitterFaker = new Faker<Petsitter>()
                .RuleFor(p => p.Id, f => petsitterId++)
                .RuleFor(p => p.Name, f => f.Person.FirstName)
                .RuleFor(p => p.Surname, f => f.Person.LastName)
                .RuleFor(p => p.Email, (f, u) => f.Internet.Email(u.Name, u.Surname))
                .RuleFor(p => p.PhoneNumber, f => f.Person.Phone)
                .RuleFor(p => p.Description, f => f.Lorem.Sentence(30))

                //TODO: Verify field Password in PetSupport.Core/Entities/Petsitter.cs entity. It is correct ? 
                .RuleFor(p => p.Password, f => Guid.NewGuid().ToString())
                .RuleFor(p => p.PhotoId, f => f.Image.PicsumUrl())
                .RuleFor(p => p.City, f => f.Address.City());
                //.RuleFor(p => p.Services, f => petsitterserviceFaker.Generate(3));
            FakePetsitters = petsitterFaker.Generate(NumberOfFakeDataToGenerate);

            
            var petsitterserviceId = 1;
            var petsitterserviceFaker = new Faker<PetsitterService>()
                .RuleFor(p => p.Id, f => petsitterserviceId++)
                .RuleFor(p => p.PetsitterId, f => f.PickRandom(FakePetsitters).Id)
                .RuleFor(p => p.ServiceId, f => f.PickRandom(FakeServices).Id)
                .RuleFor(p => p.Price, f => double.Parse(f.Commerce.Price()));
            FakePetsitterServices = petsitterserviceFaker.Generate(NumberOfFakeDataToGenerate * 3);
            
            
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