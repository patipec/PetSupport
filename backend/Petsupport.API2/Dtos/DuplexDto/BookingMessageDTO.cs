using PetSupport.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petsupport.API2.Dtos.DuplexDto
{
    public class BookingMessageDTO
    {

        public int BookingMessageId { get; set; }

        public int ServiceType;
        public int PetType { get; set; }
        public int PetWeight { get; set; }
        public DateTime SentDate { get; private set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Message { get; set; }

        public ICollection<UserDTO> Users { get; set; }
        public int UserId2 { get; set; }
        public int UserId { get; set; }
    }
}
