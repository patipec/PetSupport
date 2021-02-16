using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Petsupport.API2.Dtos.OutDtos;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;

namespace Petsupport.API2.Controllers
{
    [ApiController]
    [Route("api/clients/{id}/messages")]
    public class BookingMessagesController : ControllerBase
    {
        private readonly IBookingMessageRepository _bookingMessageRepository;
        private readonly IMapper _mapper;

        
        public BookingMessagesController(IBookingMessageRepository bookingMessageRepository, IMapper mapper)
        {
            _bookingMessageRepository = bookingMessageRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<BookingMessageBriefDTO[]>> GetBookingMessagesByClientId(int id)
        {
            try
            {
                var clientBookingMessages = await _bookingMessageRepository
                    .GetBookingMessagesByClientId(id);
                return Ok(_mapper.Map<BookingMessageBriefDTO[]>(clientBookingMessages));

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}