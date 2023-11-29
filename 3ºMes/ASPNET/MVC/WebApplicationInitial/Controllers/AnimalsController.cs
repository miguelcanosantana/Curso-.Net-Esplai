using Microsoft.AspNetCore.Mvc;
using WebApplicationInitial.DAO;
using WebApplicationInitial.Models;

namespace WebApplicationInitial.Controllers
{
	public class AnimalsController : Controller
	{
		public IActionResult InsertAnimal()
		{
			return View();
		}

		public IActionResult Index()
		{
			//List<Animal> animalsList = new List<Animal>()
			//{
			//	new Animal() {id = 1, name = "Lizard"},
			//	new Animal() {id = 2, name = "Dog"},
			//	new Animal() {id = 3, name = "Cat"},
			//};

			List<Animal> animalsList = AnimalDAO.GetAnimals();

			Random rnd = new Random();
			int randomIndex = rnd.Next(0, animalsList.Count);


			ViewBag.LuckyAnimalMessage = "The "; //+ animalsList[randomIndex].name + " is your luck animal.";

			return View(animalsList);
		}

        [HttpPost]
		[ValidateAntiForgeryToken]
        public IActionResult InsertAnimal(Animal newAnimal)
        {
            return View(newAnimal);
        }
    }
}
