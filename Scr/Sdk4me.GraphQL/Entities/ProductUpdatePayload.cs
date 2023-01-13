namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/productupdatepayload/">ProductUpdatePayload</see> object.
    /// </summary>
    public class ProductUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("product"), Sdk4meField(true)]
        public Product? Product { get; internal set; }
    }
}
