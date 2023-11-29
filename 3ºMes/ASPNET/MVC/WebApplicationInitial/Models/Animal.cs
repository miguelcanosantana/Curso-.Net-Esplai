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
		[StringLength(50, ErrorMessage = "The name can't exceed 50 characters")]
		public string name { get; set; }

        [Display(Name = "Breed")]
        [StringLength(50, ErrorMessage = "The name can't exceed 50 characters")]
        public string breed { get; set; }

        public int? fkAnimalType { get; set; }

		[Required]
        [Display(Name = "Date")]
        public DateTime bornDate { get; set; }
    }
}
