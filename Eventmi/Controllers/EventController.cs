namespace Eventmi.Controllers
{
	using Eventmi.Services.Contracts;
	using Microsoft.AspNetCore.Mvc;
	public class EventController : Controller
	{
		private readonly IEventService eventService;
        public EventController(IEventService _eventService)
        {
            eventService = _eventService;
        }
        [HttpPost]
		public async Task<IActionResult> AddEventAsync()
		{
			return View();
		}
	}
}
