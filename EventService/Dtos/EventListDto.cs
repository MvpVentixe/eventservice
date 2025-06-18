namespace EventService.Dtos
{
    public class EventListDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; } = null!;
        public DateTime EventDateTime { get; set; }
        public int Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? Category { get; set; } = null!;

    }
}
