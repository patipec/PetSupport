﻿using System;
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
        private readonly IRepository<Petsitter> _petSitterRepository;
        private readonly IRepository<Service> _serviceRepository;
        private readonly IMapper _mapper;


        public PetsittersController(IRepository<Petsitter> petSitterRepository, IRepository<Service> serviceRepository, IMapper mapper)
        {
            this._petSitterRepository = petSitterRepository;
            this._serviceRepository = serviceRepository;
            this._mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<PetsitterDTO[]>> GetAllPetsitters()
        {
            try
            {
                var petsitters = await _petSitterRepository.GetAllAsync();
                var petsittersResult = _mapper.Map<PetsitterDTO[]>(petsitters);
                return Ok(petsittersResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        
        // [HttpGet()]
        // public async Task<ActionResult<PetsitterDTO[]>> GetAllPetsittersByQuery( [FromQuery]string city)
        // {
        //     try
        //     {
        //         var petsittersFilltered = await _petSitterRepository
        //             .FindByConditionAsync(p=>p.City==city);
        //         
        //         var petsittersResult = _mapper.Map<PetsitterDTO[]>(petsittersFilltered);
        //         
        //         return Ok(petsittersResult);
        //     }
        //     catch (Exception ex)
        //     {
        //         return StatusCode(500, "Internal server error");
        //     }
        // }
        
        

        [HttpGet("{id:int}")]
        public async Task<ActionResult<PetsitterDTO>> GetPetsitterById(int id)
        {
            var petsitter = await _petSitterRepository.GetByIdAsync(id);
            return Ok(_mapper.Map<PetsitterDTO>(petsitter));
        }
    }
}
