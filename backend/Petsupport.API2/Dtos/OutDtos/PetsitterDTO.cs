using System;

namespace Petsupport.API2.Dtos.OutDtos
{
    public class PetsitterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Description { get; set; }
        public string AvailabilityTo { get; set; }
        //TODO: check this
        public decimal Price { get; set; }
    }
}