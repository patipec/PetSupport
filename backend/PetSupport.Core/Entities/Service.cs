using PetSupport.Core.Enums;

namespace PetSupport.Core.Entities
{
    public class Service : BaseEntity
    {
        public double Price { get; set; }
        public ServiceType Name { get; set; }
        public Unit Unit { get; set; }
        
        public PetType PetType { get; set; }
        public PetWeight PetWeight { get; set; }
        public int PetsitterId { get; set; }
        public Petsitter Petsitter { get; set; }
    }
}