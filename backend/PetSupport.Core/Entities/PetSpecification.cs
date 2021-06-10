using System.Collections.Generic;
using PetSupport.Core.Enums;

namespace PetSupport.Core.Entities
{
    public class PetSpecification: BaseEntity
    {
        public PetType PetType { get; set; }
        public ICollection<PetWeight> PetWeights { get; set; }
    }
}