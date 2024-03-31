namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new app instance.
    /// </summary>
    internal class AppInstanceCreateMutation : Mutation<AppInstanceCreatePayload, AppInstanceCreateInput>
    {
        /// <summary>
        /// Initialize an new AppInstanceCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal AppInstanceCreateMutation(AppInstanceCreateInput data, AppInstanceQuery query)
            : base("appInstanceCreate", "AppInstanceCreateInput!", data, GetQuery(query))
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
            return new HashSet<IQuery>() { query };
        }
    }
}
