using FluentValidation.Results;
using PetSupport.Application.Responses;

namespace PetSupport.Application.Functions.PetServices.Commands.CreatePetService
{

    class CreatedPetServiceCommandResponse : BaseResponse

    {
    private int? PetServiceId { get; set; }

    public CreatedPetServiceCommandResponse() : base()
    {
    }

    public CreatedPetServiceCommandResponse(ValidationResult validationResult) : base(validationResult)
    {
    }

    public CreatedPetServiceCommandResponse(string message)
        : base(message)
    {
    }

    public CreatedPetServiceCommandResponse(string message, bool success)
        : base(message, success)
    {
    }

    public CreatedPetServiceCommandResponse(int petServiceId)
    {
        PetServiceId = petServiceId;
    }
    }
}