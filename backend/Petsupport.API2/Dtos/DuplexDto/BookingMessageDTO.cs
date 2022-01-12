using PetSupport.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petsupport.API2.Dtos.DuplexDto
{
    public class BookingMessageDTO
    {
        public ServiceType ServiceType;
        public PetType PetType { get; set; }
        public PetWeight PetWeight { get; set; }
        public DateTime SentDate { get; private set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Message { get; set; }
    }
}
