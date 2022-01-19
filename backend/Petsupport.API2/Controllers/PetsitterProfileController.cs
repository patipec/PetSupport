using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Petsupport.API2.Dtos.DuplexDto;
using PetSupport.Infrastructure.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Petsupport.API2.Controllers
{
    [Route("api/user/{userName}/petsitter")]
    [ApiController]
    public class PetsitterProfileController : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public PetsitterProfileController(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        // GET: api/<PetsitterProfileController>
        [HttpGet]
        public ActionResult<List<BasicPetsitterProfileDTO>> Get()
        {
            var petsitterProfile = _dataContext.BasicPetsitterProfiles.ToList();

            var bpp = _mapper.Map<List<BasicPetsitterProfileDTO>>(petsitterProfile);
            return Ok(bpp);
        }

        /*// GET api/<PetsitterProfileController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PetsitterProfileController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PetsitterProfileController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PetsitterProfileController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
