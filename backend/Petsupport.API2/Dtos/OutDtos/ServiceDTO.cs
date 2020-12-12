using PetSupport.Core.Entities;
using PetSupport.Core.Enums;

namespace PetSupport.API2.Dtos.OutDtos
{
    public class ServiceDTO : BaseEntity
    {
        public string ImageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Unit Unit { get; set; }
        public decimal Price { get; set; }
    }
}