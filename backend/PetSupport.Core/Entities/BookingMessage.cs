using System;
using PetSupport.Core.Enums;

namespace PetSupport.Core.Entities

{
    public class BookingMessage 
    {
        public PetType PetType { get; set; }
        public PetWeight PetWeight { get; set; }
        
      //Relationships
        public int[] UserId { get; set; }
     
        //Jak tutaj zakodować żeby była od razu tablica dwuelementowa i jak ma relacja wygladać 
        public MessageText MessageText { get; set; }
        
    }
}