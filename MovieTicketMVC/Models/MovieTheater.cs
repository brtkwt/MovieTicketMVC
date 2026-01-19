using System.ComponentModel.DataAnnotations;

namespace MovieTicketMVC.Models
{
	public class MovieTheater
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string PictureUrl { get; set; }

		// Movies
		public ICollection<Movie> AvailableMovies { get; set; }
	}
}
