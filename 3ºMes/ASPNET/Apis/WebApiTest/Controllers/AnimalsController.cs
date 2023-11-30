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
			SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("connectionString"));

			try
			{
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

			connection.Close();

			return animalsList;
		}


		[HttpGet]
		[Route("InsertAnimal")]
		public void InsertAnimal(Animal animal)
		{
			SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("connectionString"));

			try
			{
				connection.Open();

				string query = $"INSERT INTO Animal (NombreAnimal, Raza, RIdTipoAnimal, FechaNacimiento) VALUES (" +
				   "@name, @breed, @type, @date);";

				using (SqlCommand cmd = new SqlCommand(query, connection))
				{
					cmd.Parameters.AddWithValue("@name", animal.name);
					cmd.Parameters.AddWithValue("@breed", animal.breed);
					cmd.Parameters.AddWithValue("@type", animal.fkAnimalType);
					cmd.Parameters.AddWithValue("@date", animal.bornDate);

					cmd.ExecuteNonQuery();
				}

			}
			catch (Exception e)
			{
			}

			connection.Close();
		}
	}
}
