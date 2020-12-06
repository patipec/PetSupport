using System;
using PetSupport.Core.Entities;


namespace Petsupport.API2.Dtos.OutDtos
{
    public class BookingMessageFullDTO : BaseEntity
    {
        public DateTime SendDate { get; set; }
        public string Message { get; set; }
        public Client Client { get; set; }

    }
}