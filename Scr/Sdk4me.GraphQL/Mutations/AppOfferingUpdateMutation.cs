namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing app offering.
    /// </summary>
    internal class AppOfferingUpdateMutation : Mutation<AppOfferingUpdatePayload, AppOfferingUpdateInput>
    {
        /// <summary>
        /// Initialize an new AppOfferingUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal AppOfferingUpdateMutation(AppOfferingUpdateInput data, AppOfferingQuery query)
            : base("appOfferingUpdate", "AppOfferingUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(AppOfferingQuery query)
        {
            query.FieldName = "appOffering";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
