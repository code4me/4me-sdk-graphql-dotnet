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
        internal BroadcastUpdateMutation(BroadcastUpdateInput data)
            : base("broadcastUpdate", "BroadcastUpdateInput!", data, new HashSet<IQuery>() { new BroadcastQuery() { FieldName = "broadcast", IsConnection = false }.Select("*") })
        {
        }
    }
}
