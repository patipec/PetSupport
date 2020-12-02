using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PetSupport.Data.Entities
{
    public class User: BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
