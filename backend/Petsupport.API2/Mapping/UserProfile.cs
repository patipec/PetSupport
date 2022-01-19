using AutoMapper;
using Petsupport.API2.Dtos.DuplexDto;
using Petsupport.API2.Dtos.InDtos;
using Petsupport.API2.Dtos.OutDtos;
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

            /*CreateMap<User, PetsitterListDTO>()
                .ForMember(m => m.Name, map => map.MapFrom(user => user.BasicUserInfo.Name))
                .ForMember(m => m.City, map => map.MapFrom(user => user.AddressDetails.City))
                .ForMember(m => m.AvatarId, map => map.MapFrom(user => user.BasicUserInfo.AvatarId))
            .ForMember(m => m.Price, map => map.MapFrom(user => user.BasicPetsitterProfile.PetServices.FirstOrDefault().Price)).ReverseMap();*/

            /*CreateMap<BasicUserInfo, PetsitterListDTO>()
                .ForMember(m => m.Name, map => map.MapFrom(info=>info.Name))
                .ForMember(m => m.AvatarId, map => map.MapFrom(info=>info.AvatarId));*/

            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
            CreateMap<AddressDetailsDTO, AddressDetails>().ReverseMap();
            CreateMap<PetService, PetServiceDTO>().ReverseMap();
            CreateMap<BasicUserInfoDTO, BasicUserInfo>().ReverseMap();
            CreateMap<BasicPetsitterProfile, PetsitterProfileDTO>();
            CreateMap<BasicPetsitterProfileDTO, BasicPetsitterProfile>().ReverseMap();
            CreateMap<PetPreferenceDTO, PetPreference>().ReverseMap();
            CreateMap<AnimalDTO, Animal>().ReverseMap();
            CreateMap<BookingMessageDTO, BookingMessage>().ReverseMap();


        }
    }
}