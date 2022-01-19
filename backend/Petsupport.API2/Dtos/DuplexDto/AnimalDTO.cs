using PetSupport.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petsupport.API2.Dtos.DuplexDto
{
    public class AnimalDTO
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public PetType PetType { get; set; }
        public PetWeight PetWeight { get; set; }
        public int? Age { get; set; }
        public string Description { get; set; }
        public string PhotoGallery { get; set; }
        public int UserId { get; set; }
    }
}
