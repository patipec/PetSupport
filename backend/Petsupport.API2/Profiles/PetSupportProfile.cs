using AutoMapper;
using Petsupport.API2.Dtos.InDtos;
using Petsupport.API2.Dtos.OutDtos;
using PetSupport.Core.Entities;
using User = Microsoft.Graph.User;

namespace Petsupport.API2.Profiles
{
    public class PetSupportProfile: Profile
    {
        public PetSupportProfile()
        {
            this.CreateMap<Petsitter, PetsitterDTO>()
                .ForMember(p => p.ImageId, o => o.MapFrom(p => p.PhotoId))
                .ReverseMap();

            this.CreateMap<Service, ServiceDTO>()
                .ReverseMap();
            
            this.CreateMap<PetsitterService, PetSitterServiceDTO>()
                .ReverseMap();
            
            this.CreateMap<Petsitter, FullPetsitterDTO>()
                .ReverseMap();

            this.CreateMap<CreatePetsitterDTO, User>().ConvertUsing<CreatePetsitterDTOToUserConverter>();
        }
    }
}