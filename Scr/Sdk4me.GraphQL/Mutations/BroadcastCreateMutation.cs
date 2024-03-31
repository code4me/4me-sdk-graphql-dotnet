namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new broadcast.
    /// </summary>
    internal class BroadcastCreateMutation : Mutation<BroadcastCreatePayload, BroadcastCreateInput>
    {
        /// <summary>
        /// Initialize an new BroadcastCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal BroadcastCreateMutation(BroadcastCreateInput data, BroadcastQuery query)
            : base("broadcastCreate", "BroadcastCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(BroadcastQuery query)
        {
            query.FieldName = "broadcast";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
