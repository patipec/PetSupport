#nullable enable
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualBasic;

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

        public DateAndTime AvailabilityFrom { get; set; }

        public DateAndTime AvailabilityTo { get; set; }

        public string Title { get; set; }

        public string Environment { get; set; }


        public List<PetsitterService> Services { get; set; }
    }
}