namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/shoporderlineupdatepayload/">ShopOrderLineUpdatePayload</see> object.
    /// </summary>
    public class ShopOrderLineUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("shopOrderLine"), Sdk4meField(true)]
        public ShopOrderLine? ShopOrderLine { get; internal set; }
    }
}
