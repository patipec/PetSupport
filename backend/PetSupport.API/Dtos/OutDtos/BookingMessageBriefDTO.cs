using System;
using PetSupport.Data.Entities;

namespace PetSupport.API.Dtos.OutDtos
{
    public class BookingMessageBriefDTO : BaseEntity
    {
        public DateTime SendDate { get; set; }
        public int ClientId { get; set; }
        public int PetsitterId { get; set; }
    }
}