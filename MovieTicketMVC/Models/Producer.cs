namespace MovieTicketMVC.Models
{
	public class Producer : PersonBase
	{
		// Movies
		public ICollection<Movie> CreatedMovies { get; set; }
	}
}
