using FluentValidation.Results;
using PetSupport.Application.Responses;

namespace PetSupport.Application.Functions.PetServices.Commands.CreatePetService
{
    public class CreatePetServiceResponse : BaseResponse
    {
        public int? Id { get; set; }


        public CreatePetServiceResponse() : base()
        {
        }
        
        public CreatePetServiceResponse(ValidationResult validationResult) : base(validationResult)
        {
        }

        public CreatePetServiceResponse(string message = null) : base(message)
        {
        }

        public CreatePetServiceResponse(string message, bool success) : base(message, success)
        {
        }

        public CreatePetServiceResponse(int petServiceId)
        {
            Id = petServiceId;
        }


    }
}