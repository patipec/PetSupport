namespace Petsupport.API2.Dtos.InDtos
{
    public class AddressDTO
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Housenr { get; set; }
        public CoordinateDTO[] CoordinateDtos { get; set; }
    }
}