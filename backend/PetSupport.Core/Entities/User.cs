using System.Collections.Generic;

#nullable enable
namespace PetSupport.Core.Entities
{
    public class User : BaseEntity
    {
        public string AzureId { get; set; }
        
        public BasicUserInfo BasicUserInfo { get; set; }
        
        public AddressDetail AddressDetail { get; set; }
        
        public bool WantsToBePetsitter { get; set; }
        
        public bool IsProfileCompleted { get; set; }

        public Petsitter Petsitter { get; set; }
        public PetClient PetClient { get; set; }
        
        public ICollection<BookingMessage>BookingMessages { get; set; }
        
    }
}