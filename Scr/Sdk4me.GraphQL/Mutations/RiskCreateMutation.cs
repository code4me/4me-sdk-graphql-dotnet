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
        internal RiskCreateMutation(RiskCreateInput data)
            : base("riskCreate", "RiskCreateInput!", data, new HashSet<IQuery>() { new RiskQuery() { FieldName = "risk", IsConnection = false }.Select("*") })
        {
        }
    }
}
