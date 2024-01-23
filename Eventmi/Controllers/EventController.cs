namespace Eventmi.Controllers
{
	using Eventmi.Services.Contracts;
    using Eventmi.Web.ViewModels.Event;
    using Microsoft.AspNetCore.Mvc;
	public class EventController : Controller
	{
		private readonly IEventService eventService;
        public EventController(IEventService _eventService)
        {
            eventService = _eventService;
        }

		/// <summary>
		/// The main Event view
		/// </summary>
		/// <returns></returns>
		public IActionResult Index()
		{
			return View();
		}

		/// <summary>
		/// Add Event view
		/// </summary>
		/// <returns></returns>
        [HttpGet]
        public IActionResult AddEvent()
        {
			return View();
        }

		/// <summary>
		/// The action of adding an event
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public async Task<IActionResult> AddEventAsync(EventViewModel model)
		{
			if(!ModelState.IsValid)
			{
				return RedirectToAction("AddEvent");
			}
			await eventService.AddAsync(model);
			return RedirectToAction("Index");
		}
	}
}
