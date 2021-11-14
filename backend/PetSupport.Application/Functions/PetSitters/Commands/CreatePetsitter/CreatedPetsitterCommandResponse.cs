using FluentValidation.Results;
using PetSupport.Application.Responses;

namespace PetSupport.Application.Functions.PetSitters.Commands.CreatePetsitter
{
    public class CreatedPetsitterCommandResponse: BaseResponse
    {
        public int? PetsitterProfileId { get; set; }
        //user where petsitterprofile is not null
        
        public CreatedPetsitterCommandResponse() : base()
        { }

        public CreatedPetsitterCommandResponse(ValidationResult validationResult)
            : base(validationResult)
        { }

        public CreatedPetsitterCommandResponse(string message)
            : base(message)
        { }

        public CreatedPetsitterCommandResponse(string message, bool success)
            : base(message, success)
        { }

        public CreatedPetsitterCommandResponse(int petsitterId)
        {
            PetsitterProfileId = petsitterId;
        }
    }
}