using Microsoft.Extensions.Options;
using WebApplicationInitial.Models;
using WebApplicationInitial.Services.Config;
using WebApplicationInitial.Services.Contract;

namespace WebApplicationInitial.Services.Implementation
{
	public class AnimalService : IAnimalService
	{
		private readonly ConnectionConfig connetion;

		public AnimalService(IOptions<ConnectionConfig> connetion)
		{
			this.connetion = connetion.Value;
		}


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
