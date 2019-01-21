using PoC.GraphQL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoC.GraphQL.Data
{
    public class TieFighterRepository : ITieFighterRepository
    {
        private List<TieFighter> _TieFighters;

        public TieFighterRepository()
        {
            _TieFighters = new List<TieFighter>{
                new TieFighter()
                {
                    Id = 1,
                    ImperialStarDestroyerId = 1,
                    Name = "Tie Fighter I",
                    Description = "Nave espacial de guerra rápida e ágil,tamanho small ",
                    Price = 5000
                },
                new TieFighter()
                {
                    Id = 2,
                    ImperialStarDestroyerId = 1,
                    Name = "Tie Fighter II",
                    Description = "Nave espacial de guerra rápida e ágil,tamanho medium ",
                    Price = 20000
                }
            };
        }

        public Task<TieFighter> GetTieFighterAsync(int id)
        {
            return Task.FromResult(_TieFighters.FirstOrDefault(x => x.Id == id));
        }

        public Task<List<TieFighter>> GetTieFightersAsync()
        {
            return Task.FromResult(_TieFighters);
        }

        public Task<List<TieFighter>> GetTieFightersWithByImperialStarDestroyerIdAsync(int ImperialStarDestroyerId)
        {
            return Task.FromResult(_TieFighters.Where(x => x.ImperialStarDestroyerId == ImperialStarDestroyerId).ToList());
        }
    }
}