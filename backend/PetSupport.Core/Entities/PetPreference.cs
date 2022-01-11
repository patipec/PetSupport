using System.Collections.Generic;
using PetSupport.Core.Enums;

namespace PetSupport.Core.Entities
{
    public class PetPreference : BaseEntity
    {
        public PetType PetType { get; set; }
        public PetWeight PetWeights { get; set; }

        //relations        
        public virtual BasicPetsitterProfile BasicPetsitterProfile {get; set;}
        public int BasicPetsitterProfileId { get; set; }
    }
}