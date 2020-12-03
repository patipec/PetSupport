using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace PetSupport.Data.Entities
{
    class BookingMessage: BaseEntity
    {
        public int PetsitterId { get; set; }
        public int ClientId { get; set; }
        public string Text { get; set; }

    }
    
}
