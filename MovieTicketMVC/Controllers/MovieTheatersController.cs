using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicketMVC.Models.Data;

namespace MovieTicketMVC.Controllers
{
	[Route("movie-theaters")]
	public class MovieTheatersController : Controller
	{
		private readonly ILogger<MovieTheatersController> _logger;
		private readonly DatabaseContext _databaseContext;

		public MovieTheatersController(ILogger<MovieTheatersController> logger, DatabaseContext databaseContext)
		{
			_logger = logger;
			_databaseContext = databaseContext;
		}

		// Get /MovieTheaters
		public async Task<IActionResult> Index()
		{
			var allMovieTheaters = await _databaseContext.MovieTheaters.ToListAsync();
			return View(allMovieTheaters);
		}
	}
}
