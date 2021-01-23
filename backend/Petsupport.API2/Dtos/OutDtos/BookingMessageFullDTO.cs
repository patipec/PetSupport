using System;

namespace Petsupport.API2.Dtos.OutDtos
{
    public class BookingMessageFullDTO
    {
        public DateTime SendDate { get; set; }
        public string Message { get; set; }
        public ClientDTO Client { get; set; }
    }
}