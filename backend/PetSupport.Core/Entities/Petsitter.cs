#nullable enable
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PetSupport.Core.Entities
{
    public class Petsitter : User
    {
        

        public string Description { get; set; }


        public string Password { get; set; }
        
        public string PhotoId { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string ParcelAndHouseNumbers { get; set; }

        public string ZipCode { get; set; }

        public double Rate { get; set; }


        public List<PetsitterService> Services { get; set; }
    }
}