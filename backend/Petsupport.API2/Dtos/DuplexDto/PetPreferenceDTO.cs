using PetSupport.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petsupport.API2.Dtos.DuplexDto
{
    public class PetPreferenceDTO
    {
        public int PetPreferenceId { get; set; }
        public PetType PetType { get; set; }
        public PetWeight PetWeights { get; set; }
    }
}
