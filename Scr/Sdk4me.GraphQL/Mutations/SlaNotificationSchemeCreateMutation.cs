namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new SLA notification scheme.
    /// </summary>
    internal class SlaNotificationSchemeCreateMutation : Mutation<SlaNotificationSchemeCreatePayload, SlaNotificationSchemeCreateInput>
    {
        /// <summary>
        /// Initialize an new SlaNotificationSchemeCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The sla notification scheme response query.</param>
        internal SlaNotificationSchemeCreateMutation(SlaNotificationSchemeCreateInput data, SlaNotificationSchemeQuery query)
            : base("slaNotificationSchemeCreate", "SlaNotificationSchemeCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The sla notification scheme response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(SlaNotificationSchemeQuery query)
        {
            query.FieldName = "slaNotificationScheme";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
