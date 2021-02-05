using PetSupport.Core.Enums;

namespace Petsupport.API2.Dtos.OutDtos
{
    public class ServiceDTO
    {
        public string Name { get; set; }
        public Unit Unit { get; set; }
        public double Price { get; set; }
    }
}