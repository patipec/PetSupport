using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetSupport.Core.Entities
{
    public class User 
    {
        [Key]
        public int Id { get; set; }
        public string AzureId { get; set; }

        public int BasicUserInfoId { get; set; }
        public int AddressDetailsId { get; set; }
        public int BasicPetsitterProfileId { get; set; }

        public  AddressDetails AddressDetails { get; set; }
        public BasicUserInfo BasicUserInfo { get; set; }
        public BasicPetsitterProfile BasicPetsitterProfile { get; set; }
             
        public  List<Animal> Animals { get; set; }
        public  List<BookingMessage> BookingMessages { get; set; }


        //Petsitter
        public bool WantsToBePetsitter { get; set; }
        public bool IsProfileCompleted { get; set; }
        
    }
}