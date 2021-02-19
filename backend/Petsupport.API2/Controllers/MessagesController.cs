using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Petsupport.API2.Dtos.InDtos;
using Petsupport.API2.Dtos.OutDtos;
using PetSupport.Core.Entities;
using PetSupport.Core.Interfaces;

namespace Petsupport.API2.Controllers
{
    [ApiController]
    [Route("api/clients/{clientId}/messages")]
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
        public async Task<ActionResult<BookingMessageBriefDTO[]>> GetBookingMessagesByClientId(int clientId)
        {
            try
            {
                var clientBookingMessages = await _bookingMessageRepository
                    .GetBookingMessagesByClientIdAsync(clientId);
                return Ok(_mapper.Map<BookingMessageBriefDTO[]>(clientBookingMessages));

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        
        [HttpGet ("{messageId:int}", Name = "GetBookingMessageById")]
        public async Task<ActionResult<BookingMessageFullDTO>> GetBookingMessageById(int messageId, int clientId)
        {
            try
            {
                var bookingMessage = await _bookingMessageRepository
                    .GetBookingMessageByClientIdAsync(clientId, messageId);
                return Ok(_mapper.Map<BookingMessageFullDTO>(bookingMessage));

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public async Task<ActionResult<BookingMessageBriefDTO>> CreateBookingMessage(
            [FromBody] CreateBookingMessageDTO createBookingMessageDto)
        {
            try
            {
                if (createBookingMessageDto == null)
                {
                    return BadRequest("Booking message is null");
                }
                
                var bookingMessageEntity = _mapper.Map<BookingMessage>(createBookingMessageDto);
                _bookingMessageRepository.Add(bookingMessageEntity);
                await _bookingMessageRepository.SaveChangesAsync();

                var bookingMessageToReturn = _mapper.Map<BookingMessageFullDTO>(bookingMessageEntity);

                return CreatedAtRoute("GetBookingMessageById",
                    new {messageId = bookingMessageEntity.Id, clientId = bookingMessageEntity.ClientId},
                    bookingMessageToReturn);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}