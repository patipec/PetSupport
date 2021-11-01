using MediatR;
using PetSupport.Application.Functions.Users.Commands.CreateUser;
using PetSupport.Domain.Enums;

namespace PetSupport.Application.Functions.PetServices.Commands.CreatePetService
{
    public class CreatePetServiceCommand : IRequest<CreatePetServiceResponse>
    {
        public int PetServiceId { get; set; }

        public double Price { get; set; }
        
        public ServiceType Name { get; set; }
        
        public int PetSupportUserId { get; set; }

    }
}