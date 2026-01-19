using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTicketMVC.Models.Data;

namespace MovieTicketMVC.Controllers
{
	public class ActorsController : Controller
	{
		private readonly ILogger<ActorsController> _logger;
		private readonly DatabaseContext _databaseContext;

		public ActorsController(ILogger<ActorsController> logger, DatabaseContext databaseContext)
		{
			_logger = logger;
			_databaseContext = databaseContext;
		}

		public async Task<IActionResult> Index()
		{
			var allActors = await _databaseContext.Actors.ToListAsync();
			return View();
		}
	}
}
