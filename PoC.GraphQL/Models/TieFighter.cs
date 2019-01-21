using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoC.GraphQL.Models
{
    public class TieFighter
    {
        public int Id { get; set; }
        public int ImperialStarDestroyerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        ImperialStarDestroyer ImperialStarDestroyer { get; set; }
    }
}
