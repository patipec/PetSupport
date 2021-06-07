namespace PetSupport.Core.Entities
{
    public class AddressDetail
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        
        //Localization 
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double? Range { get; set; }
    }
}