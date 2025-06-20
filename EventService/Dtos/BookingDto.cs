using System.ComponentModel.DataAnnotations;

namespace EventService.Dtos
{
    public class BookingDto
    {

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Location { get; set; } = null!;

        [Required]
        public DateTime EventDateTime { get; set; }

    }
}
