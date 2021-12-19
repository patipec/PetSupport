namespace Petsupport.API2.Dtos.InDtos
{
    public class PetsitterBriefDtoDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string AvatarId { get; set; }
        public string City { get; set; }
        public string ShortDescription { get; set; }
    }
}