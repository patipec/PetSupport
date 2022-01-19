using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetSupport.Core.Entities
{
    public class BasicUserInfo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AvatarId { get; set; }
        public string PhotoGallery { get; set; }

        
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}