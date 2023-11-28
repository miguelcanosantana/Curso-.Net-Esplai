namespace WebApplicationInitial.Models
{
	public class Animal
	{
		public int id { get; set; }
		public String name { get; set; }

		public Animal(int id, String name) {
			this.id = id;
			this.name = name;
		}
	}
}
