using System.Collections.Generic;
using System.Linq;

namespace PetSupport.Core.Entities
{
    public class Petsitter: User
    {
       public string Description { get; set; }
        public string Password { get; set; }
        public string PhotoId { get; set; }
        public string City { get; set; }
        public List<PetsitterService> Services { get; set; }
    }
}