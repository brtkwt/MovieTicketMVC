using Microsoft.EntityFrameworkCore;
using MovieTicketMVC.Models;

namespace MovieTicketMVC.Data
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
		{
			
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Setting primary keys
			modelBuilder.Entity<Actor_Movie>().HasKey(x => new
			{
				x.ActorId,
				x.MovieId
			});

			// Configurig relations
			modelBuilder.Entity<Actor_Movie>().HasOne(x => x.Actor).WithMany(
				x => x.Actors_Movies).HasForeignKey(x => x.ActorId);

			modelBuilder.Entity<Actor_Movie>().HasOne(x => x.Movie).WithMany(
				x => x.Actors_Movies).HasForeignKey(x => x.MovieId);

			base.OnModelCreating(modelBuilder);
		}

		// Setting database schema
		public DbSet<Actor> Actors { get; set; }
		public DbSet<Producer> Producers { get; set; }
		public DbSet<MovieTheater> MovieTheaters { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Actor_Movie> Actors_Movies { get; set; }
	}
}
