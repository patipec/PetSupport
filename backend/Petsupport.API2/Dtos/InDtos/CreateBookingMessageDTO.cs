using PetSupport.Core.Entities;

namespace Petsupport.API2.Dtos.InDtos
{
    public class CreateBookingMessageDTO
    {
        public int ClientId { get; set; }
        public int PetsitterId { get; set; }
        public string Message { get; set; }
    }
}