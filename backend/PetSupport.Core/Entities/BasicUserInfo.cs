namespace PetSupport.Core.Entities
{
    public class BasicUserInfo : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AvatarId { get; set; }
        public string PhotoGallery { get; set; }
        
    }
}