using PetSupport.Core.Entities;

namespace Petsupport.API2.Dtos.InDtos
{
    public class CreatePetsitterDTO : BaseEntity
    {
        public BasicInfoDTO BasicInfoDto { get; set; }
        public AddressDTO AddressDto { get; set; }
        public ServicesDTO ServicesDto { get; set; }
        public PersonalInfoDTO PersonalInfoDto { get; set; }
        public PetSitterPhotosDTO PetSitterPhotosDto { get; set; }
    }
}