using System;
using System.Collections.Generic;
using System.Text;
using PetSupport.Core.Entities;

namespace PetSupport.Core.Entities
{
    public class PetsitterService: BaseEntity
    {
        public int PetsitterId  { get; set; }
        public int ServiceId { get; set; }
        public double Price { get; set; }

        //Relationships
        public Petsitter Petsitter { get; set; }
        public Service Service { get; set; }

    }
}
