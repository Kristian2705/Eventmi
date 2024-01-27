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

		public Task DeleteAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task EditAsync(EventViewModel model)
		{
			var eventToEdit = GetByName(model.Name);


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

		private async Task<EventViewModel> GetByName(string name)
		{
			var model = await context.Events.FirstOrDefaultAsync(e => e.Name.Equals(name));

			if(model == null)
			{
				throw new ArgumentNullException(nameof(model));
			}

			return new EventViewModel()
			{
				Name = model.Name,
				StartDate = model.StartDate.ToString("dd/MM/yyyy"),
				EndDate = model.EndDate.ToString("dd/MM/yyyy"),
				Place = model.Place,
				Category = model.Category
			};
		}
	}
}