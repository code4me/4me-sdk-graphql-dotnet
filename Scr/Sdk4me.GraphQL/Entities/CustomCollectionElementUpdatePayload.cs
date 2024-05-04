using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/customcollectionelementupdatepayload/">CustomCollectionElementUpdatePayload</see> object.
    /// </summary>
    public class CustomCollectionElementUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("customCollectionElement"), Sdk4meField(true)]
        public CustomCollectionElement? CustomCollectionElement { get; internal set; }
    }
}
