namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new agile board.
    /// </summary>
    internal class AgileBoardCreateMutation : Mutation<AgileBoardCreatePayload, AgileBoardCreateInput>
    {
        /// <summary>
        /// Initialize an new AgileBoardCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The agile board response query.</param>
        internal AgileBoardCreateMutation(AgileBoardCreateInput data, AgileBoardQuery query)
            : base("agileBoardCreate", "AgileBoardCreateInput!", data, GetQuery(query))
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
