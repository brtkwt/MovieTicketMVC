using System.ComponentModel.DataAnnotations;

namespace MovieTicketMVC.Models
{
	public class MovieTheater
	{
		public int Id { get; set; }

		[Display(Name = "Movie theater name")]
		public string Name { get; set; }
		public string Description { get; set; }

		[Display(Name = "Movie theater picture")]
		public string PictureUrl { get; set; }

		// Movies
		public ICollection<Movie> AvailableMovies { get; set; }
	}
}
