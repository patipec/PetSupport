using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetSupport.Core.Entities
{
    public class AddressDetails
    {
        [Key]
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

       
   
        
    }
}