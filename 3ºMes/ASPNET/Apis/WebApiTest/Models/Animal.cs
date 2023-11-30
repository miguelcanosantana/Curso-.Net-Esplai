using System.ComponentModel.DataAnnotations;

namespace WebApiTest.Models
{
	public class Animal
	{
		public int id { get; set; }
		public string name { get; set; }
		public string breed { get; set; }
		public int? fkAnimalType { get; set; }
		public DateTime bornDate { get; set; }
	}

}
