using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/customcollectionupdatepayload/">CustomCollectionUpdatePayload</see> object.
    /// </summary>
    public class CustomCollectionUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("customCollection"), Sdk4meField(true)]
        public CustomCollection? CustomCollection { get; internal set; }
    }
}
