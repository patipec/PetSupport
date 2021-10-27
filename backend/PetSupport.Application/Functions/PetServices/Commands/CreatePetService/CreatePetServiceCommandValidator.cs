using FluentValidation;
using MediatR;
using PetSupport.Application.Functions.Users.Commands.CreateUser;

namespace PetSupport.Application.Functions.PetServices.Commands.CreatePetService
{
    public class CreatePetServiceCommandValidator: AbstractValidator<CreatePetServiceCommand>
    {
        public CreatePetServiceCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .IsInEnum();

            RuleFor(p => p.Price)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .GreaterThan(0);
        }
    }
}