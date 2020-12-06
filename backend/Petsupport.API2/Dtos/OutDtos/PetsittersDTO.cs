using PetSupport.Data.Entities;

namespace PetSupport.API.Dtos.OutDtos
{
    public class PetsittersDTO : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageId { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}