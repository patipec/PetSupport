using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetSupport.Core.Enums;

namespace PetSupport.Core.Entities
{
    public class PetPreferences: BaseEntity
    {
        public PetType PetType { get; set; }
        public PetWeight PetWeight { get; set; }
    }
}
