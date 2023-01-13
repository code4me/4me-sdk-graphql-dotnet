namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/productbacklogcreatepayload/">ProductBacklogCreatePayload</see> object.
    /// </summary>
    public class ProductBacklogCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("productBacklog"), Sdk4meField(true)]
        public ProductBacklog? ProductBacklog { get; internal set; }
    }
}
