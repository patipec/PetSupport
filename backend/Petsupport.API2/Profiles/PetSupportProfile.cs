using System.Linq;
using AutoMapper;
using Petsupport.API2.Dtos.InDtos;
using Petsupport.API2.Dtos.OutDtos;
using PetSupport.API2.Dtos.OutDtos;
using PetSupport.Core.Entities;

namespace PetSupport.API2.MappingProfiles
{
    public class PetSupportProfile: Profile
    {
        public PetSupportProfile()
        {
            this.CreateMap<Petsitter, PetsitterDTO>()
                .ForMember(p => p.ImageId, o => o.MapFrom(m => m.PhotoId))
                .ReverseMap();
            
//TODO: ZipCode, Addres 
            this.CreateMap<Petsitter, CreatePetsitterDTO>()
                .ForMember(p => p.ImageId, o => o.MapFrom(m => m.PhotoId))

                .ReverseMap();

            this.CreateMap<Petsitter, FullPetsitterDTO>()
                .ReverseMap();
            
            this.CreateMap<Service, ServiceDTO>()
                .ReverseMap();
            this.CreateMap<PetsitterService, PetSitterServiceDTO>()
                .ReverseMap();


        }
    }
}