using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/shoporderlinecreatepayload/">ShopOrderLineCreatePayload</see> object.
    /// </summary>
    public class ShopOrderLineCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("shopOrderLine"), Sdk4meField(true)]
        public ShopOrderLine? ShopOrderLine { get; internal set; }
    }
}
