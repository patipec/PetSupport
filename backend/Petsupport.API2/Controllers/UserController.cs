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
using Petsupport.API2.GraphServiceFactory;


namespace Petsupport.API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IGraphService _graphService;
        private readonly IMapper _mapper;

        public UserController(IGraphService graphService, IMapper mapper)
        {
            _graphService = graphService;
            _mapper = mapper;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<string>> GetUser()
        {
            var azureId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return Ok(azureId);
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

            if (CreateUserInDatabase(createPetsitterDto))
            {
                return StatusCode(StatusCodes.Status201Created);
            }
            else
            {
                return BadRequest("Database error");
            }

            
        }

        private bool CreateUserInDatabase(CreatePetsitterDTO createPetsitterDto)
        {
            throw new NotImplementedException();
        }
    }
}
