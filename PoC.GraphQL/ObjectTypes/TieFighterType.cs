using GraphQL.Types;
using PoC.GraphQL.Data;
using PoC.GraphQL.Models;


namespace PoC.GraphQL
{
    public class TieFighterType : ObjectGraphType<TieFighter>
    {
        public TieFighterType(IImperialStarDestroyerRepository ImperialStarDestroyerRepository)
        {
            Field(x => x.Id).Description("TieFighter id.");
            Field(x => x.Name).Description("TieFighter name.");
            Field(x => x.Description, nullable: true).Description("TieFighter description.");
            Field(x => x.Price).Description("TieFighter price.");

            Field<ImperialStarDestroyerType>(
                "ImperialStarDestroyer",
                resolve: context => ImperialStarDestroyerRepository.GetImperialStarDestroyerAsync(context.Source.ImperialStarDestroyerId).Result
             );
        }
    }
}