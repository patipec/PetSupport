using FluentValidation;
using FluentValidation.Validators;

namespace PetSupport.Application.Functions.PetSitters.Commands.CreatePetsitter
{
    public class CreatedPetsitterCommandValidator: AbstractValidator<CreatedPetsitterCommand>
    {
        //rules for CreatedPettsitter
        
        /*Petsitter = user where PetsitterProfile is not null
         and WantsToBe Petsitter not null*/
        
    }
}