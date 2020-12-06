using PetSupport.Data.Entities;

namespace PetSupport.API.Dtos.OutDtos
{
    public class CreateBookingMessageDTO : BaseEntity
    {
        public int ClientId { get; set; }
        public int PetsitterId { get; set; }
        public string Message { get; set; }
    }
}