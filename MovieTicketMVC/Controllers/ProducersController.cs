using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieTicketMVC.Data;

namespace MovieTicketMVC.Controllers
{
	public class ProducersController : Controller
	{
		private readonly ILogger<ProducersController> _logger;
		private readonly DatabaseContext _databaseContext;

		public ProducersController(ILogger<ProducersController> logger, DatabaseContext databaseContext)
		{
			_logger = logger;
			_databaseContext = databaseContext;
		}

		// Get /Producers
		public async Task<IActionResult> Index()
		{
			var allProducers = await _databaseContext.Producers.ToListAsync();
			return View(allProducers);
		}
	}
}
