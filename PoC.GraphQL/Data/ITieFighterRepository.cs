using PoC.GraphQL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoC.GraphQL.Data
{
    public interface ITieFighterRepository
    {
        Task<List<TieFighter>> GetTieFightersAsync();
        Task<List<TieFighter>> GetTieFightersWithByImperialStarDestroyerIdAsync(int ImperialStarDestroyerId);
        Task<TieFighter> GetTieFighterAsync(int id);
    }
}
