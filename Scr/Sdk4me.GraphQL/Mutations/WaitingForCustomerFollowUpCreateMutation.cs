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
        /// <param name="data">The input data.</param>
        /// <param name="query">The repsonse query.</param>
        internal WaitingForCustomerFollowUpCreateMutation(WaitingForCustomerFollowUpCreateInput data, WaitingForCustomerFollowUpQuery query)
            : base("waitingForCustomerFollowUpCreate", "WaitingForCustomerFollowUpCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(WaitingForCustomerFollowUpQuery query)
        {
            query.FieldName = "waitingForCustomerFollowUp";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
