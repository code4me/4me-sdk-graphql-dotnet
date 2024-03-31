namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new risk.
    /// </summary>
    internal class RiskCreateMutation : Mutation<RiskCreatePayload, RiskCreateInput>
    {
        /// <summary>
        /// Initialize an new RiskCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal RiskCreateMutation(RiskCreateInput data, RiskQuery query)
            : base("riskCreate", "RiskCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(RiskQuery query)
        {
            query.FieldName = "risk";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
