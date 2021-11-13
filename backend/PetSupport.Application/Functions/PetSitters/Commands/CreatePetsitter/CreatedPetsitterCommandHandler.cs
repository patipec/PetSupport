using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using PetSupport.Application.Contracts_Interfaces.Persistence;
using PetSupport.Domain.Entities;

namespace PetSupport.Application.Functions.PetSitters.Commands.CreatePetsitter
{
    public class CreatedPetsitterCommandHandler: IRequestHandler<CreatedPetsitterCommand, CreatedPetsitterCommandResponse>
    {
        private readonly IPetsitterRepository _petsitterRepository;
        private readonly IMapper _mapper;
        
        public async Task<CreatedPetsitterCommandResponse> Handle(CreatedPetsitterCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreatedPetsitterCommandValidator(_petsitterRepository);
            var validatorResult = await validator.ValidateAsync(request);

            if (!validatorResult.IsValid)
                return new CreatedPetsitterCommandResponse(validatorResult);

            var petsitter = _mapper.Map<PetsitterProfile>(request);

            petsitter = await _petsitterRepository.AddAsync(petsitter);

            return new CreatedPetsitterCommandResponse(petsitter.PetsitterProfileId);
        }
        public CreatedPetsitterCommandHandler(IPetsitterRepository petsitterRepository,
            IMapper mapper)
        {
            _petsitterRepository = petsitterRepository;
            _mapper = mapper;
        }
    }
}