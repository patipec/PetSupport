using AutoMapper;
using Petsupport.API2.Dtos.InDtos;
using Petsupport.API2.Dtos.OutDtos;
using Petsupport.API2.Profiles;
using PetSupport.Core.Entities;
using User = Microsoft.Graph.User;

namespace Petsupport.API2.Mapping
{
    public class PetSupportProfile: Profile
    {
        public PetSupportProfile()
        {
            this.CreateMap<Petsitter, PetsitterDTO>()
                .ForMember(dto => dto.ImageId, opt =>
                    opt.MapFrom(p => p.PhotoId))
                .ReverseMap();

            
            this.CreateMap<Coordinate, CoordinateDTO>()
                .ReverseMap();;


            this.CreateMap<Service, ServiceDTO>()
                .ReverseMap();
            
            
            this.CreateMap<Petsitter, FullPetsitterDTO>()
                .ReverseMap();

            this.CreateMap<CreatePetsitterDTO, User>().ConvertUsing<CreatePetsitterDTOToUserConverter>();
        }
    }
}