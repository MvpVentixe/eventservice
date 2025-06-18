using System.ComponentModel.DataAnnotations;

namespace EventService.Entities
{
    public class EventEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public string Location { get; set; } = null!;

        [Required]
        public DateTime EventDateTime { get; set; }

        [Required]
        public int Price { get; set; }

        public string? ImageUrl { get; set; }

        [Required]
        public string Category { get; set; } = null!;


    }
}
