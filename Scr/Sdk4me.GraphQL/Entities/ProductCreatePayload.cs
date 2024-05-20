using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/productcreatepayload/">ProductCreatePayload</see> object.
    /// </summary>
    public class ProductCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("product"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Product? Product { get; internal set; }
    }
}
