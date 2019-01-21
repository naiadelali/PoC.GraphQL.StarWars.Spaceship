using GraphQL.Types;
using PoC.GraphQL.Data;
using PoC.GraphQL.Models;
using System.Linq;

namespace PoC.GraphQL
{
    public class ImperialStarDestroyerType : ObjectGraphType<ImperialStarDestroyer>
    {
        public ImperialStarDestroyerType(ITieFighterRepository TieFighterRepository)
        {
            Field(x => x.Id).Description("ImperialStarDestroyer id.");
            Field(x => x.Name, nullable: true).Description("ImperialStarDestroyer name.");

            Field<ListGraphType<TieFighterType>>(
                "TieFighters",
                resolve: context => TieFighterRepository.GetTieFightersWithByImperialStarDestroyerIdAsync(context.Source.Id).Result.ToList()
            );
        }
    }
}