using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using PetSupport.Application.Contracts_Interfaces.Persistence;
using PetSupport.Application.Functions.Users.Commands.CreateUser;
using PetSupport.Domain.Entities;

namespace PetSupport.Application.Functions.PetServices.Commands.CreatePetService
{
    public class CreatePetServiceCommandHandler
        : IRequestHandler<CreatePetServiceCommand, CreatePetServiceResponse>
    {
        private readonly IPetSupportDbContext _petSupportDbContext;
        private readonly IMapper _mapper;

        
        public CreatePetServiceCommandHandler(IPetSupportDbContext petSupportDbContext, IMapper mapper)
        {
            _petSupportDbContext = petSupportDbContext;
            _mapper = mapper;
        }

        
        public async Task<CreatePetServiceResponse> 
            Handle(CreatePetServiceCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreatePetServiceCommandValidator();
            var validatorResult = await validator.ValidateAsync(request);

            if (!validatorResult.IsValid)
                return new CreatePetServiceResponse(validatorResult);

            var petService = _mapper.Map<PetService>(request); 
            /*var petService = new PetService()
            {
                Id = request.PetServiceId,
                Price = request.Price,
                Name = request.Name,
                PetSupportUserId = request.PetSupportUserId
            };*/
            
            _petSupportDbContext.PetServices.Add(petService);
            
            await _petSupportDbContext.SaveChangesAsync(cancellationToken);

            return new CreatePetServiceResponse(petService.Id);
        }
    }
}