namespace Petsupport.API2.Dtos.OutDtos
{
    public class FindPetSitterLongFormDTO
    {
        public string Street { get; set; }
        public string City { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public int ServiceId { get; set; }
    }
}