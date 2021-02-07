using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph;
using Microsoft.Graph.Auth;
using Petsupport.API2.Dtos.InDtos;
using Petsupport.API2.Controllers;
using Petsupport.API2.Dtos.OutDtos;
using Petsupport.API2.GraphServiceFactory;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;
using User = Microsoft.Graph.User;


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
        public async Task<IActionResult> CreateUser(CreatePetsitterDTO createPetsitterDto)
        {
            var user = _mapper.Map<User>(createPetsitterDto);
            try
            {
                await _graphService.GraphClient.Users
                    .Request()
                    .AddAsync(user);
            }
            catch (ServiceException ex)
            {
                return ex.StatusCode == HttpStatusCode.BadRequest
                    ? BadRequest(ex.Error)
                    : StatusCode(StatusCodes.Status500InternalServerError, ex.Error);
            }

            var petsitter = CreateUserInDatabase(createPetsitterDto);
            if (petsitter != null)
            {
                return CreatedAtAction(
                    nameof(PetsittersController.GetPetsitterById),
                    "Petsitters",
                    new {id = petsitter.Id},
                    _mapper.Map<PetsitterDTO>(petsitter));
            }
            else
            {
                return BadRequest("Database error");
            }

            
        }

        private Petsitter CreateUserInDatabase(CreatePetsitterDTO createPetsitterDto)
        {
            throw new NotImplementedException();
        }
    }
}
