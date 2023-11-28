using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationInitial.Models;

namespace WebApplicationInitial.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FirstView()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SubmitForm(String nameInput, int ageInput)
        {
            var retrievedName = nameInput;
            var retrievedAge = ageInput;

			//The view the page redirects to
			return View("FirstView");
		}
    }
}
