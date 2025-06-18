using EventService.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventService.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<EventEntity> Events { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EventEntity>().HasData(
                new EventEntity
                {
                    Id = Guid.Parse("a1b2c3d4-e5f6-4a7b-8c9d-1e2f3a4b5c6d"),
                    Title = "Summer Music Festival",
                    Description = "Experience the biggest outdoor music event of the year.",
                    Location = "Central Park, NY",
                    EventDateTime = new DateTime(2025, 07, 15, 18, 0, 0),
                    Price = 120,
                    Category = "Music",
                    ImageUrl = "https://images.unsplash.com/photo-1501238295340-c810d3c156d2?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTB8fHN1bW1lciUyMGZlc3RpdmFsfGVufDB8fDB8fHww"
                },
                new EventEntity
                {
                    Id = Guid.Parse("b7c8d9e0-f1a2-4b3c-9d8e-7f6a5b4c3d2e"),
                    Title = "Tech Expo 2025",
                    Description = "Explore the future of technology with global innovators.",
                    Location = "Silicon Valley, CA",
                    EventDateTime = new DateTime(2025, 09, 20, 10, 0, 0),
                    Price = 250,
                    Category = "Technology",
                    ImageUrl = "https://images.unsplash.com/photo-1655963858503-1db062739349?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTh8fHRlY2glMjBleHBvfGVufDB8fDB8fHww"
                },
                new EventEntity
                {
                    Id = Guid.Parse("c9d0e1f2-a3b4-4c5d-9e8f-7a6b5c4d3e2f"),
                    Title = "Art & Wine Night",
                    Description = "An elegant evening of painting and fine wines.",
                    Location = "Downtown LA, CA",
                    EventDateTime = new DateTime(2025, 08, 05, 19, 30, 0),
                    Price = 75,
                    Category = "Art",
                    ImageUrl = "https://plus.unsplash.com/premium_photo-1743043627539-7e9c5a87b789?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTN8fGFydCUyMHdpbmUlMjBuaWdodHxlbnwwfHwwfHx8MA%3D%3D"
                },
                new EventEntity
                {
                    Id = Guid.Parse("d1e2f3a4-b5c6-4d7e-8f9a-0b1c2d3e4f5a"),
                    Title = "Startup Pitch Night",
                    Description = "Watch upcoming startups pitch their ideas to investors.",
                    Location = "Seattle, WA",
                    EventDateTime = new DateTime(2025, 10, 12, 17, 0, 0),
                    Price = 40,
                    Category = "Business",
                    ImageUrl = "https://images.unsplash.com/photo-1559136555-9303baea8ebd?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8c3RhcnR1cHxlbnwwfHwwfHx8MA%3D%3D"
                },
                new EventEntity
                {
                    Id = Guid.Parse("e3f4a5b6-c7d8-4e9f-8a0b-1c2d3e4f5a6b"),
                    Title = "Marathon 10K Run",
                    Description = "Join the community in our annual fitness challenge.",
                    Location = "Boston, MA",
                    EventDateTime = new DateTime(2025, 06, 02, 07, 0, 0),
                    Price = 30,
                    Category = "Sports",
                    ImageUrl = "https://images.unsplash.com/photo-1452626038306-9aae5e071dd3?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8bWFyYXRob258ZW58MHx8MHx8fDA%3D"
                },
                new EventEntity
                {
                    Id = Guid.Parse("f5a6b7c8-d9e0-4f1a-8b2c-3d4e5f6a7b8c"),
                    Title = "Cooking Masterclass",
                    Description = "Learn gourmet recipes from a celebrity chef.",
                    Location = "Chicago, IL",
                    EventDateTime = new DateTime(2025, 11, 03, 15, 0, 0),
                    Price = 100,
                    Category = "Food",
                    ImageUrl = "https://images.unsplash.com/photo-1683624328172-88fb24625ec1?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8Y29va2luZyUyMGNsYXNzfGVufDB8fDB8fHww"
                },
                new EventEntity
                {
                    Id = Guid.Parse("a7b8c9d0-e1f2-4a3b-9c8d-7e6f5a4b3c2d"),
                    Title = "Photography Workshop",
                    Description = "Master camera techniques and visual storytelling.",
                    Location = "Denver, CO",
                    EventDateTime = new DateTime(2025, 09, 10, 14, 0, 0),
                    Price = 60,
                    Category = "Photography",
                    ImageUrl = "https://images.unsplash.com/photo-1486892539609-d5322f938c50?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8cGhvdG9ncmFwaHklMjB3b3Jrc2hvcHxlbnwwfHwwfHx8MA%3D%3D"
                },
                new EventEntity
                {
                    Id = Guid.Parse("b2c3d4e5-f6a7-4b8c-9d0e-1f2a3b4c5d6e"),
                    Title = "Indie Film Screening",
                    Description = "Watch and discuss short films from new directors.",
                    Location = "Brooklyn, NY",
                    EventDateTime = new DateTime(2025, 08, 22, 20, 0, 0),
                    Price = 20,
                    Category = "Film",
                    ImageUrl = "https://images.unsplash.com/photo-1627126053538-5eefab972223?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8N3x8aW5kaWUlMjB0aGVhdGVyfGVufDB8fDB8fHww"
                },
                new EventEntity
                {
                    Id = Guid.Parse("c4d5e6f7-a8b9-4c0d-9e1f-2a3b4c5d6e7f"),
                    Title = "Gaming LAN Party",
                    Description = "Bring your rig and game all night long.",
                    Location = "Austin, TX",
                    EventDateTime = new DateTime(2025, 12, 13, 18, 0, 0),
                    Price = 50,
                    Category = "Gaming",
                    ImageUrl = "https://images.unsplash.com/photo-1633545491399-54a16aa6a871?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8bGFufGVufDB8fDB8fHww"
                },
                new EventEntity
                {
                    Id = Guid.Parse("d6e7f8a9-b0c1-4d2e-9f3a-4b5c6d7e8f9a"),
                    Title = "Jazz Night Live",
                    Description = "Smooth jazz music with drinks and vibes.",
                    Location = "New Orleans, LA",
                    EventDateTime = new DateTime(2025, 07, 08, 21, 0, 0),
                    Price = 45,
                    Category = "Music",
                    ImageUrl = "https://images.unsplash.com/photo-1415201364774-f6f0bb35f28f?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8amF6enxlbnwwfHwwfHx8MA%3D%3D"
                }
            );
        }

    }
}
