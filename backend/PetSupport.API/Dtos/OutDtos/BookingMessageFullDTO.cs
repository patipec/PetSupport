using System;
using PetSupport.Data.Entities;

namespace PetSupport.API.Dtos.OutDtos
{
    public class BookingMessageFullDTO : BaseEntity
    {
        public int Id { get; set; }
        public DateTime SendDate { get; set; }
        public string Message { get; set; }
        public ClientDTO Client { get; set; } }
}