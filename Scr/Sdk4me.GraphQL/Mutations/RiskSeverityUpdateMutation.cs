namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing risk severity.
    /// </summary>
    internal class RiskSeverityUpdateMutation : Mutation<RiskSeverityUpdatePayload, RiskSeverityUpdateInput>
    {
        /// <summary>
        /// Initialize an new RiskSeverityUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal RiskSeverityUpdateMutation(RiskSeverityUpdateInput data, RiskSeverityQuery query)
            : base("riskSeverityUpdate", "RiskSeverityUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(RiskSeverityQuery query)
        {
            query.FieldName = "riskSeverity";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
