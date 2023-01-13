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
        internal RiskSeverityCreateMutation(RiskSeverityCreateInput data)
            : base("riskSeverityCreate", "RiskSeverityCreateInput!", data, new HashSet<IQuery>() { new RiskSeverityQuery() { FieldName = "riskSeverity", IsConnection = false }.Select("*") })
        {
        }
    }
}
