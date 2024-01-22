using Eventmi.Data;
using Eventmi.Data.Models;
using Eventmi.Services.Contracts;
using Eventmi.Web.ViewModels.Event;

namespace Eventmi.Services
{
	public class EventServie : IEventService
	{
		private readonly EventmiDbContext context;
		public EventServie(EventmiDbContext _context)
		{
			context = _context;
		}
		public async Task AddAsync(EventViewModel model)
		{
			if (context.Events.Any(e => e.Id == model.Id))
			{
				throw new ArgumentException();
			}
			Event data = new()
			{
				Id = model.Id,
				Name = model.Name,
				Category = model.Category,
				StartDate = model.StartDate,
				EndDate = model.EndDate,
				Place = model.Place
			};
			await context.Events.AddAsync(data);
			await context.SaveChangesAsync();
		}
	}
}