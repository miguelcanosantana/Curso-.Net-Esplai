using Microsoft.Extensions.Options;
using System.Data.SqlClient;
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


		public async Task<List<Animal>> GetAnimals()
		{
			List<Animal> animalsList = new List<Animal>();

			try
			{
				SqlConnection connection = new SqlConnection(connetion.connectionString);
				connection.Open();

				string query = "SELECT * FROM Animal";
				SqlCommand cmd = new SqlCommand(query, connection);

				SqlDataReader reader = await cmd.ExecuteReaderAsync();

				while (await reader.ReadAsync())
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
			catch (Exception fail)
			{
			}

			return animalsList;
		}

		public async Task InsertAnimal(Animal animal)
		{
			try
			{
				SqlConnection connection = new SqlConnection(connetion.connectionString);
				connection.Open();

				string query = $"INSERT INTO Animal (NombreAnimal, Raza, RIdTipoAnimal, FechaNacimiento) VALUES (" +
				   "@name, @breed, @type, @date);";

				using (SqlCommand cmd = new SqlCommand(query, connection))
				{
					cmd.Parameters.AddWithValue("@name", animal.name);
					cmd.Parameters.AddWithValue("@breed", animal.breed);
					cmd.Parameters.AddWithValue("@type", animal.fkAnimalType);
					cmd.Parameters.AddWithValue("@date", animal.bornDate);

					await cmd.ExecuteNonQueryAsync();
				}

			}
			catch (Exception e)
			{
			}
		}
	}
}
