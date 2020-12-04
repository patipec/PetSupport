using PetSupport.Data.Entities;

namespace PetSupport.API.Dtos.OutDtos
{
    public class UpdatePetsitterDTO : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageId { get; set; }
        public string Description { get; set; }
        
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
    }
}