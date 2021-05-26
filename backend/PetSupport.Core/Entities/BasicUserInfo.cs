namespace PetSupport.Core.Entities
{
    public class BasicUserInfo
    {
        public string Name { get; set; }
        
        public string Surname { get; set; }
        
        string Email { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public bool WantsToBePetsitter { get; set; }

        public bool IsProfileCompleted { get; set; }

        public string AvatarId { get; set; }

        public string? PhotoGallery { get; set; }
    }
}