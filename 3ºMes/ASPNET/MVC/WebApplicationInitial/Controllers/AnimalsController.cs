using Microsoft.AspNetCore.Mvc;
using WebApplicationInitial.Models;

namespace WebApplicationInitial.Controllers
{
	public class AnimalsController : Controller
	{
		public IActionResult Index()
		{
			List<Animal> animalsList = new List<Animal>()
			{
				new Animal(1, "Lizard"),
				new Animal(2, "Dog"),
				new Animal(3, "Cat")
			};

			return View(animalsList);
		}
	}
}
