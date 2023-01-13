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
        internal BroadcastCreateMutation(BroadcastCreateInput data)
            : base("broadcastCreate", "BroadcastCreateInput!", data, new HashSet<IQuery>() { new BroadcastQuery() { FieldName = "broadcast", IsConnection = false }.Select("*") })
        {
        }
    }
}
