using System.Collections.Generic;

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
        /// <param name="data">The input data.</param>
        /// <param name="query">The waiting for customer follow up response query.</param>
        internal WaitingForCustomerFollowUpUpdateMutation(WaitingForCustomerFollowUpUpdateInput data, WaitingForCustomerFollowUpQuery query)
            : base("waitingForCustomerFollowUpUpdate", "WaitingForCustomerFollowUpUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The waiting for customer follow up response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(WaitingForCustomerFollowUpQuery query)
        {
            query.FieldName = "waitingForCustomerFollowUp";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
