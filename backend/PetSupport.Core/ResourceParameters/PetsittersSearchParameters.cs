using System;

namespace PetSupport.Core.ResourceParameters
{
    public class PetsittersSearchParameters
    {
        //FindPetSitterShortFormDTO
        public string City { get; set; }
        public int? ServiceId { get; set; } = null;
        
        //FindPetSitterLongFormDTO
        public string Street { get; set; }
        public int? MinPrice { get; set; } = 0;
        public int? MaxPrice { get; set; } = Int32.MaxValue;
    }
}