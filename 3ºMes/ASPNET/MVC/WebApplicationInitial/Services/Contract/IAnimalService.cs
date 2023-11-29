using WebApplicationInitial.Models;

namespace WebApplicationInitial.Services.Contract
{
	public interface IAnimalService
	{
		Task<List<Animal>> GetAnimals();
		Task InsertAnimal(Animal animal);
	}
}
