using PetSupport.Core.Enums;

namespace PetSupport.Core.Entities
{
    public class PetService : BaseEntity
    {
        public double Price { get; set; }
        public ServiceType Name { get; set; }
    }

}