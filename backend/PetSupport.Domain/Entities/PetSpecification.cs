using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using PetSupport.Domain.Enums;

namespace PetSupport.Domain.Entities
{
    public class PetSpecification

    {
        public int Id { get; set; }

        public PetType PetType { get; set; }

        public ICollection<PetWeight> PetWeights { get; set; }

        public int PetsitterProfileId { get; set; }
        
        public PetsitterProfile PetsitterProfile { get; set; }
    }
}