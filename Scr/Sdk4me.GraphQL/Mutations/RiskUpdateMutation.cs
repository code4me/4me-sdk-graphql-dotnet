namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing risk.
    /// </summary>
    internal class RiskUpdateMutation : Mutation<RiskUpdatePayload, RiskUpdateInput>
    {
        /// <summary>
        /// Initialize an new RiskUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal RiskUpdateMutation(RiskUpdateInput data, RiskQuery query)
            : base("riskUpdate", "RiskUpdateInput!", data, GetQuery(query))
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
            return new HashSet<IQuery>() {query};
        }
    }
}
