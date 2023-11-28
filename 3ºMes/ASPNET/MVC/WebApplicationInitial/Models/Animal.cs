using System.ComponentModel.DataAnnotations;

namespace WebApplicationInitial.Models
{
	public class Animal
	{
		[Required]
		[Range(0, 50, ErrorMessage = "The value for {0} must be between {1} and {2}")]
		public int id { get; set; }

		[Required]
		[Display(Name = "Animal")]
		[StringLength(15, ErrorMessage = "The name can't exceed 15 characters")]
		public String name { get; set; }
	}
}
