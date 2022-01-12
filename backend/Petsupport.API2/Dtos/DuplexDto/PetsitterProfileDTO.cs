using System;
using System.Collections.Generic;
using Petsupport.API2.Dtos.InDtos;
using PetSupport.Core.Entities;

namespace Petsupport.API2.Dtos.OutDtos
{
    public class PetsitterProfileDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AvatarId { get; set; }
        public string PhotoGallery { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ShortDescription { get; set; }
        public string Environment { get; set; }
        public string Experience { get; set; }
        public PetService PetService { get; set; }
        public PetPreference PetPreference { get; set; }
    }
}