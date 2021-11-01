using PetSupport.Domain.Enums;

namespace PetSupport.Domain.Entities
{
    public class PetService
    {
        public int Id { get; set; }

        public double Price { get; set; }
        
        public ServiceType Name { get; set; }


        public int PetsitterProfileId { get; set; }

        public PetsitterProfile PetsitterProfile { get; set; }
    }

}