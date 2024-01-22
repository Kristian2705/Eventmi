namespace Eventmi.Controllers
{
	using Microsoft.AspNetCore.Mvc;
	public class EventController : Controller
	{
		public IActionResult AddEvent()
		{
			return View();
		}
	}
}
