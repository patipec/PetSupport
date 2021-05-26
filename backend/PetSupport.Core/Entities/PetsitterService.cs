using PetSupport.Core.Enums;

namespace PetSupport.Core.Entities
{
    public class PetsitterService : BaseEntity
    {
        public double Price { get; set; }
        public ServiceType Name { get; set; }
        public TimeUnit Unit { get; set; }
        
        public PetType PetType { get; set; }
        public PetWeight PetWeight { get; set; }
        
        public int PetsitterId { get; set; }
        public Petsitter Petsitter { get; set; }

    }

}