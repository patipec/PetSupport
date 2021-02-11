using System;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Petsupport.API2.Dtos.InDtos;
using Petsupport.API2.Dtos.OutDtos;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;
using PetSupport.Core.ResourceParameters;
using PetSupport.Core.Wrappers;

namespace Petsupport.API2.Controllers
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
          

        [HttpGet]
        public async Task<ActionResult<PetsitterDTO[]>> GetPetsittersBySearchParameters
            ([FromQuery] PetsittersSearchParameters petsittersSearchParameters)
        {

            try
            {
                var petsittersFiltered = await _petsitterRepository
                    .GetAllPetsittersBySearchParametersAsync(petsittersSearchParameters);
                
                var listPetsittersDto = _mapper.Map<PetsitterDTO[]>(petsittersFiltered);
                
                foreach (var petsitter in listPetsittersDto)
                {
                    petsitter.Price = petsittersFiltered
                        .FirstOrDefault(p => p.Id == petsitter.Id)
                        .Services
                        .FirstOrDefault(s => (int) s.Name == petsittersSearchParameters.ServiceId)
                        .Price;
                }
                return Ok(listPetsittersDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        
        
        [HttpGet("{id}", Name = nameof(GetPetsitterById))]
        public async Task<ActionResult<PetsitterDTO>> GetPetsitterById(int id)
        {
            try
            {
                var petsitter = await _petsitterRepository.GetByIdAsync(id);
                if (petsitter == null)
                { 
                    return NotFound();
                }
                return Ok(_mapper.Map<PetsitterDTO>(petsitter));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }

        }


        // [HttpPost]
        // public async Task<ActionResult> CreatePetsitter ([FromBody]CreatePetsitterDTO createPetsitterDto)
        // {
        //     try
        //     {
        //         if (createPetsitterDto == null)
        //         {
        //             return BadRequest("Petsitter object is null");
        //         }
        //         
        //         var petsitterEntity = _mapper.Map<Petsitter>(createPetsitterDto);
        //         _petsitterRepository.Add(petsitterEntity);
        //         await _petsitterRepository.SaveChangesAsync();
        //         
        //         var petsitterToReturn = _mapper.Map<FullPetsitterDTO>(petsitterEntity);
        //
        //         return CreatedAtRoute("PetsitterById", new {id = petsitterEntity.Id}, petsitterToReturn);
        //     }
        //     catch (Exception ex)
        //     {
        //         return StatusCode(500, "Internal server error");
        //     }
        // }

        // [HttpPut("{id:int}")]
        // public async Task<ActionResult> UpdatePetsitter(int id, UpdatePetsitterDTO updatePetsitterDto)
        // {
        //     if (updatePetsitterDto == null)
        //     {
        //         return BadRequest("Petsitter object is null");
        //     }
        //
        //     if (!ModelState.IsValid)
        //     {
        //         return BadRequest("Invalid model objetct");
        //     }
        //
        //     var petsitterFromRepo = await _petsitterRepository.GetByIdAsync(id);
        //     
        // }

        [HttpGet]
        public async Task<ActionResult<PetsitterDTO[]>> GetPettsittersWithPaging([FromQuery] PagingParameters parameters, PetsittersSearchParameters petsittersSearchParameters)
        {
            try
            {
                var validParameter = new PagingParameters(parameters.PageNumber, parameters.PageSize);

                var petsittersFiltered = await _petsitterRepository
                    .GetAllPetsittersBySearchParametersAsync(petsittersSearchParameters);
                
                var petsittersToReturn = _mapper.Map<PetsitterDTO[]>(petsittersFiltered);

                var usersListResult = new PagedResponse<PetsitterDTO[]>(petsittersToReturn, validParameter.PageNumber,
                    validParameter.PageSize);

                
                return Ok(usersListResult);
            }

            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }  

    }
   
}
