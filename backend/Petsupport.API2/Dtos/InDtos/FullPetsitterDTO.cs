using System.Collections.Generic;
using PetSupport.Data.Entities;

namespace PetSupport.API.Dtos.OutDtos
{
    public class FullPetsitterDTO: BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageId { get; set; }
        
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Description { get; set; }
        
        public ICollection<ServiceDTO> Services { get; set; }
    }
}