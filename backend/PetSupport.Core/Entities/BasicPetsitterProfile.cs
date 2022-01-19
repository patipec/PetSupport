using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetSupport.Core.Entities
{
    public class BasicPetsitterProfile
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ShortDescription { get; set; }
        public string Experience { get; set; }
        public string Availability { get; set; }
        public string Environment { get; set; }
        public List<PetPreference> PetsitterPetPreferences { get; set; }
        public List<PetService> PetServices { get; set; }

        
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

    }

}