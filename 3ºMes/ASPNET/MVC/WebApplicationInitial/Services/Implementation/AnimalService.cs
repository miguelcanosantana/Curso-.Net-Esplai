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
			catch (Exception fail)
			{
			}

			return animalsList;
		}

		public Task InsertAnimal(Animal animal)
		{
			throw new NotImplementedException();
		}
	}
}
