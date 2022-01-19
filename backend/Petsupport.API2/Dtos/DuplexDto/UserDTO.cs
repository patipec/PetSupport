using PetSupport.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Petsupport.API2.Dtos.DuplexDto
{
    public class UserDTO
    {
       
        public int UserId { get; set; }
        public string AzureId { get; set; }
        public BasicUserInfoDTO BasicUserInfo { get; set; }
        public AddressDetailsDTO AddressDetails { get; set; } 
        public BasicPetsitterProfileDTO BasicPetsitterProfile { get; set; }
        public IEnumerable<AnimalDTO> Animals { get; set; }
        public IEnumerable<BookingMessageDTO> BookingMessages { get; set; }

        public bool WantsToBePetsitter { get; set; }
        public bool IsProfileCompleted { get; set; }
    }
}
