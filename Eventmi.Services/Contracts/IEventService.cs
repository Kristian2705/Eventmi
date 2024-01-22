using Eventmi.Web.ViewModels.Event;

namespace Eventmi.Services.Contracts
{
    public interface IEventService
	{
		Task AddAsync(EventViewModel model);
	}
}
