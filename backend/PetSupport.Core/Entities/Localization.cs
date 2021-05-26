namespace PetSupport.Core.Entities
{
    public class Localization
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double? Range { get; set; }
        //TODO: czy robimy relacje FKId do User?
    }
}