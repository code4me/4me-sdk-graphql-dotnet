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
        internal RiskSeverityUpdateMutation(RiskSeverityUpdateInput data)
            : base("riskSeverityUpdate", "RiskSeverityUpdateInput!", data, new HashSet<IQuery>() { new RiskSeverityQuery() { FieldName = "riskSeverity", IsConnection = false }.Select("*") })
        {
        }
    }
}
