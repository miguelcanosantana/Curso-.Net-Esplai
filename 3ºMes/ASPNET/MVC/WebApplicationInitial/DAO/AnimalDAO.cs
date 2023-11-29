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

        public static void InsertAnimal(Animal animal)
        {
            try
            {
                SqlConnection connection = new SqlConnection(DB.connectionString);
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
        }
    }
}
