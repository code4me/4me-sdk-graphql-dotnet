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
        internal RiskUpdateMutation(RiskUpdateInput data)
            : base("riskUpdate", "RiskUpdateInput!", data, new HashSet<IQuery>() { new RiskQuery() { FieldName = "risk", IsConnection = false }.Select("*") })
        {
        }
    }
}
