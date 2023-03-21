namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/discoveredproductinput/">DiscoveredProductInput</see> object.
    /// </summary>
    public class DiscoveredProductInput : PropertyChangeSet
    {
        private DiscoveredItemMetaData? meta;
        private string? uiExtensionId;
        private string? sourceID;
        private string? name;
        private string? model;
        private string? brand;
        private string? productID;
        private List<DiscoveredCiInput>? configurationItems;

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
        /// UI extension that is to be applied to the record.
        /// </summary>
        [JsonProperty("uiExtensionId")]
        public string? UiExtensionId
        {
            get => uiExtensionId;
            set => uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// The unique identifier of the product in an external system
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Name of the product.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The model of the product.
        /// </summary>
        [JsonProperty("model")]
        public string? Model
        {
            get => model;
            set => model = Set("model", value);
        }

        /// <summary>
        /// The brand name is typically the name of the product's manufacturer.
        /// </summary>
        [JsonProperty("brand")]
        public string? Brand
        {
            get => brand;
            set => brand = Set("brand", value);
        }

        /// <summary>
        /// The unique identifier of the product that is used by the manufacturer. The concatenation of <c>brand</c> and <c>productID</c> must be unique within a 4me account.
        /// </summary>
        [JsonProperty("productID")]
        public string? ProductID
        {
            get => productID;
            set => productID = Set("productID", value);
        }

        /// <summary>
        /// Configuration items to be uploaded.
        /// </summary>
        [JsonProperty("configurationItems")]
        public List<DiscoveredCiInput>? ConfigurationItems
        {
            get => configurationItems;
            set => configurationItems = Set("configurationItems", value);
        }
    }
}
