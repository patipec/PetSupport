using PetSupport.Core.Enums;

namespace PetSupport.Core.Entities
{
    public class Animal : BaseEntity
    {
        public string Name { get; set; }
        public PetType PetType { get; set; }
        public PetWeight PetWeight { get; set; }
        public int? Age { get; set; }
        public string Description { get; set; }
        public string PhotoGallery { get; set; }
        
        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}