using System.Collections.Generic;

namespace PetSupport.Domain.Entities
{
    public class PetSupportUser
    {
        public int Id { get; set; }
        
        public string AzureId { get; set; }
                
        public BasicUserInfo BasicUserInfo { get; set; }
        
        public AddressDetail AddressDetail { get; set; }

        public ICollection<Animal> Animals { get; set; }

        public ICollection<BookingMessage>BookingMessages { get; set; }
        
        public bool WantsToBePetsitter { get; set; }
        
        public bool IsProfileCompleted { get; set; }
        
        //Only when WantsToBePetsitter = true;
        public PetsitterProfile PetsitterProfile { get; set; }
        
    }
}