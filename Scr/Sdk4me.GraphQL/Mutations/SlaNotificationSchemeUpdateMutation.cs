namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing SLA notification scheme.
    /// </summary>
    internal class SlaNotificationSchemeUpdateMutation : Mutation<SlaNotificationSchemeUpdatePayload, SlaNotificationSchemeUpdateInput>
    {
        /// <summary>
        /// Initialize an new SlaNotificationSchemeUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal SlaNotificationSchemeUpdateMutation(SlaNotificationSchemeUpdateInput data, SlaNotificationSchemeQuery query)
            : base("slaNotificationSchemeUpdate", "SlaNotificationSchemeUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(SlaNotificationSchemeQuery query)
        {
            query.FieldName = "slaNotificationScheme";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
