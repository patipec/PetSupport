using PetSupport.Core.Enums;

namespace PetSupport.Core.Entities
{
    public class PetDescription: BaseEntity
    {
        public PetType PetType { get; set; }
        
        public PetWeight PetWeight { get; set; }
        
        public string Description { get; set; }
        
        public Sex Sex { get; set; }
        
        #nullable enable
        public string? Breed { get; set; }
        
        //PHOTO
        
}