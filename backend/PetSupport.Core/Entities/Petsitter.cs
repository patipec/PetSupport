#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace PetSupport.Core.Entities
{
    public class Petsitter : User
    {
        
        public string Description { get; set; }
        
        public string PhotoId { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string ParcelAndHouseNumbers { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }
        
        public double Rate { get; set; }

        public DateTime AvailabilityFrom { get; set; }

        public DateTime AvailabilityTo { get; set; }

        public string Title { get; set; }

        public string Environment { get; set; }

        public ICollection<Coordinate> Coordinates { get; set; } 
        
        public ICollection<Service> Services { get; set; }
    }

    public class Coordinate : BaseEntity
    { 
        public double Lattiude { get; set; }
        public double Longtitude { get; set; }
        public int PetsitterId { get; set; }
        
    }
}