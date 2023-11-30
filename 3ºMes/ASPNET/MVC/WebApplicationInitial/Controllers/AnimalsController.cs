using Microsoft.AspNetCore.Mvc;
using WebApplicationInitial.DAO;
using WebApplicationInitial.Models;
using WebApplicationInitial.Services.Contract;

namespace WebApplicationInitial.Controllers
{
	public class AnimalsController : Controller
	{

		private readonly IAnimalService animalService;


		public AnimalsController(IAnimalService animalService)
		{
			this.animalService = animalService;
		}

		public IActionResult InsertAnimal()
		{
			return View();
		}

		public async Task<IActionResult> Index()
		{
			List<Animal> animalsList = await animalService.GetAnimals();

			if (animalsList == null)
			{
				ViewBag.Error = "Could not get all the animals...";
				return View();
			}

			Random rnd = new Random();
			int randomIndex = rnd.Next(0, animalsList.Count);

			ViewBag.LuckyAnimalMessage = "The " + animalsList[randomIndex].name + " is your luck animal.";

			return View(animalsList);
		}

        [HttpPost]
		[ValidateAntiForgeryToken]
        public IActionResult InsertAnimal(Animal newAnimal)
        {
			animalService.InsertAnimal(newAnimal);
            return View(newAnimal);
        }
    }
}
