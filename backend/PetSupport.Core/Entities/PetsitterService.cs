using System;
using System.Collections.Generic;
using System.Text;
using PetSupport.Data.Entities;

namespace PetSupport.Core.Entities
{
    class PetsitterService: BaseEntity
    {
        public int PetsitterId  { get; set; }
        public int ServiceId { get; set; }
        public decimal Price { get; set; }
    }
}
