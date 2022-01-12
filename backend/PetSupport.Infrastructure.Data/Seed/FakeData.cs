using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Bogus;
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
        public List<BasicPetsitterProfileId> FakeBasicPetsitterProfile { get; }
        public List<User> FakeUsers { get; }
        public List<PetPreference> FakePetPreferences { get; set; }
        public List<PetService> FakePetServices {  get; }


        public FakeData()
        {

            // BasicUserInfo
            Randomizer.Seed = new Random(8675309);
            var lorem = new Bogus.DataSets.Lorem(locale: "pl");

            var basicUserInfIds = 1;
            var basicUserInfo = new Faker<BasicUserInfo>()
                .RuleFor(x => x.Id, x => basicUserInfIds++)
                .RuleFor(x => x.Name, x => x.Person.FirstName)
                .RuleFor(x => x.Surname, x => x.Person.LastName)
                .RuleFor(x => x.Email, x => x.Person.Email)
                .RuleFor(x => x.PhoneNumber, x => x.Person.Phone)
                .RuleFor(x => x.AvatarId, x => basicUserInfIds++.ToString())
                .RuleFor(x => x.PhotoGallery, x => Guid.NewGuid().ToString());

            FakeBasicUserInfo = basicUserInfo.Generate(NumberOfFakeDataToGenerate / 2);


            // AddressDetails
            var addressDetailIds = 1;
            var addressDetails = new Faker<AddressDetails>()
                .StrictMode(false)
                .RuleFor(x => x.Id, f => addressDetailIds++)
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
            
            FakeAddressDetails = addressDetails.Generate(NumberOfFakeDataToGenerate / 2);

            // BasicPetsitterProfile
            var bpIds = 1;
            var basicPetsitterProfile = new Faker<BasicPetsitterProfileId>()
                .RuleFor(x => x.Id, x => bpIds++)
                .RuleFor(x => x.DateOfBirth, x => x.Person.DateOfBirth)
                .RuleFor(s => s.ShortDescription, f => f.Lorem.Sentence(10))
                .RuleFor(s => s.Experience, f => lorem.Sentence(5))
                .RuleFor(s => s.Availability, f => lorem.Sentence(3))
                .RuleFor(s => s.Environment, f => lorem.Sentence(5));

            FakeBasicPetsitterProfile = basicPetsitterProfile.Generate(NumberOfFakeDataToGenerate / 2);


            // PetPreference
            var pIds = 1;
            var petPreferences = new Faker<PetPreference>()
                .RuleFor(p => p.Id, f => pIds++)
                .RuleFor(p => p.PetType, f => f.PickRandom<PetType>())
                .RuleFor(p => p.PetWeights, f => f.PickRandom<PetWeight>())
                .RuleFor(u => u.BasicPetsitterProfileId, f => f.PickRandom(FakeBasicPetsitterProfile).Id);

            FakePetPreferences = petPreferences.Generate(NumberOfFakeDataToGenerate / 2);

            var psIds = 1;
            var petServices = new Faker<PetService>()
                .RuleFor(x => x.Id, x => psIds++)
                .RuleFor(x => x.Price, x => x.Random.Number(1, 100))
                .RuleFor(u => u.ServiceType, f => f.PickRandom<ServiceType>())
                .RuleFor(u => u.BasicPetsitterProfileId, f => f.PickRandom(FakeBasicPetsitterProfile).Id);

            FakePetServices = petServices.Generate(NumberOfFakeDataToGenerate / 2);

            // User
            var userIds = 1;
            var userFakeData = new Faker<User>()
                // .StrictMode(false)
                .RuleFor(u => u.Id, f => userIds++)
                .RuleFor(u => u.AzureId, f => Guid.NewGuid().ToString())
                .RuleFor(u => u.WantsToBePetsitter, f => false)
                .RuleFor(u => u.BasicUserInfoId, f => f.PickRandom(FakeBasicUserInfo).Id)
                .RuleFor(u => u.AddressDetailsId, f => f.PickRandom(FakeAddressDetails).Id)
                .RuleFor(u => u.BasicPetsitterProfileId, f => f.PickRandom(FakeBasicPetsitterProfile).Id)
                .RuleFor(u => u.IsProfileCompleted, f => true);
                
            FakeUsers = userFakeData.Generate(NumberOfFakeDataToGenerate / 2);


            // BookingMessage
            var startDate = new DateTime(2022, 1, 5);
            var endDate = new DateTime(2022, 1, 10);
            var mIds = 1;
            var bookingMessage = new Faker<BookingMessage>()
                .RuleFor(m => m.Id, x => mIds++)
                .RuleFor(s => s.ServiceType, f => f.PickRandom<ServiceType>())
                .RuleFor(s => s.DateFrom, f => f.Date.Between(startDate, endDate))
                .RuleFor(s => s.DateTo, f => f.Date.Between(new DateTime(2022, 1, 10), new DateTime(2022, 1, 15)))
                .RuleFor(s => s.PetType, f => f.PickRandom<PetType>())
                .RuleFor(s => s.PetWeight, f => f.PickRandom<PetWeight>())
                .RuleFor(s => s.Message, f => lorem.Sentence(10))
                .RuleFor(u => u.UserId, f => f.PickRandom(FakeUsers).Id);

            FakeBookingMessages = bookingMessage.Generate(NumberOfFakeDataToGenerate / 2);

            // Animals
            var animalsIds = 1;
            var animals = new Faker<Animal>()
                .RuleFor(a => a.Id, f => animalsIds++)
                .RuleFor(x => x.Name, x => x.Person.UserName)
                .RuleFor(s => s.PetType, f => f.PickRandom<PetType>())
                .RuleFor(s => s.PetWeight, f => f.PickRandom<PetWeight>())
                .RuleFor(x => x.Age, x => x.Random.Number(1, 25))
                .RuleFor(p => p.Description, f => lorem.Sentence(30))
                .RuleFor(p => p.PhotoGallery, f => f.Image.PicsumUrl())
                .RuleFor(u => u.UserId, f => f.PickRandom(FakeUsers).Id);

            FakeAnimals = animals.Generate(NumberOfFakeDataToGenerate / 2);
        }
    }
}