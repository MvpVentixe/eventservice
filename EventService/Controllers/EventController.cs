using EventService.Dtos;
using EventService.Entities;
using EventService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController(EventServiceHandler eventService) : ControllerBase
    {
        private readonly EventServiceHandler _eventService = eventService;

        [HttpGet("allevents")]
        public async Task<ActionResult<IEnumerable<EventListDto>>> GetAllEvents()
        {
            try
            {
                var events = await _eventService.GetAllEventsAsync();
                return Ok(events);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Server error: {ex.Message}");
            }
        }

        [HttpGet("{eventId}")]
        public async Task<ActionResult<EventEntity>> GetEventById(Guid eventId)
        {
            var eventEntity = await _eventService.GetEventByIdAsync(eventId);
            if (eventEntity == null)
            {
                return NotFound();
            }
            return Ok(eventEntity);
        }



        [HttpGet("booking/{eventId}")]
        public async Task<ActionResult<BookingDto>> GetEventInfoToBooking(Guid eventId)
        {
            try
            {
                var bookingInfo = await _eventService.GetEventInfoToBookingAsync(eventId);
                return Ok(bookingInfo);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Event not found");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Server error: {ex.Message}");
            }
        }

    }
}
