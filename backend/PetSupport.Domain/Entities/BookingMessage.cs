using System;
using PetSupport.Domain.Enums;

namespace PetSupport.Domain.Entities

{
    //TODO: Logic  BookingMessage to improve.
    public class BookingMessage
    {
        public int Id { get; set; }

        public BookingMessage()
        {
            SentData = DateTime.Now;
        }

        public ServiceType ServiceType;

        public PetType PetType { get; set; }

        public PetWeight PetWeight { get; set; }

        public DateTime SentData { get; private set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public string Message { get; set; }

        //Relationships

        public int? PetSupportUserId { get; set; }

        public PetSupportUser PetSupportUser { get; set; }
    }
}