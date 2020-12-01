using System.Collections.Generic;

namespace PetSupport.Data.Entities
{
    public class Petsitter: User
    {
       public string Description { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public string City { get; set; }
        public List<Service> Services { get; set; }
    }
}