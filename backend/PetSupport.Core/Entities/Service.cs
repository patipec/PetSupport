using PetSupport.Core.Enums;
using PetSupport.Core.Entities;

namespace PetSupport.Core.Entities
{
    public class Service: BaseEntity
    {
        public string ImageId { get; set; }
        public ServiceType Name { get; set; }
        public string Description { get; set; }
        public Unit Unit { get; set; }
        public double Price { get; set; }
    }
    
}
