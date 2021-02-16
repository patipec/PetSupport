using System.Collections.Generic;

namespace PetSupport.Core.Entities
{
    public class Client : User
    {
        public ICollection<BookingMessage> BookingMessages { get; set; }
    }
}