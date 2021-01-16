using AutoMapper;
using Petsupport.API2.Dtos.OutDtos;
using PetSupport.API2.Dtos.OutDtos;
using PetSupport.Core.Entities;

namespace PetSupport.API2.MappingProfiles
{
    public class PetSupportProfile : Profile
    {
        public PetSupportProfile()
        {
            CreateMap<Petsitter, PetsitterDTO>()
                .ForMember(p => p.ImageId, o => o.MapFrom(m => m.PhotoId))
                .ReverseMap();

            CreateMap<Service, ServiceDTO>()
                .ReverseMap();
        }
    }
}