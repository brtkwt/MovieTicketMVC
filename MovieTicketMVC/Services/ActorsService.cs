using Microsoft.EntityFrameworkCore;
using MovieTicketMVC.Controllers;
using MovieTicketMVC.Data;
using MovieTicketMVC.Models;
using MovieTicketMVC.Services.Interfaces;

namespace MovieTicketMVC.Services
{
	public class ActorsService : IActorsService
	{
		private readonly ILogger<ActorsController> _logger;
		private readonly DatabaseContext _databaseContext;
		public ActorsService(ILogger<ActorsController> logger, DatabaseContext databaseContext)
		{
			_logger = logger;
			_databaseContext = databaseContext;
		}

		public async Task<IEnumerable<Actor>> GetAllActorsAsync()
		{
			var allActors = await _databaseContext.Actors.ToListAsync();

			return allActors;
		}

		public async Task AddActorAsync(Actor actor)
		{
			throw new NotImplementedException();
		}

		public async Task DeleteActorAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<Actor> GetActorByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<Actor> UpdateActorAsync(int id, Actor updatedActor)
		{
			throw new NotImplementedException();
		}
	}
}
