using System;

namespace PetSupport.Core.Entities
{
    public class PetsitterProfile
    {
        public string Description { get; set; }
        public string PhotoId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Title { get; set; }
        public double Rate { get; set; }
        public DateTime AvailabilityFrom { get; set; }
        public DateTime AvailabilityTo { get; set; }
        public string Environment { get; set; }
        public string Experience { get; set; }
    }
}