using System;
using System.Collections.Generic;
using Petsupport.API2.Dtos.InDtos;
using PetSupport.Core.Entities;

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
        public ICollection<CoordinateDTO> Coordinates { get; set; }
        public string Description { get; set; }
        public string AvailabilityTo { get; set; }
        //TODO: check this
        public double Price { get; set; }

    }
}