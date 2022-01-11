using System;
using PetSupport.Core.Enums;

namespace PetSupport.Core.Entities

{
    //TODO: Logic  BookingMessage to improve.
    public class BookingMessage : BaseEntity
    {
        public BookingMessage()
        {
            SentDate = DateTime.Now;
        }
    
        public ServiceType ServiceType;
        public PetType PetType { get; set; }
        public PetWeight PetWeight { get; set; }
        public DateTime SentDate { get; private set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Message { get; set; }

        //Relations
        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}