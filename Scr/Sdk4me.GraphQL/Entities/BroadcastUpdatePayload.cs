namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/broadcastupdatepayload/">BroadcastUpdatePayload</see> object.
    /// </summary>
    public class BroadcastUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("broadcast"), Sdk4meField(true)]
        public Broadcast? Broadcast { get; internal set; }
    }
}
