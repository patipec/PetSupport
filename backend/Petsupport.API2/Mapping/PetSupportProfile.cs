using AutoMapper;
using Petsupport.API2.Dtos.InDtos;
using Petsupport.API2.Dtos.OutDtos;
using PetSupport.Core.Entities;
using User = Microsoft.Graph.User;

namespace Petsupport.API2.Mapping
{
    public class PetSupportProfile : Profile
    {
        public PetSupportProfile()
        {
            this.CreateMap<PetSupport.Core.Entities.User.Petsitter, PetsitterDTO>()
                .ForMember(dto => dto.ImageId, opt =>
                    opt.MapFrom(p => p.PhotoId))
                .ReverseMap();


            this.CreateMap<PetSupport.Core.Entities.User.Coordinate, CoordinateDTO>()
                .ReverseMap(); ;


            this.CreateMap<Service, ServiceDTO>()
                .ReverseMap();


            this.CreateMap<PetSupport.Core.Entities.User.Petsitter, FullPetsitterDTO>()
                .ReverseMap();

            
            this.CreateMap<CreatePetsitterDTO, User>().ConvertUsing<CreatePetsitterDTOToUserConverter>();
            
            CreateMap<BasicInfoDTO, PetSupport.Core.Entities.User.Petsitter>();
            CreateMap<PersonalInfoDTO, PetSupport.Core.Entities.User.Petsitter>();
            CreateMap<AddressDTO, PetSupport.Core.Entities.User.Petsitter>();
            CreateMap<PetSitterPhotosDTO, PetSupport.Core.Entities.User.Petsitter>();
            CreateMap<CreatePetsitterDTO, PetSupport.Core.Entities.User.Petsitter>()
                .IncludeMembers(
                    c => c.BasicInfoDto,
                    c => c.PersonalInfoDto,
                    c => c.AddressDto,
                    c => c.PetSitterPhotosDto);

            this.CreateMap<BookingMessage, BookingMessageBriefDTO>()
                .ForMember(dto=>dto.SendDate,
                    opt=>
                        opt.MapFrom(m=>m.SendData.ToString()));
            
            this.CreateMap<BookingMessage, BookingMessageFullDTO>()
                .ForMember(dto=>dto.SendDate,
                    opt=>
                        opt.MapFrom(m=>m.SendData.ToString()))
                .ForMember(dto=>dto.Message,
                opt=>
                    opt.MapFrom(m=>m.Text));


            this.CreateMap<BookingMessage, CreateBookingMessageDTO>()
                .ForMember(dto => dto.Message,
                    opt =>
                        opt.MapFrom(m => m.Text))
                .ReverseMap();
        }
    }
}