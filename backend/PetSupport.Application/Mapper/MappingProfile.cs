using AutoMapper;
using PetSupport.Application.Functions.PetServices.Commands.CreatePetService;
using PetSupport.Domain.Entities;

namespace PetSupport.Application.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<PetService, CreatePetServiceCommand>()
                .ReverseMap();
        }
        
    }
}