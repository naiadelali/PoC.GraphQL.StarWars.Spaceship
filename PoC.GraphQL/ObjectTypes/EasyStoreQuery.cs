using GraphQL.Types;
using PoC.GraphQL.Data;
using PoC.GraphQL.Models;

namespace PoC.GraphQL
{
    public class EasyStoreQuery : ObjectGraphType
    {
        public EasyStoreQuery(IImperialStarDestroyerRepository ImperialStarDestroyerRepository, ITieFighterRepository TieFighterRepository)
        {
            Field<ImperialStarDestroyerType>(
                "spaceship",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "ImperialStarDestroyer id" }
                ),
                resolve: context => ImperialStarDestroyerRepository.GetImperialStarDestroyerAsync(context.GetArgument<int>("id")).Result
            );

            Field<ListGraphType<ImperialStarDestroyerType>>(
              "spaceships",
               resolve: context => ImperialStarDestroyerRepository.GetImperialStarDestroyersAsync());

            Field<TieFighterType>(
                "tiefighter",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "TieFighter id" }
                ),
                resolve: context => TieFighterRepository.GetTieFighterAsync(context.GetArgument<int>("id")).Result
            );
        }
    }
}
