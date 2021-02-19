using System;

namespace Petsupport.API2.Dtos.OutDtos
{
    public class BookingMessageBriefDTO
    {
        public int Id { get; set; }
        public string SendDate { get; set; }
        public int ClientId { get; set; }
        public int PetsitterId { get; set; }
    }
}