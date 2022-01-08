using System.Collections;
using System.Collections.Generic;

namespace PetSupport.Core.Entities
{
    public class User : BaseEntity
    {
        public string AzureId { get; set; }
        public virtual BasicUserInfo BasicUserInfo { get; set; }
        public virtual AddressDetails AddressDetails { get; set; }

        //relations
        public virtual ICollection<Animal> Animals { get; set; }
        public virtual ICollection<BookingMessage> BookingMessages { get; set; }

        //Petsitter
        public bool WantsToBePetsitter { get; set; }
        public bool IsProfileCompleted { get; set; }
        public virtual BasicPetsitterProfile BasicPetsitterProfile { get; set; }
    }
}