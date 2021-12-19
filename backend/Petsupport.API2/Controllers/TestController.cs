using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PetSupport.API2.Controllers
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Authorize(Policy = "CustomerScope")]
        public IActionResult WelcomeCustomer()
        {
            return Ok("Hello Customer!");
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Authorize(Policy = "SitterScope")]
        public IActionResult WelcomeSitter()
        {
            return Ok("Hello  Pet sitter!");
        }
    }
}