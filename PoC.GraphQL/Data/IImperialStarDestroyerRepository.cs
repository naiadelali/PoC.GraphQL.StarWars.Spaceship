using PoC.GraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoC.GraphQL.Data
{
    public interface IImperialStarDestroyerRepository
    {
        Task<List<ImperialStarDestroyer>> GetImperialStarDestroyersAsync();
        Task<ImperialStarDestroyer> GetImperialStarDestroyerAsync(int id);
    }
}
