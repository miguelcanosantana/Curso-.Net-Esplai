using Microsoft.AspNetCore.Mvc;

namespace WebApplicationInitial.Controllers
{
	public class AnimalsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
