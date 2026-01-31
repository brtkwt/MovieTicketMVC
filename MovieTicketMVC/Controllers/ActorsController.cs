using Microsoft.AspNetCore.Mvc;
using MovieTicketMVC.Services.Interfaces;

namespace MovieTicketMVC.Controllers
{
	public class ActorsController : Controller
	{
		private readonly IActorsService _actorsService;
		private readonly ILogger<ActorsController> _logger;

		public ActorsController(IActorsService actorsService, ILogger<ActorsController> logger)
		{
			_actorsService = actorsService;
			_logger = logger;
		}

		// Get /Actors
		public async Task<IActionResult> Index()
		{
			var data = await _actorsService.GetAllActorsAsync();

			return View(data);
		}

		// Get /Actors/Create
		public async Task<IActionResult> Create()
		{
			return View();
		}
	}
}
