using System.Linq;
using AutoMapper;
using Petsupport.API2.Dtos.InDtos;
using Petsupport.API2.Dtos.OutDtos;
using PetSupport.Core.Entities;

namespace Petsupport.API2.Profiles
{
    public class PetSupportProfile: Profile
    {
        public PetSupportProfile()
        {
            this.CreateMap<Petsitter, PetsitterDTO>()
                .ForMember(dto => dto.ImageId, opt =>
                    opt.MapFrom(p => p.PhotoId))
                .ReverseMap();
            
            this.CreateMap<Coordinates, CoordinateDTO>()
                .ReverseMap();;
            
            
            this.CreateMap<Petsitter, CreatePetsitterDTO>()
                .ForMember(p => p.ImageId, o => o.MapFrom(m => m.PhotoId))
                .ReverseMap();
            
            
            this.CreateMap<Service, ServiceDTO>()
                .ReverseMap();
            
            
            this.CreateMap<Petsitter, FullPetsitterDTO>()
                .ReverseMap();
        }
    }
}