using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoC.GraphQL.Models
{
    public class ImperialStarDestroyer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        List<TieFighter> TieFighters { get; set; }
    }
}
