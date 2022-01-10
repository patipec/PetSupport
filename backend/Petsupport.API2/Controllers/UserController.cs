﻿/*using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph;
using Petsupport.API2.Dtos.InDtos;
using Petsupport.API2.Dtos.OutDtos;
using Petsupport.API2.GraphServiceFactory;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;
using System;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using User = PetSupport.Core.Entities.User;


namespace Petsupport.API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IGraphService _graphService;
        private readonly IMapper _mapper;
        private readonly IPetsitterRepository _petsitterRepository;

        public UserController(IGraphService graphService, IMapper mapper, IPetsitterRepository petsitterRepository)
        {
            _graphService = graphService;
            _mapper = mapper;
            _petsitterRepository = petsitterRepository;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<string>> GetUser()
        {
            var azureId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var petsitter = await _petsitterRepository.GetByAzureId(azureId);
            if (petsitter != null)
            {
                return Ok(_mapper.Map<PetsitterDTO>(petsitter));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDTO createUserDto)
        {
            var user = _mapper.Map<Microsoft.Graph.User>(CreateUserDTO);
            try
            {
                user = await _graphService.GraphClient.Users
                    .Request()
                    .AddAsync(user);
            }
            catch (ServiceException ex)
            {
                return ex.StatusCode == HttpStatusCode.BadRequest
                    ? BadRequest(ex.Error)
                    : StatusCode(StatusCodes.Status500InternalServerError, ex.Error);
            }

            var petsitter = _mapper.Map<User>(CreateUserDTO);
            petsitter.AzureId = user.Id;
            try
            {
                _petsitterRepository.Add(petsitter);
                await _petsitterRepository.SaveChangesAsync();
                return CreatedAtAction(
                    nameof(PetsittersController.GetPetsitterById),
                    "Petsitters",
                    new { id = petsitter.Id },
                    _mapper.Map<PetsitterDTO>(petsitter));
            }
            catch (Exception e)
            {
                await _graphService.GraphClient.Users["{" + user.Id + "}"]
                    .Request()
                    .DeleteAsync();
                return BadRequest("Database error");
            }

        }
    }
}*/