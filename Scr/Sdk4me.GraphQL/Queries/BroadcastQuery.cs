namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Broadcast records.
    /// </summary>
    public class BroadcastQuery : Query<BroadcastQuery, BroadcastField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new broadcast query instance.
        /// </summary>
        public BroadcastQuery()
            : base("broadcasts", typeof(Broadcast), true)
        {
        }

        /// <summary>
        /// Initialize a new broadcast query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the broadcast.</param>
        public BroadcastQuery(string id)
            : base("Broadcast", id, typeof(Broadcast), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public BroadcastQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Used to select one or more customer organizations when the broadcast is to be displayed for the specialists of the account in requests that were received from the selected organizations. This field is available only when the "Specialists in requests from the following customers" visibility option is selected.
        /// </summary>
        public BroadcastQuery SelectCustomers(OrganizationQuery query)
        {
            query.FieldName = "customers";
            return Select(query);
        }

        /// <summary>
        /// Grouped request to which customers can add request to indicate they are also affected.
        /// </summary>
        public BroadcastQuery SelectRequest(RequestQuery query)
        {
            query.FieldName = "request";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Used to select the service instances for which the people, who are covered for them by an active SLA, need to see the broadcast. This table field is available only when the "People covered for the following service instance(s)" visibility option is selected.
        /// </summary>
        public BroadcastQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// Used to select the teams which members need to see the broadcast. This table field is available only when the "Members of the following team(s)" visibility option is selected.
        /// </summary>
        public BroadcastQuery SelectTeams(TeamQuery query)
        {
            query.FieldName = "teams";
            return Select(query);
        }
    }
}
