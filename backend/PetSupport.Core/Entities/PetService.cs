using PetSupport.Core.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetSupport.Core.Entities
{
    public class PetService 

    {
        [Key]
        public int Id { get; set; }
        //TODO  setting price should be not only service type and price for it. Petpreference should be there as well
        public double Price { get; set; }
        public ServiceType ServiceType { get; set; }


        public int BasicPetsitterProfileId { get; set; }
        public BasicPetsitterProfile BasicPetsitterProfile { get; set; }
    }
}