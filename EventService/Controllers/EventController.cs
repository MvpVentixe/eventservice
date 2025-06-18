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

        [HttpGet("{id}")]
        public async Task<ActionResult<EventEntity>> GetEventById(Guid id)
        {
            var eventEntity = await _eventService.GetEventByIdAsync(id);
            if (eventEntity == null)
            {
                return NotFound();
            }
            return Ok(eventEntity);
        }

        [HttpGet("count")]
        public async Task<ActionResult<int>> GetEventCount()
        {
            var count = await _eventService.GetEventCountAsync();
            Console.WriteLine($"📦 Total events in DB: {count}");
            return Ok(count);
        }

    }
}
