using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/discoveredproductinput/">DiscoveredProductInput</see> object.
    /// </summary>
    public class DiscoveredProductInput : PropertyChangeSet
    {
        private string brand;
        private List<DiscoveredCiInput>? configurationItems;
        private DiscoveredItemMetaData? meta;
        private string model;
        private string name;
        private string? productID;
        private string? service;
        private string sourceID;
        private string? uiExtensionId;

        /// <summary>
        /// The brand name is typically the name of the product's manufacturer.
        /// </summary>
        [JsonProperty("brand"), Sdk4meField(IsRequiredForMutation = true)]
        public string Brand
        {
            get => brand;
            set => brand = Set("brand", value);
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
        /// The model of the product.
        /// </summary>
        [JsonProperty("model"), Sdk4meField(IsRequiredForMutation = true)]
        public string Model
        {
            get => model;
            set => model = Set("model", value);
        }

        /// <summary>
        /// Name of the product.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsRequiredForMutation = true)]
        public string Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The unique identifier of the product that is used by the manufacturer. The concatenation of <c>brand</c> and <c>productID</c> must be unique within a Xurrent account.
        /// </summary>
        [JsonProperty("productID")]
        public string? ProductID
        {
            get => productID;
            set => productID = Set("productID", value);
        }

        /// <summary>
        /// The name of the service this product's configuration items are, or will be, a part of.
        /// </summary>
        [JsonProperty("service")]
        public string? Service
        {
            get => service;
            set => service = Set("service", value);
        }

        /// <summary>
        /// The unique identifier of the product in an external system
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(IsRequiredForMutation = true)]
        public string SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
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
        /// Initializes a new instance of the <see cref="DiscoveredProductInput"/> class without providing the required values.
        /// </summary>
        public DiscoveredProductInput()
        {
            brand = string.Empty;
            model = string.Empty;
            name = string.Empty;
            sourceID = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredProductInput"/> class.
        /// </summary>
        /// <param name="brand">The brand name is typically the name of the product's manufacturer.</param>
        /// <param name="model">The model of the product.</param>
        /// <param name="name">Name of the product.</param>
        /// <param name="sourceID">The unique identifier of the product in an external system</param>
        public DiscoveredProductInput(string brand, string model, string name, string sourceID)
        {
            this.brand = Set("brand", brand);
            this.model = Set("model", model);
            this.name = Set("name", name);
            this.sourceID = Set("sourceID", sourceID);
        }
    }
}
