using System.ComponentModel.DataAnnotations;

namespace MovieTicketMVC.Models
{
	public class Actor : PersonBase
	{
		// Movies
		public ICollection<Actor_Movie> Actors_Movies { get; set; }
	}
}
