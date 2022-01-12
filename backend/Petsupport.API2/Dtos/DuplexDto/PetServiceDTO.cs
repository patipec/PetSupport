using PetSupport.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petsupport.API2.Dtos.DuplexDto
{
    public class PetServiceDTO
    {
        public double Price { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
