using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PetSupport.API2.Controllers
{
    [ApiController]
    [Route("/api/[controller]/[action]")]
    public class ValueController : Controller
    {
        // GET api/values
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"value1", "value2"};
        }
    }
}