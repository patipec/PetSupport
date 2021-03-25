using PetSupport.Core.Enums;

namespace Petsupport.API2.Dtos.InDtos
{
    public class ServicesDTO
    {
        public ServiceType ServiceType { get; set; }
        public string PetPreferences { get; set; }
    }
}