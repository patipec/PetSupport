using PetSupport.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petsupport.API2.Dtos.DuplexDto
{
    public class BasicPetsitterProfileDTO
    {
        public int BasicPetsitterProfileId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ShortDescription { get; set; }
        public string Experience { get; set; }
        public string Availability { get; set; }
        public string Environment { get; set; }
        public IEnumerable<PetPreferenceDTO> PetsitterPetPreferences { get; set; }
        public IEnumerable<PetServiceDTO> PetServices { get; set; }

        
    }
}
