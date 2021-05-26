
using System;
using System.Collections.Generic;

namespace PetSupport.Core.Entities
{
    public class Petsitter: BaseEntity
    {
        public BasicPetsitterProfile BasicPetsitterProfile { get; set; }
        
        //czy tu nie powinna być kolekcja serwisów ??
        public PetsitterService PetsitterServices { get; set; }
    }
}