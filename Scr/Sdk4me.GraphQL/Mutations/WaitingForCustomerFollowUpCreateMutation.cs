namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new waiting for customer follow-up.
    /// </summary>
    internal class WaitingForCustomerFollowUpCreateMutation : Mutation<WaitingForCustomerFollowUpCreatePayload, WaitingForCustomerFollowUpCreateInput>
    {
        /// <summary>
        /// Initialize an new WaitingForCustomerFollowUpCreate mutation instance.
        /// </summary>
        internal WaitingForCustomerFollowUpCreateMutation(WaitingForCustomerFollowUpCreateInput data)
            : base("waitingForCustomerFollowUpCreate", "WaitingForCustomerFollowUpCreateInput!", data, new HashSet<IQuery>() { new WaitingForCustomerFollowUpQuery() { FieldName = "waitingForCustomerFollowUp", IsConnection = false }.Select("*") })
        {
        }
    }
}
