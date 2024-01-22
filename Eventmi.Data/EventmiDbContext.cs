namespace Eventmi.Data
{
	using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore;

	using Eventmi.Data.Models;
	public class EventmiDbContext : IdentityDbContext
    {
        public EventmiDbContext(DbContextOptions<EventmiDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
    }
}