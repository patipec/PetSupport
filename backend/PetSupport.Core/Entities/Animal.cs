using PetSupport.Core.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetSupport.Core.Entities
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public PetType PetType { get; set; }
        public PetWeight PetWeight { get; set; }
        public int? Age { get; set; }
        public string Description { get; set; }
        public string PhotoGallery { get; set; }

        
        public int UserId { get; set; }

        
        public User User { get; set; }

    }
}