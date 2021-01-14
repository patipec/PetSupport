namespace PetSupport.Core.ResourceParameters
{
    public class PetsittersSearchParameters
    {
        //FindPetSitterShortFormDTO
        public string City { get; set; }
        public int ServiceId { get; set; }
        
        //FindPetSitterLongFormDTO
        public string Address { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
    }
}