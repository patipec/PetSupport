using System.Collections;
using System.Collections.Generic;

namespace PetSupport.Core.Entities
{
    public class User : BaseEntity
    {
        public string AzureId { get; set; }

        public BasicUserInfo BasicUserInfo { get; set; }

        public AddressDetails AddressDetails { get; set; }

        public ICollection<Animal> Animals { get; set; }

        public ICollection<BookingMessage> BookingMessages { get; set; }

        //Petsitter
        public bool WantsToBePetsitter { get; set; }
        public bool IsProfileCompleted { get; set; }

        public BasicPetsitterProfile BasicPetsitterProfile { get; set; }
    }
}