using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/customcollectioncreatepayload/">CustomCollectionCreatePayload</see> object.
    /// </summary>
    public class CustomCollectionCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("customCollection"), Sdk4meField(IsDefaultQueryProperty = true)]
        public CustomCollection? CustomCollection { get; internal set; }
    }
}
