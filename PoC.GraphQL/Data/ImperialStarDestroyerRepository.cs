using PoC.GraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoC.GraphQL.Data
{
    public class ImperialStarDestroyerRepository:IImperialStarDestroyerRepository
    {
        private List<ImperialStarDestroyer> _spaceships;

        public ImperialStarDestroyerRepository()
        {
            _spaceships = new List<ImperialStarDestroyer>{
                new ImperialStarDestroyer()
                {
                    Id = 1,
                    Name = "Imperial I-class Star Destroyer I"
                },
                new ImperialStarDestroyer()
                {
                    Id = 2,
                    Name = "Imperial I-class Star Destroyer II"
                }
            };
        }

        public Task<List<ImperialStarDestroyer>> GetImperialStarDestroyersAsync()
        {
            return Task.FromResult(_spaceships);
        }

        public Task<ImperialStarDestroyer> GetImperialStarDestroyerAsync(int id)
        {
            return Task.FromResult(_spaceships.FirstOrDefault(x => x.Id == id));
        }

   
    }
}
