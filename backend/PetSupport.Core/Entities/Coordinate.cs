namespace PetSupport.Core.Entities
{
    public class Coordinate :BaseEntity
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int PetsitterId { get; set; }
    }
}