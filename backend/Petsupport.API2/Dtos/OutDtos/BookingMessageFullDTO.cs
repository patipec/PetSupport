using System;
using PetSupport.Core.Entities;

namespace PetSupport.API2.Dtos.OutDtos
{
    public class BookingMessageFullDTO : BaseEntity
    {
        public DateTime SendDate { get; set; }
        public string Message { get; set; }
        public ClientDTO Client { get; set; } }
}