using Petsupport.API2.Dtos.OutDtos;
using System.Collections.Generic;

namespace Petsupport.API2.Dtos.InDtos
{
    public class FullPetsitterDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageId { get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Description { get; set; }

        public ICollection<PetSitterServiceDTO> Services { get; set; }
    }
}