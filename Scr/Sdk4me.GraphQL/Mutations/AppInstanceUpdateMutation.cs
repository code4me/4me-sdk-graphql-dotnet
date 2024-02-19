namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing app instance.
    /// </summary>
    internal class AppInstanceUpdateMutation : Mutation<AppInstanceUpdatePayload, AppInstanceUpdateInput>
    {
        /// <summary>
        /// Initialize an new AppInstanceUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal AppInstanceUpdateMutation(AppInstanceUpdateInput data, AppInstanceQuery query)
            : base("appInstanceUpdate", "AppInstanceUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(AppInstanceQuery query)
        {
            query.FieldName = "appInstance";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
