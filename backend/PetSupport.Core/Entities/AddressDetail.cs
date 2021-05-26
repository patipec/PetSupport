namespace PetSupport.Core.Entities
{
    public class AddressDetail
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string? FlatNumber { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        
        //TODO: Czy robimy tu "kontener Localization" czy może bezpośrednio wrzucamy tu propercje ??
        public Localization? Localization { get; set; }
    }
}