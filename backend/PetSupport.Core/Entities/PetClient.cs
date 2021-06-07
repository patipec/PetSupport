using System.Collections;
using System.Collections.Generic;
using Bogus.DataSets;

namespace PetSupport.Core.Entities
{
    public class PetClient: BaseEntity
    {
        public ICollection<PetClientAnimal> PetClientAnimals { get; set; }
        
    }
}