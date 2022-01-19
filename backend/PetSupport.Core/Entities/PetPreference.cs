using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetSupport.Core.Enums;

namespace PetSupport.Core.Entities
{
    public class PetPreference
    {
        [Key]
        public int Id { get; set; }
        public PetType PetType { get; set; }
        public PetWeight PetWeights { get; set; } 

        
        public int BasicPetsitterProfileId { get; set; }

        
        public BasicPetsitterProfile BasicPetsitterProfile { get; set; }
    }
}