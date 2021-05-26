using System;

namespace PetSupport.Core.Entities
{
    public class BasicPetsitterProfile
    {
        public DateTime DateOfBirth { get; set; }
        public string ShortDescription { get; set; }
        public string Experience { get; set; }
        public string Availability { get; set; }
        public string Environment { get; set; }
    }
}