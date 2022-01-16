using PetSupport.Core.Enums;

namespace PetSupport.Core.Entities
{
    public class PetService : BaseEntity
    {
        //TODO  setting price should be not only service type and price for it. Petpreference should be there as well
        public double Price { get; set; }
        public ServiceType ServiceType { get; set; }

        public BasicPetsitterProfile BasicPetsitterProfile { get; set; }
        public int BasicPetsitterProfileId { get; set; }
    }
}