using System.ComponentModel.DataAnnotations;

namespace MovieTicketMVC.Models
{
	public abstract class PersonBase
	{
		[Key]
		public int Id { get; set; }

		[Required, Display(Name = "Full Name")]
		public string FullName { get; set; }
		public string Biography { get; set; }

		[Required, Display(Name = "Picture Url")]
		public string PictureUrl { get; set; }
	}
}
