using GraphQL.Types;
using System;

namespace PoC.GraphQL.Models
{
    public class EasyGalacticEmpireSchema : Schema
    {
        public EasyGalacticEmpireSchema(Func<Type, GraphType> resolveType)
            : base(resolveType)
        {
            Query = (EasyStoreQuery)resolveType(typeof(EasyStoreQuery));
        }
    }
}
