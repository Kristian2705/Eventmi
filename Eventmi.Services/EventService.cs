using Eventmi.Data;
using Eventmi.Services.Contracts;
using Eventmi.Web.ViewModels.Event;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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

		}
	}
}