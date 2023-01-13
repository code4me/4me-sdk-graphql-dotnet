namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/productcategoryupdatepayload/">ProductCategoryUpdatePayload</see> object.
    /// </summary>
    public class ProductCategoryUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("productCategory"), Sdk4meField(true)]
        public ProductCategory? ProductCategory { get; internal set; }
    }
}
