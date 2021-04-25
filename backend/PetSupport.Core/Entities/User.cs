﻿using System;
using System.Collections.Generic;

namespace PetSupport.Core.Entities
{
    public class User : BaseEntity
    {
        //General user properties
        public string AzureId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }    
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
        public bool IsPettsitter { get; set; }
        
        // PetSitter 
        public class Petsitter : User
        {
            public string Description { get; set; }
            public string PhotoId { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public string ParcelAndHouseNumbers { get; set; }
            public string ZipCode { get; set; }
            public string Country { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Title { get; set; }

            public double Rate { get; set; }
            public DateTime AvailabilityFrom { get; set; }
            public DateTime AvailabilityTo { get; set; }

            public string Environment { get; set; }
            public string Experience { get; set; }

            public ICollection<Coordinate> Coordinates { get; set; }
            public ICollection<Service> Services { get; set; }
        }

        public class Client : User
        {
            
        }


        public class Coordinate : BaseEntity
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public int PetsitterId { get; set; }

        }
        
    }
}