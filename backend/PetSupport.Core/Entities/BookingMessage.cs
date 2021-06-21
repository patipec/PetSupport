using System;
using PetSupport.Core.Enums;

namespace PetSupport.Core.Entities

{
    //TODO: Logic  BookingMessage to improve.
    public class BookingMessage : BaseEntity
    {
        public BookingMessage()
        {
            SentData = DateTime.Now;
        }
        
        public ServiceType ServiceType;
        public PetType PetType { get; set; }
        public PetWeight   PetWeight { get; set; }
        
        public DateTime SentData { get; private set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Message { get; set; }

        //Relationships

        public int? UserId { get; set; }
        public User User { get; set; }
    }
}