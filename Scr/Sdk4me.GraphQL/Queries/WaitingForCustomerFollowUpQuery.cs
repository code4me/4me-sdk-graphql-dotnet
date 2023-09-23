﻿namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving WaitingForCustomerFollowUp records.
    /// </summary>
    public class WaitingForCustomerFollowUpQuery : Query<WaitingForCustomerFollowUpQuery, WaitingForCustomerFollowUpField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new waiting for customer follow up query instance.
        /// </summary>
        public WaitingForCustomerFollowUpQuery()
            : base("waitingForCustomerFollowUps", typeof(WaitingForCustomerFollowUp), true)
        {
        }

        /// <summary>
        /// Initialize a new waiting for customer follow up query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the waiting for customer follow up.</param>
        public WaitingForCustomerFollowUpQuery(string id)
            : base("WaitingForCustomerFollowUp", id, typeof(WaitingForCustomerFollowUp), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public WaitingForCustomerFollowUpQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Rules of the waiting for customer follow-up.
        /// </summary>
        public WaitingForCustomerFollowUpQuery SelectWaitingForCustomerRules(WaitingForCustomerRuleQuery query)
        {
            query.FieldName = "waitingForCustomerRules";
            return Select(query);
        }
    }
}
