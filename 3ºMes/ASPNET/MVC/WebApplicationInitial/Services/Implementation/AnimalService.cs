using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Text;
using System.Text.Json.Serialization;
using WebApplicationInitial.Models;
using WebApplicationInitial.Services.Config;
using WebApplicationInitial.Services.Contract;

namespace WebApplicationInitial.Services.Implementation
{
	public class AnimalService : IAnimalService
	{
		private readonly ConnectionConfig connetion;
		private readonly HttpClient httpClient;

		public AnimalService(IOptions<ConnectionConfig> connetion)
		{
			this.connetion = connetion.Value;
			httpClient = new HttpClient();
			httpClient.BaseAddress = new Uri("https://localhost:7043/"); //Base url
		}


		public async Task<List<Animal>> GetAnimals()
		{
			List<Animal> animalsList = null;

			try
			{
				HttpResponseMessage response = await httpClient.GetAsync("GetAnimals");

				if (response.IsSuccessStatusCode)
					animalsList = await response.Content.ReadFromJsonAsync<List<Animal>>();
			}
			catch (Exception)
			{
			}

			return animalsList;
		}


        public async Task InsertAnimal(Animal animal)
        {
            string json = JsonConvert.SerializeObject(animal);
			StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
				HttpResponseMessage response = await httpClient.PostAsync("InsertAnimal", content);
            }
            catch (Exception)
            {
            }
        }

  //      public async Task InsertAnimal(Animal animal)
		//{
		//	try
		//	{
		//		SqlConnection connection = new SqlConnection(connetion.connectionString);
		//		connection.Open();

		//		string query = $"INSERT INTO Animal (NombreAnimal, Raza, RIdTipoAnimal, FechaNacimiento) VALUES (" +
		//		   "@name, @breed, @type, @date);";

		//		using (SqlCommand cmd = new SqlCommand(query, connection))
		//		{
		//			cmd.Parameters.AddWithValue("@name", animal.name);
		//			cmd.Parameters.AddWithValue("@breed", animal.breed);
		//			cmd.Parameters.AddWithValue("@type", animal.fkAnimalType);
		//			cmd.Parameters.AddWithValue("@date", animal.bornDate);

		//			await cmd.ExecuteNonQueryAsync();
		//		}

		//	}
		//	catch (Exception e)
		//	{
		//	}
		//}
	}
}
