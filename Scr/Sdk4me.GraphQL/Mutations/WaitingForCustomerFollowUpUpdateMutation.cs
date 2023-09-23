namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing waiting for customer follow-up.
    /// </summary>
    internal class WaitingForCustomerFollowUpUpdateMutation : Mutation<WaitingForCustomerFollowUpUpdatePayload, WaitingForCustomerFollowUpUpdateInput>
    {
        /// <summary>
        /// Initialize an new WaitingForCustomerFollowUpUpdate mutation instance.
        /// </summary>
        internal WaitingForCustomerFollowUpUpdateMutation(WaitingForCustomerFollowUpUpdateInput data)
            : base("waitingForCustomerFollowUpUpdate", "WaitingForCustomerFollowUpUpdateInput!", data, new HashSet<IQuery>() { new WaitingForCustomerFollowUpQuery() { FieldName = "waitingForCustomerFollowUp", IsConnection = false }.Select("*") })
        {
        }
    }
}
