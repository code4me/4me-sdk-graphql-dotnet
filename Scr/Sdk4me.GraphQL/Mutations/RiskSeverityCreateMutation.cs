namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new risk severity.
    /// </summary>
    internal class RiskSeverityCreateMutation : Mutation<RiskSeverityCreatePayload, RiskSeverityCreateInput>
    {
        /// <summary>
        /// Initialize an new RiskSeverityCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The risk severity response query.</param>
        internal RiskSeverityCreateMutation(RiskSeverityCreateInput data, RiskSeverityQuery query)
            : base("riskSeverityCreate", "RiskSeverityCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The risk severity response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(RiskSeverityQuery query)
        {
            query.FieldName = "riskSeverity";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
