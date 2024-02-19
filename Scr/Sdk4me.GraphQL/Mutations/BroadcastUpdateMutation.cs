namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing broadcast.
    /// </summary>
    internal class BroadcastUpdateMutation : Mutation<BroadcastUpdatePayload, BroadcastUpdateInput>
    {
        /// <summary>
        /// Initialize an new BroadcastUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal BroadcastUpdateMutation(BroadcastUpdateInput data, BroadcastQuery query)
            : base("broadcastUpdate", "BroadcastUpdateInput!", data, GetQuery(query))
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
            return new HashSet<IQuery>() {query};
        }
    }
}
