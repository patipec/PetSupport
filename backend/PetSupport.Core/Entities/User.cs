using System;
using System.Collections.Generic;

namespace PetSupport.Core.Entities
{
    public class User : BaseEntity
    {
        //General user properties
        public string AzureId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }    
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsPettsitter { get; set; }
        public bool PetsitterProfileCompleted { get; set; }
        

        // Relational
        #nullable enable
        public ICollection<BookingMessage>? BookingMessage { get; set; }
        public AdressDetails? AdressDetails { get; set; }
        public PetsitterProfile? PetsitterProfile { get; set; }
        public Coordinate? Coordinates { get; set; }
        public ICollection<PetDescription>? Pets {get; set; }
        


    }
}