using System;

namespace PetSupport.Core.Entities

{
    public class BookingMessage : BaseEntity
    {
        public int PetsitterId { get; set; }
        public int ClientId { get; set; }
        public string Text { get; set; }
        public DateTime SentDate { get; set; }

        //Relationships
        public Petsitter Petsitter { get; set; }
        public Client Client { get; set; }
    }
}