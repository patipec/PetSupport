using System;
using System.Collections.Generic;

namespace PetSupport.Domain.Entities
{
    public class PetsitterProfile
    {
        public int PetsitterProfileId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string ShortDescription { get; set; }

        public string Experience { get; set; }

        public string Availability { get; set; }

        public string Environment { get; set; }

        public ICollection<PetSpecification> PetsitterPetPreferences { get; set; }

        public ICollection<PetService> PetServices { get; set; }
    }
}