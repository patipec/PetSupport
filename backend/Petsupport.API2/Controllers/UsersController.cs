using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petsupport.API2.Dtos.InDtos;
using PetSupport.Core.Entities;
using PetSupport.Infrastructure.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;

using Petsupport.API2.Dtos.DuplexDto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Petsupport.API2.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public UsersController(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public ActionResult<List<UserDTO>> Get()
        {
            var users = _dataContext.Users.ToList();

            var userDtos = _mapper.Map<List<UserDTO>>(users);
            return Ok(userDtos);
        }

        // GET api/<UsersController>/Radom
        [HttpGet("{city}")]
        public ActionResult<UserDTO> GetUserByCity(string city)
        {
            var user = _dataContext.Users
                .FirstOrDefault(m => m.AddressDetails.City.ToLower() == city.ToLower());
           
            if (user == null)
            {
                return NotFound();
            }

            var userDTO = _mapper.Map<UserDTO>(user);
            return Ok(userDTO);

        }
        [HttpGet("{id}")]
        public ActionResult<UserDTO> GetUserById(int id)
        {
            var user = _dataContext.Users
                .FirstOrDefault(m => m.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            var userDTO = _mapper.Map<UserDTO>(user);
            return Ok(userDTO);

        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult Post([FromBody] UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _dataContext.Users.Add(user);
            _dataContext.SaveChanges();

            var key = user.AddressDetails.City.ToLower();

            return Created("api/users/" + key,null);

        }

        /*// PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}