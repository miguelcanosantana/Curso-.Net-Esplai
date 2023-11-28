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

			Random rnd = new Random();
			int randomIndex = rnd.Next(0, animalsList.Count);


			ViewBag.LuckyAnimalMessage = "The " + animalsList[randomIndex].name + " is your luck animal.";

			return View(animalsList);
		}

        [HttpPost]
		[ValidateAntiForgeryToken]
        public IActionResult CreateAnimal(Animal newAnimal)
        {
            return View(newAnimal);
        }
    }
}
