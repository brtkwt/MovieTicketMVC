using MovieTicketMVC.Models.Data.Enums;

namespace MovieTicketMVC.Models.Data
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
							PictureUrl = "http://test.jpeg"

						},
						new Producer()
						{
							FullName = "Producer 2",
							Biography = "Biography of the second producer",
							PictureUrl = "http://test.jpeg"
						},
						new Producer()
						{
							FullName = "Producer 3",
							Biography = "Biography of the third producer",
							PictureUrl = "http://test.jpeg"
						},
						new Producer()
						{
							FullName = "Producer 4",
							Biography = "Biography of the fourth producer",
							PictureUrl = "http://test.jpeg"
						},
						new Producer()
						{
							FullName = "Producer 5",
							Biography = "Biography of the fifth producer",
							PictureUrl = "http://test.jpeg"
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
							PictureUrl = "http://test.jpeg"
						},
						new MovieTheater()
						{
							Name = "MovieTheater 2",
							Description = "Description of the second movie theater",
							PictureUrl = "http://test.jpeg"
						},
						new MovieTheater()
						{
							Name = "MovieTheater 3",
							Description = "Description of the third movie theater",
							PictureUrl = "http://test.jpeg"
						},
						new MovieTheater()
						{
							Name = "MovieTheater 4",
							Description = "Description of the fourth movie theater",
							PictureUrl = "http://test.jpeg"
						},
						new MovieTheater()
						{
							Name = "MovieTheater 5",
							Description = "Description of the fifth movie theater",
							PictureUrl = "http://test.jpeg"
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
							Description = "A documentary exploring the origins, evolution, and diversity of life across our planet.",
							Price = 29.99,
							PictureUrl = "http://test.jpeg",
							StartDate = DateTime.Now.AddDays(-5),
							EndDate = DateTime.Now.AddDays(7),
							MovieTheaterId = 3,
							ProducerId = 3,
							Category = Category.Documentary
						},
						new Movie()
						{
							Title = "Steel Horizon",
							Description = "A former special forces soldier must stop a rogue group from using a satellite weapon to trigger global chaos.",
							Price = 34.99,
							PictureUrl = "http://test.jpeg",
							StartDate = DateTime.Now,
							EndDate = DateTime.Now.AddDays(4),
							MovieTheaterId = 1,
							ProducerId = 1,
							Category = Category.Action
						},
						new Movie()
						{
							Title = "Whispers in the Dark",
							Description = "A group of friends uncover a sinister presence after spending a night in an abandoned house.",
							Price = 17.50,
							PictureUrl = "http://test.jpeg",
							StartDate = DateTime.Now.AddDays(1),
							EndDate = DateTime.Now.AddDays(6),
							MovieTheaterId = 4,
							ProducerId = 4,
							Category = Category.Horror
						},
						new Movie()
						{
							Title = "Driven to the Limit",
							Description = "A documentary following the passion, technology, and risks behind professional racing.",
							Price = 42.00,
							PictureUrl = "http://test.jpeg",
							StartDate = DateTime.Now.AddDays(-15),
							EndDate = DateTime.Now.AddDays(-11),
							MovieTheaterId = 1,
							ProducerId = 2,
							Category = Category.Documentary
						},
						new Movie()
						{
							Title = "Wild Footsteps",
							Description = "A relaxing animated journey following the daily lives and hidden stories of animals in the wild.",
							Price = 37.60,
							PictureUrl = "http://test.jpeg",
							StartDate = DateTime.Now.AddDays(-8),
							EndDate = DateTime.Now.AddDays(-1),
							MovieTheaterId = 1,
							ProducerId = 3,
							Category = Category.Cartoon
						},
						new Movie()
						{
							Title = "Hearts in Bloom",
							Description = "Two strangers meet by chance and navigate love, heartbreak, and second chances in a bustling city.",
							Price = 26.99,
							PictureUrl = "http://test.jpeg",
							StartDate = DateTime.Now.AddDays(4),
							EndDate = DateTime.Now.AddDays(5),
							MovieTheaterId = 1,
							ProducerId = 5,
							Category = Category.Romance
						},
						new Movie()
						{
							Title = "Late Again!",
							Description = "A chronically late man tries to turn his life around, but everything that can go wrong… does.",
							Price = 39.99,
							PictureUrl = "http://test.jpeg",
							StartDate = DateTime.Now.AddDays(-4),
							EndDate = DateTime.Now,
							MovieTheaterId = 1,
							ProducerId = 4,
							Category = Category.Comedy
						},
						new Movie()
						{
							Title = "Quantum Drift",
							Description = "A scientist discovers a portal to alternate realities and must fix the timeline before it collapses.",
							Price = 17.00,
							PictureUrl = "http://test.jpeg",
							StartDate = DateTime.Now.AddDays(-1),
							EndDate = DateTime.Now.AddDays(1),
							MovieTheaterId = 2,
							ProducerId = 2,
							Category = Category.SciFi
						},
						new Movie()
						{
							Title = "Dust and Justice",
							Description = "A lone sheriff defends a frontier town from outlaws while confronting his own troubled past.",
							Price = 24.99,
							PictureUrl = "http://test.jpeg",
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
