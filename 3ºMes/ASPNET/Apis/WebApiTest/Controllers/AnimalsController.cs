using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
	[ApiController]
	public class AnimalsController : ControllerBase
	{
		private readonly IConfiguration _configuration;

		public AnimalsController(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		[HttpGet]
		[Route("GetAnimals")]
		public List<Animal> GetAnimals()
		{
			List<Animal> animalsList = new List<Animal>();

			try
			{
				SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("connectionString"));
				connection.Open();

				string query = "SELECT * FROM Animal";
				SqlCommand cmd = new SqlCommand(query, connection);

				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					Animal animal = new Animal();
					animal.id = Convert.ToInt32(reader["IdAnimal"]);
					animal.name = reader["NombreAnimal"].ToString();
					animal.breed = reader["Raza"].ToString();
					animal.fkAnimalType = Convert.ToInt32(reader["RIdTipoAnimal"]);
					animal.bornDate = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento"));
					animalsList.Add(animal);
				}

				reader.Close();
			}
			catch (Exception)
			{
			}

			return animalsList;
		}
	}
}
