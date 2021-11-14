using PetSupport.Domain.Enums;

namespace PetSupport.Domain.Entities
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PetType PetType { get; set; }
        public PetWeight PetWeight { get; set; }
        public int? Age { get; set; }
        public string Description { get; set; }
        public string PhotoGallery { get; set; }
        public int PetSupportUserId { get; set; }
        public PetSupportUser PetSupportUser { get; set; }
    }
}