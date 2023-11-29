using WebApplicationInitial.Models;
using WebApplicationInitial.Services.Contract;

namespace WebApplicationInitial.Services.Implementation
{
	public class AnimalService : IAnimalService
	{
		public Task<List<Animal>> GetAnimals()
		{
			throw new NotImplementedException();
		}

		public Task InsertAnimal(Animal animal)
		{
			throw new NotImplementedException();
		}
	}
}
