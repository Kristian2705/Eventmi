﻿using Eventmi.Data;
using Eventmi.Data.Models;
using Eventmi.Services.Contracts;
using Eventmi.Web.ViewModels.Event;
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
			if (context.Events.Any(e => e.Id == model.Id))
			{
				throw new ArgumentException("This event already exists!");
			}
			Event data = new()
			{
				Name = model.Name,
				StartDate = model.StartDate/*DateTime.ParseExact(model.StartDate.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture)*/,
				EndDate = model.EndDate/*DateTime.ParseExact(model.EndDate.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture)*/,
				Place = model.Place,
				Category = model.Category,
			};
			await context.Events.AddAsync(data);
			await context.SaveChangesAsync();
		}
	}
}