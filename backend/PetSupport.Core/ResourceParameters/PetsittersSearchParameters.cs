using System;
using System.ComponentModel.DataAnnotations;

namespace PetSupport.Core.ResourceParameters
{
    public class PetsittersSearchParameters : PagingParameters
    {
        //FindPetSitterShortFormDTO
        [Required]
        public string City { get; set; }
        [Required]
        public int? ServiceId { get; set; } = null;
        //FindPetSitterLongFormDTO
        public string Street { get; set; }
        public int? MinPrice { get; set; } = 0;
        public int? MaxPrice { get; set; } = Int32.MaxValue;

       

    }
}