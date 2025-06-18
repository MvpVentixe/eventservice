using EventService.Data;
using EventService.Dtos;
using EventService.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventService.Services
{
    public class EventServiceHandler
    {
        private readonly DataContext _context;
        private readonly DbSet<EventEntity> _dbSet;
        public EventServiceHandler(DataContext context)
        {
            _context = context;
            _dbSet = _context.Set<EventEntity>();
        }



        public async Task<IEnumerable<EventListDto>> GetAllEventsAsync()
        {
            return await _dbSet.Select(e => new EventListDto 
            {
                Id = e.Id,
                Title = e.Title,
                EventDateTime = e.EventDateTime,
                Price = e.Price,
                ImageUrl = e.ImageUrl,
                Category = e.Category
            }).ToListAsync();
        }

        public async Task<EventEntity?> GetEventByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<int> GetEventCountAsync()
        {
            return await _dbSet.CountAsync();
        }

    }
}


