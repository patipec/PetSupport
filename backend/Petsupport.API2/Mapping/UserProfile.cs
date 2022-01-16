using AutoMapper;
using Petsupport.API2.Dtos.DuplexDto;
using Petsupport.API2.Dtos.InDtos;
using PetSupport.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petsupport.API2.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {

            CreateMap<User, PetsitterListDTO>()
                .ForMember(m => m.Name, map => map.MapFrom(user => user.BasicUserInfo.Name))
                .ForMember(m => m.City, map => map.MapFrom(user => user.AddressDetails.City))
                .ForMember(m => m.AvatarId, map => map.MapFrom(user => user.BasicUserInfo.AvatarId))
            .ForMember(m => m.Price, map => map.MapFrom(user => user.BasicPetsitterProfile.PetServices.FirstOrDefault().Price));
            //
            // CreateMap<PetsitterListDTO, PetsitterListNestedMapDTO>()
            //     .ForMember(m => m.Price, map => map.MapFrom(petSitter => petSitter.PetService.Price));

            // CreateMap<PetService, PetsitterListDTO>()
            //     .ForMember(m => m.Price, map => map.MapFrom(user => user.Price));



        }
    }
}