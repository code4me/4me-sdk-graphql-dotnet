using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/productbacklogupdatepayload/">ProductBacklogUpdatePayload</see> object.
    /// </summary>
    public class ProductBacklogUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("productBacklog"), Sdk4meField(IsDefaultQueryProperty = true)]
        public ProductBacklog? ProductBacklog { get; internal set; }
    }
}
