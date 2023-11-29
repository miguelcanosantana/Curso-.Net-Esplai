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
                    //int jobId = recordsReader.GetInt32(recordsReader.GetOrdinal("job_id"));
                    //String jobName = recordsReader.GetString(recordsReader.GetOrdinal("job_title"));

                    //float? minSalary = null;
                    //float? maxSalary = null;

                    //if (!recordsReader.IsDBNull(recordsReader.GetOrdinal("min_salary")))
                    //    minSalary = (float)recordsReader.GetDecimal(recordsReader.GetOrdinal("min_salary"));

                    //if (!recordsReader.IsDBNull(recordsReader.GetOrdinal("max_salary")))
                    //    maxSalary = (float)recordsReader.GetDecimal(recordsReader.GetOrdinal("max_salary"));

                    //Job newJob = new Job(jobId, jobName, (float)minSalary, (float)maxSalary);
                    //jobs.Add(newJob);
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
