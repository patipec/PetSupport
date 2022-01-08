using System;
using System.Collections;
using System.Collections.Generic;

namespace PetSupport.Core.Entities
{
    public class BasicPetsitterProfile : BaseEntity
    {
        public DateTime DateOfBirth { get; set; }
        public string ShortDescription { get; set; }
        public string Experience { get; set; }
        public string Availability { get; set; }
        public string Environment { get; set; }

        public virtual ICollection<PetPreference> PetsitterPetPreferences { get; set; }
        public virtual ICollection<PetService> PetServices { get; set; }
        
        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}