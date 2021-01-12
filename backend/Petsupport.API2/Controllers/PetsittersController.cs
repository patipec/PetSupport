using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Petsupport.API2.Dtos.InDtos;
using Petsupport.API2.Dtos.OutDtos;
using PetSupport.API2.Dtos.OutDtos;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;

namespace PetSupport.API2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetsittersController : ControllerBase
    {
        private readonly IPetsitterRepository _petsitterRepository;
        private readonly IMapper _mapper;
        
        
        public PetsittersController(IPetsitterRepository petsitterRepository, IMapper mapper)
        {
            this._petsitterRepository = petsitterRepository;
            this._mapper = mapper;
        }


        /*[HttpGet]
        public async Task<ActionResult<PetsitterDTO[]>> GetAllPetsitters()
        {
            try
            {
                var petsitters = await _petSitterRepository.GetAllAsync();
                var petsittersToReturn = _mapper.Map<PetsitterDTO[]>(petsitters);
                return Ok(petsittersToReturn);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }*/
        
        [HttpGet]
        public async Task<ActionResult<PetsitterDTO[]>> GetAllPetsittersByQuery([FromQuery] 
            string city, int serviceId )
        {
            try
            {
                var petsitersFillteredByQuery =
                    await _petsitterRepository
                        .GetAllPetsitersByCityAndService(city, serviceId);

                return Ok(_mapper.Map<PetsitterDTO[]>(petsitersFillteredByQuery));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        
        
        [HttpGet("{id:int}", Name = "PetsitterById")]
        public async Task<ActionResult<PetsitterDTO>> GetPetsitterById(int id)
        {
            var petsitter = await _petsitterRepository.GetByIdAsync(id);
            if (petsitter == null)
            { 
                return NotFound();
            }
            return Ok(_mapper.Map<PetsitterDTO>(petsitter));
        }

        
        [HttpPost]
        public async Task<ActionResult> CreatePetsitter ([FromBody]CreatePetsitterDTO createPetsitterDto)
        {
            try
            {
                if (createPetsitterDto == null)
                {
                    return BadRequest("Petsitter object is null");
                }
                
                var petsitterEntity = _mapper.Map<Petsitter>(createPetsitterDto);
                _petsitterRepository.Add(petsitterEntity);
                await _petsitterRepository.SaveChangesAsync();
                
                var petsitterToReturn = _mapper.Map<FullPetsitterDTO>(petsitterEntity);

                return CreatedAtRoute("PetsitterById", new {id = petsitterEntity.Id}, petsitterToReturn);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
