using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Bogus.Extensions;
using PetSupport.Core.Entities;
using PetSupport.Core.Enums;

namespace PetSupport.Infrastructure.Data.Seed
{
    public class FakeData
    {
        private const int NumberOfFakeDataToGenerate = 1000;

        public List<BasicUserInfo> FakeBasicUserInfo { get; }
        public List<AddressDetails> FakeAddressDetails { get; }
        public List<Animal> FakeAnimals { get; } 
        public List<BookingMessage> FakeBookingMessages { get; }
        public List<BasicPetsitterProfile> FakeBasicPetsitterProfile { get; }
        public List<User> FakeUsers { get; }
        public List<PetPreference> FakePetPreferences { get; set; }


        public int ids = 1;
        public FakeData()
        {

            // BasicUserInfo
            Randomizer.Seed = new Random(8675309);

            var basicUserInfo = new Faker<BasicUserInfo>()
                // .RuleFor(x => x.Id, x => ids++)
                .RuleFor(x => x.Id, x => ids++)
                .RuleFor(x => x.Name, x => x.Person.FirstName)
                .RuleFor(x => x.Surname, x => x.Person.LastName)
                .RuleFor(x => x.Email, x => x.Person.Email)
                .RuleFor(x => x.PhoneNumber, x => x.Person.Phone)
                .RuleFor(x => x.AvatarId, x => ids++.ToString())
                .RuleFor(x => x.PhotoGallery, x => Guid.NewGuid().ToString());

            FakeBasicUserInfo = basicUserInfo.Generate(NumberOfFakeDataToGenerate / 2);

            // AddressDetails

            var aIds = 1;

            var addressDetails = new Faker<AddressDetails>()
                .StrictMode(false)
                .RuleFor(x => x.Id, f => aIds++)
                .RuleFor(x => x.City, f => f.PickRandomParam("Radom", "Warsaw", "Gdynia"))
                .RuleFor(x => x.Street, x => x.Address.StreetName())
                .RuleFor(x => x.HouseNumber, x => x.Address.BuildingNumber())
                .RuleFor(x => x.FlatNumber, x => x.Address.BuildingNumber() + 20)
                .RuleFor(x => x.ZipCode, x => x.Address.ZipCode())
                .RuleFor(x => x.Country, x => x.Address.Country())
                .RuleFor(x => x.Latitude, (f, x) =>
                {
                    if (x.City == "Warsaw")
                    {
                        return x.Latitude = f.Address.Latitude(52.17, 52.27);
                    }

                    if (x.City == "Radom")
                    {
                        return x.Latitude = f.Address.Latitude(51.39, 51.41);
                    }

                    // Gdynia
                    return x.Latitude = f.Address.Latitude(54.47, 54.50);
                })
                .RuleFor(x => x.Longitude, (f, x) =>
                {
                    if (x.City == "Warsaw")
                    {
                        return x.Longitude = f.Address.Longitude(20.91, 21.19);
                    }

                    if (x.City == "Radom")
                    {
                        return x.Longitude = f.Address.Longitude(21.12, 21.19);
                    }

                    // Gdynia
                    return x.Longitude = f.Address.Longitude(18.52, 18.55);
                })
                .RuleFor(x => x.Range, x => 10);
            //
            FakeAddressDetails = addressDetails.Generate(NumberOfFakeDataToGenerate / 2);
            // Animals
            //
            var anIds = 1;
            var animals = new Faker<Animal>()
                // .RuleFor(a => a.Id, f => anIds++)
                .RuleFor(a => a.Id, f => anIds++)
                .RuleFor(x => x.Name, x => x.Person.UserName)
                .RuleFor(s => s.PetType, f => f.PickRandom<PetType>())
                .RuleFor(s => s.PetWeight, f => f.PickRandom<PetWeight>())
                .RuleFor(x => x.Age, x => x.Random.Number(1, 25))
                .RuleFor(p => p.Description, f => f.Lorem.Sentence(30))
                .RuleFor(p => p.PhotoGallery, f => f.Image.PicsumUrl());

            FakeAnimals = animals.Generate(NumberOfFakeDataToGenerate / 2);


            // PetPreference

            var pIds = 1;

            var petPreferences = new Faker<PetPreference>()
                .RuleFor(p => p.Id, f => pIds++)
                .RuleFor(p => p.PetType, f => f.PickRandom<PetType>())
                .RuleFor(p => p.PetWeights, f => f.PickRandom<PetWeight>());

            FakePetPreferences = petPreferences.Generate(NumberOfFakeDataToGenerate / 2);


            // BookingMessage
            var mIds = 1;
            var bookingMessage = new Faker<BookingMessage>()
                .RuleFor(m => m.Id, x => mIds++)
                .RuleFor(s => s.ServiceType, f => f.PickRandom<ServiceType>())
                .RuleFor(s => s.PetType, f => f.PickRandom<PetType>())
                .RuleFor(s => s.PetWeight, f => f.PickRandom<PetWeight>())
                .RuleFor(s => s.Message, f => f.Lorem.Sentence(10));

            FakeBookingMessages = bookingMessage.Generate(NumberOfFakeDataToGenerate / 2);


            // BasicPetsitterProfile
            var bpIds = 1;
            var basicPetsitterProfile = new Faker<BasicPetsitterProfile>()
                .RuleFor(x => x.Id, x => bpIds++)
                .RuleFor(x => x.DateOfBirth, x => x.Person.DateOfBirth)
                .RuleFor(s => s.ShortDescription, f => f.Lorem.Sentence(10))
                .RuleFor(s => s.Experience, f => f.Lorem.Sentence(5))
                .RuleFor(s => s.Availability, f => f.Lorem.Sentence(3))
                .RuleFor(s => s.Environment, f => f.Lorem.Sentence(5));

            FakeBasicPetsitterProfile = basicPetsitterProfile.Generate(NumberOfFakeDataToGenerate / 2);

            // User
            var uIds = 1;
            var aaaIds = 1;
            var userFakeData = new Faker<User>()
                // .StrictMode(false)
                .RuleFor(u => u.Id, f => uIds++)
                .RuleFor(u => u.AzureId, f => Guid.NewGuid().ToString())
                .RuleFor(u => u.BasicUserInfoId, f => f.PickRandom(FakeBasicUserInfo).Id)
                .RuleFor(u => u.AddressDetailsId, f => f.PickRandom(FakeAddressDetails).Id)

                // .RuleFor(u => u.Animals, (f, a) =>
                // {
                //     animals.RuleFor(a => a.Id, _ => aaaIds++);
                //     var fakeAnimals = animals // TU     JEST     ZLE
                //     FakeAnimals.AddRange(fakeAnimals);
                //     return null;
                // })
                // .RuleFor(u => u.BookingMessages, u =>
                // {
                //     var counter = u.Random.Number(1, 18);
                //     List<BookingMessage> temporaryListOfBookingMessages = bookingMessage.Generate(counter);
                //     return temporaryListOfBookingMessages;
                // })
                .RuleFor(u => u.WantsToBePetsitter, f => false)
                .RuleFor(u => u.IsProfileCompleted, f => false)
                .RuleFor(u => u.BasicPetsitterProfileId, f => f.PickRandom(FakeBasicPetsitterProfile).Id);

            FakeUsers = userFakeData.Generate(NumberOfFakeDataToGenerate / 2);
        }
    }
}