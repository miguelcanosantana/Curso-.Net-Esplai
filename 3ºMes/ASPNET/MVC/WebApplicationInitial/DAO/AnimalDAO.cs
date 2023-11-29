using System.Data;
using System.Data.SqlClient;
using WebApplicationInitial.Models;

namespace WebApplicationInitial.DAO
{
    static public class AnimalDAO
    {
        public static List<Animal> GetAnimals()
        {
            List<Animal> animalsList = new List<Animal>();

            try
            {
                SqlConnection connection = new SqlConnection(DB.connectionString);
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
    }
}
