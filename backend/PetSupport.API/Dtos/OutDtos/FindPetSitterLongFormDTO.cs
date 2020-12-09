namespace PetSupport.API.Dtos.OutDtos
{
    public class FindPetSitterLongFormDTO
    {
        public string Address { get; set; }
        public string City { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public int ServiceId { get; set; }
    }
}