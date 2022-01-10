using PetSupport.Core.Enums;

namespace PetSupport.Core.Entities
{
    public class PetService : BaseEntity
    {
        public double Price { get; set; }
        public ServiceType ServiceType { get; set; }

        public int BasicPetsitterProfileId { get; set; }
    }
}