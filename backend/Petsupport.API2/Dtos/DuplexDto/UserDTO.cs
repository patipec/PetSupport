using PetSupport.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petsupport.API2.Dtos.DuplexDto
{
    public class UserDTO
    {
        public string AzureId { get; set; }

        public int BasicUserInfoId { get; set; }
        public BasicUserInfoDTO BasicUserInfoDTO { get; set; }

        public int AddressDetailsId { get; set; }
        public AddressDetailsDTO AddressDetailsDTO { get;set;}


        public int BasicPetsitterProfileId { get; set; }
        public BasicPetsitterProfileDTO BasicPetsitterProfileDTO { get; set; }


        public IEnumerable<AnimalDTO> Animals { get; set; }
        public IEnumerable<BookingMessageDTO> BookingMessages { get; set; }

        public bool WantsToBePetsitter { get; set; }
        public bool IsProfileCompleted { get; set; }
    }
}
