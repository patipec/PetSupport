using System.Collections.Generic;
using PetSupport.Core.Enums;
using PetSupport.Core.Entities;

namespace PetSupport.Core.Entities
{
    public class Service: BaseEntity
    {
        public string ImageId { get; set; }
        public ServiceType Name { get; set; }
        public string Description { get; set; }
        public Unit Unit { get; set; }
<<<<<<< HEAD
        
        //Relationships

        public List<PetsitterService> PetsiterServices { get; set; }
=======
>>>>>>> 378e6988b0505d78bdb6b0485db026cbbb1995d0
    }
    
}
