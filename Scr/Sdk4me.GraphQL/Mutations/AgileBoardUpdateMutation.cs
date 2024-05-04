using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing agile board.
    /// </summary>
    internal class AgileBoardUpdateMutation : Mutation<AgileBoardUpdatePayload, AgileBoardUpdateInput>
    {
        /// <summary>
        /// Initialize an new AgileBoardUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The agile board response query.</param>
        internal AgileBoardUpdateMutation(AgileBoardUpdateInput data, AgileBoardQuery query)
            : base("agileBoardUpdate", "AgileBoardUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The agile board response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(AgileBoardQuery query)
        {
            query.FieldName = "agileBoard";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
