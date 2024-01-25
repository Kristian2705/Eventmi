using Eventmi.Data;
using Eventmi.Data.Models;
using Eventmi.Data.Models.Enums;
using Eventmi.Services.Contracts;
using Eventmi.Web.ViewModels.Event;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Globalization;

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
			Event data = new()
			{
				Name = model.Name,
				StartDate = DateTime.ParseExact(model.StartDate.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture),
				EndDate = DateTime.ParseExact(model.EndDate.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture),
				Place = model.Place,
				Category = model.Category,
			};
			await context.Events.AddAsync(data);
			await context.SaveChangesAsync();
		}

		public async Task<IEnumerable<EventViewModel>> ViewAll()
		{
			var models = await context.Events
				.AsNoTracking()
				.Select(e => new EventViewModel()
				{
					Name = e.Name,
					StartDate = e.StartDate.ToString("dd/MM/yyyy"),
					EndDate = e.EndDate.ToString("dd/MM/yyyy"),
					Place = e.Place,
					Category = e.Category
				})
				.ToListAsync();

			return models;
		}
	}
}