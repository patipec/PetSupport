using System.Collections.Generic;
using PetSupport.API2.Dtos.OutDtos;
using PetSupport.Core.Entities;

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