using MovieTicketMVC.Models;
using MovieTicketMVC.Models.Enums;

namespace MovieTicketMVC.Data
{
	public class DbSeeder
	{
		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<DatabaseContext>();

				// Database exists check
				context.Database.EnsureCreated();

				// Seeding if tables empty
				if (!context.Actors.Any())
				{
					context.Actors.AddRange(new List<Actor>()
					{
						new Actor()
						{
							FullName = "Actor 1",
							Biography = "Biography of the first actor",
							PictureUrl = "/images/actors/actor1.jpg"

						},
						new Actor()
						{
							FullName = "Actor 2",
							Biography = "Biography of the second actor",
							PictureUrl = "/images/actors/actor2.png"
						},
						new Actor()
						{
							FullName = "Actor 3",
							Biography = "Biography of the third actor",
							PictureUrl = "/images/actors/actor3.png"
						},
						new Actor()
						{
							FullName = "Actor 4",
							Biography = "Biography of the fourth actor",
							PictureUrl = "/images/actors/actor4.png"
						},
						new Actor()
						{
							FullName = "Actor 5",
							Biography = "Biography of the fifth actor",
							PictureUrl = "/images/actors/actor5.png"
						}
					});
					context.SaveChanges();
				}
				if (!context.Producers.Any())
				{
					context.Producers.AddRange(new List<Producer>()
					{
						new Producer()
						{
							FullName = "Producer 1",
							Biography = "Biography of the first producer",
							PictureUrl = "/images/producers/producer1.png"

						},
						new Producer()
						{
							FullName = "Producer 2",
							Biography = "Biography of the second producer",
							PictureUrl = "/images/producers/producer2.png"
						},
						new Producer()
						{
							FullName = "Producer 3",
							Biography = "Biography of the third producer",
							PictureUrl = "/images/producers/producer3.png"
						},
						new Producer()
						{
							FullName = "Producer 4",
							Biography = "Biography of the fourth producer",
							PictureUrl = "/images/producers/producer4.png"
						},
						new Producer()
						{
							FullName = "Producer 5",
							Biography = "Biography of the fifth producer",
							PictureUrl = "/images/producers/producer5.png"
						}
					});
					context.SaveChanges();
				}
				if (!context.MovieTheaters.Any())
				{
					context.MovieTheaters.AddRange(new List<MovieTheater>()
					{
						new MovieTheater()
						{
							Name = "MovieTheater 1",
							Description = "Description of the first movie theater",
							PictureUrl = "/images/movie-theaters/movie-theater1.png"
						},
						new MovieTheater()
						{
							Name = "MovieTheater 2",
							Description = "Description of the second movie theater",
							PictureUrl = "/images/movie-theaters/movie-theater2.jpeg"
						},
						new MovieTheater()
						{
							Name = "MovieTheater 3",
							Description = "Description of the third movie theater",
							PictureUrl = "/images/movie-theaters/movie-theater3.png"
						},
						new MovieTheater()
						{
							Name = "MovieTheater 4",
							Description = "Description of the fourth movie theater",
							PictureUrl = "/images/movie-theaters/movie-theater4.png"
						},
						new MovieTheater()
						{
							Name = "MovieTheater 5",
							Description = "Description of the fifth movie theater",
							PictureUrl = "/images/movie-theaters/movie-theater5.png"
						},
					});
					context.SaveChanges();
				}
				if (!context.Movies.Any())
				{
					context.Movies.AddRange(new List<Movie>()
					{
						new Movie()
						{
							Title = "Life on earth",
							Description = "This is Life on earth movie description.",
							Price = 29.99,
							PictureUrl = "/images/movies/movie1.png",
							StartDate = DateTime.Now.AddDays(-5),
							EndDate = DateTime.Now.AddDays(7),
							MovieTheaterId = 3,
							ProducerId = 3,
							Category = Category.Documentary
						},
						new Movie()
						{
							Title = "Steel Horizon",
							Description = "This is Steel Horizon movie description.",
							Price = 34.99,
							PictureUrl = "/images/movies/movie2.png",
							StartDate = DateTime.Now,
							EndDate = DateTime.Now.AddDays(4),
							MovieTheaterId = 1,
							ProducerId = 1,
							Category = Category.Action
						},
						new Movie()
						{
							Title = "Whispers in the Dark",
							Description = "This is Whispers in the Dark movie description.",
							Price = 17.50,
							PictureUrl = "/images/movies/movie3.png",
							StartDate = DateTime.Now.AddDays(1),
							EndDate = DateTime.Now.AddDays(6),
							MovieTheaterId = 4,
							ProducerId = 4,
							Category = Category.Horror
						},
						new Movie()
						{
							Title = "Driven to the Limit",
							Description = "This is Driven to the Limit movie description.",
							Price = 42.00,
							PictureUrl = "/images/movies/movie4.png",
							StartDate = DateTime.Now.AddDays(-15),
							EndDate = DateTime.Now.AddDays(-11),
							MovieTheaterId = 1,
							ProducerId = 2,
							Category = Category.Documentary
						},
						new Movie()
						{
							Title = "Wild Footsteps",
							Description = "This is Wild Footsteps movie description.",
							Price = 37.60,
							PictureUrl = "/images/movies/movie5.png",
							StartDate = DateTime.Now.AddDays(-8),
							EndDate = DateTime.Now.AddDays(-1),
							MovieTheaterId = 1,
							ProducerId = 3,
							Category = Category.Cartoon
						},
						new Movie()
						{
							Title = "Hearts in Bloom",
							Description = "This is Hearts in Bloom movie description.",
							Price = 26.99,
							PictureUrl = "/images/movies/movie6.png",
							StartDate = DateTime.Now.AddDays(4),
							EndDate = DateTime.Now.AddDays(5),
							MovieTheaterId = 1,
							ProducerId = 5,
							Category = Category.Romance
						},
						new Movie()
						{
							Title = "Late Again!",
							Description = "This is Late Again! movie description.",
							Price = 39.99,
							PictureUrl = "/images/movies/movie7.png",
							StartDate = DateTime.Now.AddDays(-4),
							EndDate = DateTime.Now,
							MovieTheaterId = 1,
							ProducerId = 4,
							Category = Category.Comedy
						},
						new Movie()
						{
							Title = "Quantum Drift",
							Description = "This is Quantum Drift movie description.",
							Price = 17.00,
							PictureUrl = "/images/movies/movie8.png",
							StartDate = DateTime.Now.AddDays(-1),
							EndDate = DateTime.Now.AddDays(1),
							MovieTheaterId = 2,
							ProducerId = 2,
							Category = Category.SciFi
						},
						new Movie()
						{
							Title = "Dust and Justice",
							Description = "This is Dust and Justice movie description.",
							Price = 24.99,
							PictureUrl = "/images/movies/movie9.png",
							StartDate = DateTime.Now.AddDays(-15),
							EndDate = DateTime.Now.AddDays(2),
							MovieTheaterId = 3,
							ProducerId = 1,
							Category = Category.Western
						}
					});
					context.SaveChanges();
				}
				if (!context.Actors_Movies.Any())
				{
					context.Actors_Movies.AddRange(new List<Actor_Movie>()
					{
						new Actor_Movie() { ActorId = 2, MovieId = 1 },
						new Actor_Movie() { ActorId = 5, MovieId = 1 },
						new Actor_Movie() { ActorId = 3, MovieId = 2 },
						new Actor_Movie() { ActorId = 1, MovieId = 2 },
						new Actor_Movie() { ActorId = 4, MovieId = 3 },
						new Actor_Movie() { ActorId = 1, MovieId = 3 },
						new Actor_Movie() { ActorId = 5, MovieId = 3 },
						new Actor_Movie() { ActorId = 3, MovieId = 4 },
						new Actor_Movie() { ActorId = 2, MovieId = 4 },
						new Actor_Movie() { ActorId = 5, MovieId = 4 },
						new Actor_Movie() { ActorId = 1, MovieId = 5 },
						new Actor_Movie() { ActorId = 2, MovieId = 5 },
						new Actor_Movie() { ActorId = 4, MovieId = 5 },
						new Actor_Movie() { ActorId = 3, MovieId = 5 },
						new Actor_Movie() { ActorId = 5, MovieId = 6 },
						new Actor_Movie() { ActorId = 1, MovieId = 6 },
						new Actor_Movie() { ActorId = 4, MovieId = 6 },
					});
					context.SaveChanges();
				}
			}
		}
	}
}
