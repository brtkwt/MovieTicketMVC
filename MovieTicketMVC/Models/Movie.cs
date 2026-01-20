using MovieTicketMVC.Models.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTicketMVC.Models
{
	public class Movie
	{
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public Category Category { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public double Price { get; set; }

		[Display(Name = "Picture")]
		public string PictureUrl { get; set; }

		// MovieTheater
		[ForeignKey("MovieTheaterId")]
		public int MovieTheaterId { get; set; }
		public MovieTheater MovieTheater { get; set; }

		// Producer
		[ForeignKey("ProducerId")]
		public int ProducerId { get; set; }
		public Producer Producer { get; set; }

		// Actors
		public ICollection<Actor_Movie> Actors_Movies { get; set; }
	}
}
