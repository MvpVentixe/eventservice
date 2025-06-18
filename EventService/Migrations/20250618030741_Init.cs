using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventService.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Category", "Description", "EventDateTime", "ImageUrl", "Location", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("a1b2c3d4-e5f6-4a7b-8c9d-1e2f3a4b5c6d"), "Music", "Experience the biggest outdoor music event of the year.", new DateTime(2025, 7, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1501238295340-c810d3c156d2?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTB8fHN1bW1lciUyMGZlc3RpdmFsfGVufDB8fDB8fHww", "Central Park, NY", 120, "Summer Music Festival" },
                    { new Guid("a7b8c9d0-e1f2-4a3b-9c8d-7e6f5a4b3c2d"), "Photography", "Master camera techniques and visual storytelling.", new DateTime(2025, 9, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1486892539609-d5322f938c50?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8cGhvdG9ncmFwaHklMjB3b3Jrc2hvcHxlbnwwfHwwfHx8MA%3D%3D", "Denver, CO", 60, "Photography Workshop" },
                    { new Guid("b2c3d4e5-f6a7-4b8c-9d0e-1f2a3b4c5d6e"), "Film", "Watch and discuss short films from new directors.", new DateTime(2025, 8, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1627126053538-5eefab972223?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8N3x8aW5kaWUlMjB0aGVhdGVyfGVufDB8fDB8fHww", "Brooklyn, NY", 20, "Indie Film Screening" },
                    { new Guid("b7c8d9e0-f1a2-4b3c-9d8e-7f6a5b4c3d2e"), "Technology", "Explore the future of technology with global innovators.", new DateTime(2025, 9, 20, 10, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1655963858503-1db062739349?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTh8fHRlY2glMjBleHBvfGVufDB8fDB8fHww", "Silicon Valley, CA", 250, "Tech Expo 2025" },
                    { new Guid("c4d5e6f7-a8b9-4c0d-9e1f-2a3b4c5d6e7f"), "Gaming", "Bring your rig and game all night long.", new DateTime(2025, 12, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1633545491399-54a16aa6a871?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8bGFufGVufDB8fDB8fHww", "Austin, TX", 50, "Gaming LAN Party" },
                    { new Guid("c9d0e1f2-a3b4-4c5d-9e8f-7a6b5c4d3e2f"), "Art", "An elegant evening of painting and fine wines.", new DateTime(2025, 8, 5, 19, 30, 0, 0, DateTimeKind.Unspecified), "https://plus.unsplash.com/premium_photo-1743043627539-7e9c5a87b789?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTN8fGFydCUyMHdpbmUlMjBuaWdodHxlbnwwfHwwfHx8MA%3D%3D", "Downtown LA, CA", 75, "Art & Wine Night" },
                    { new Guid("d1e2f3a4-b5c6-4d7e-8f9a-0b1c2d3e4f5a"), "Business", "Watch upcoming startups pitch their ideas to investors.", new DateTime(2025, 10, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1559136555-9303baea8ebd?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8c3RhcnR1cHxlbnwwfHwwfHx8MA%3D%3D", "Seattle, WA", 40, "Startup Pitch Night" },
                    { new Guid("d6e7f8a9-b0c1-4d2e-9f3a-4b5c6d7e8f9a"), "Music", "Smooth jazz music with drinks and vibes.", new DateTime(2025, 7, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1415201364774-f6f0bb35f28f?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8amF6enxlbnwwfHwwfHx8MA%3D%3D", "New Orleans, LA", 45, "Jazz Night Live" },
                    { new Guid("e3f4a5b6-c7d8-4e9f-8a0b-1c2d3e4f5a6b"), "Sports", "Join the community in our annual fitness challenge.", new DateTime(2025, 6, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1452626038306-9aae5e071dd3?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8bWFyYXRob258ZW58MHx8MHx8fDA%3D", "Boston, MA", 30, "Marathon 10K Run" },
                    { new Guid("f5a6b7c8-d9e0-4f1a-8b2c-3d4e5f6a7b8c"), "Food", "Learn gourmet recipes from a celebrity chef.", new DateTime(2025, 11, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), "https://images.unsplash.com/photo-1683624328172-88fb24625ec1?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8Y29va2luZyUyMGNsYXNzfGVufDB8fDB8fHww", "Chicago, IL", 100, "Cooking Masterclass" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
