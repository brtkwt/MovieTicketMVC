using MovieTicketMVC.Models;

namespace MovieTicketMVC.Services.Interfaces
{
	public interface IActorsService
	{
		Task<IEnumerable<Actor>> GetAllActorsAsync();
		Task<Actor> GetActorByIdAsync(int id);
		Task AddActorAsync(Actor actor);
		Task<Actor> UpdateActorAsync(int id, Actor updatedActor);
		Task DeleteActorAsync(int id);
	}
}
