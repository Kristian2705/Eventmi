using Eventmi.Web.ViewModels.Event;
using Microsoft.EntityFrameworkCore;

namespace Eventmi.Services.Contracts
{
    public interface IEventService
	{
		Task AddAsync(EventViewModel model);

		Task<IEnumerable<EventViewModel>> ViewAll();

		Task EditAsync(EventViewModel model);

		Task DeleteAsync(int id);
	}
}
