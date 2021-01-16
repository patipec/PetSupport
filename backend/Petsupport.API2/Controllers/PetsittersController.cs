using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Petsupport.API2.Dtos.OutDtos;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;

namespace PetSupport.API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsittersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Petsitter> _petSitterRepository;


        public PetsittersController(IRepository<Petsitter> petSitterRepository, IMapper mapper)
        {
            _petSitterRepository = petSitterRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<PetsitterDTO[]>> Get()
        {
            var results = await _petSitterRepository.GetAllAsync();
            return _mapper.Map<PetsitterDTO[]>(results);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<PetsitterDTO>> Get(int id)
        {
            var result = await _petSitterRepository.GetByIdAsync(id);
            return _mapper.Map<PetsitterDTO>(result);
        }
    }
}