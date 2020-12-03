using System.Collections.Generic;
using System.Linq;
using PetSupport.Core.Entities;

namespace PetSupport.Data.Entities
{
    public class Petsitter: User
    {
       public string Description { get; set; }
        public string Password { get; set; }
        public string PhotoId { get; set; }
        public string City { get; set; }
        public IQueryable<Service> Services { get; set; }
    }
}