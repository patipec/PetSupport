using System.Linq;
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
                .ForMember(dto => dto.ImageId, opt =>
                    opt.MapFrom(p => p.PhotoId))
                .ReverseMap();
<<<<<<< HEAD:backend/Petsupport.API2/Profiles/PetSupportProfile.cs

=======
            
            this.CreateMap<Coordinate, CoordinateDTO>()
                .ReverseMap();;
            
            
            this.CreateMap<Petsitter, CreatePetsitterDTO>()
                .ForMember(p => p.ImageId, o => o.MapFrom(m => m.PhotoId))
                .ReverseMap();
            
            
>>>>>>> 9613a4fc8544779b6f923998e48f6c93e3b9aae0:backend/Petsupport.API2/Mapping/PetSupportProfile.cs
            this.CreateMap<Service, ServiceDTO>()
                .ReverseMap();
            
            
            this.CreateMap<Petsitter, FullPetsitterDTO>()
                .ReverseMap();

            this.CreateMap<CreatePetsitterDTO, User>().ConvertUsing<CreatePetsitterDTOToUserConverter>();
        }
    }
}