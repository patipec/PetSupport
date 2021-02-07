using System;

namespace PetSupport.Core.Entities
{
    public class User : BaseEntity
    {
        public string AzureId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        
    }
}