namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/discoveredproductcategoryinput/">DiscoveredProductCategoryInput</see> object.
    /// </summary>
    public class DiscoveredProductCategoryInput : PropertyChangeSet
    {
        private DiscoveredItemMetaData? meta;
        private string? name;
        private List<DiscoveredProductInput>? products;
        private string? reference;
        private string? sourceID;

        /// <summary>
        /// Meta data describing how to process the values supplied.
        /// </summary>
        [JsonProperty("meta")]
        public DiscoveredItemMetaData? Meta
        {
            get => meta;
            set => meta = Set("meta", value);
        }

        /// <summary>
        /// Name of the product category.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Configuration items to be uploaded, grouped by product.
        /// </summary>
        [JsonProperty("products")]
        public List<DiscoveredProductInput>? Products
        {
            get => products;
            set => products = Set("products", value);
        }

        /// <summary>
        /// Reference identifying the product category.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference
        {
            get => reference;
            set => reference = Set("reference", value);
        }

        /// <summary>
        /// The unique identifier of the product category in an external system
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
        }
    }
}
