using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicketMVC.Models.Data;

namespace MovieTicketMVC.Controllers
{
	public class MoviesController : Controller
	{
		private readonly ILogger<MoviesController> _logger;
		private readonly DatabaseContext _databaseContext;

		public MoviesController(ILogger<MoviesController> logger, DatabaseContext databaseContext)
		{
			_logger = logger;
			_databaseContext = databaseContext;
		}

		public async Task<IActionResult> Index()
		{
			var allMovies = await _databaseContext.Movies.Include(p => p.MovieTheater).OrderBy(p => p.Title).ToListAsync();
			return View(allMovies);
		}
	}
}
