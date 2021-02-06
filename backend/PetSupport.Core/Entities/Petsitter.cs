#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace PetSupport.Core.Entities
{
    public class Petsitter 
    {
        
        public string PhotoId { get; set; }
        public double Rate { get; set; }
        public ICollection<Service> Services { get; set; }
       }

    public class BasicInfo : User
    {
        public string Description { get; set; }
    }

    public class Address : Petsitter
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string ParcelAndHouseNumbers { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public ICollection<Coordinates> Coordinates { get; set; }

    }

    public class PersonalInfo : Petsitter
    {
        public DateTime AvailabilityFrom { get; set; }
        public DateTime AvailabilityTo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Title { get; set; }
        public string Environment { get; set; }
        public string Experience { get; set; }

    }


    public class Coordinates : BaseEntity
    { 
        public double Lattiude { get; set; }
        public double Longtitude { get; set; }
        public int PetsitterId { get; set; }
        

        
        
    }
}