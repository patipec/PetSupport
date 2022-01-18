using Petsupport.API2.Dtos.DuplexDto;
using PetSupport.Core.Entities;

namespace Petsupport.API2.Dtos.InDtos
{
    public class PetsitterListDTO
    {
        
        public string Name { get; set; }
        public int Price { get; set; }
        public string AvatarId { get; set; }
        public string City { get; set; }
        public string ShortDescription { get; set; }

        
    }
}