using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PetSupport.Core.Enums;

namespace PetSupport.Core.Entities

{
    //TODO: Logic  BookingMessage to improve.
    public class BookingMessage
    {
        public BookingMessage()
        {
            SentDate = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        public ServiceType ServiceType;
        public PetType PetType { get; set; }
        public PetWeight PetWeight { get; set; }
        public DateTime SentDate { get; private set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Message { get; set; }



        //Relations
        public List<User> Users { get; set; }
        
    }
}