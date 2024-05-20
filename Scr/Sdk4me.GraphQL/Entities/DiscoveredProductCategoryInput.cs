using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/discoveredproductcategoryinput/">DiscoveredProductCategoryInput</see> object.
    /// </summary>
    public class DiscoveredProductCategoryInput : PropertyChangeSet
    {
        private DiscoveredItemMetaData? meta;
        private string name;
        private List<DiscoveredProductInput>? products;
        private string reference;
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
        [JsonProperty("name"), Sdk4meField(IsRequiredForMutation = true)]
        public string Name
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
        [JsonProperty("reference"), Sdk4meField(IsRequiredForMutation = true)]
        public string Reference
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

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredProductCategoryInput"/> class without providing the required values.
        /// </summary>
        public DiscoveredProductCategoryInput()
        {
            name = string.Empty;
            reference = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredProductCategoryInput"/> class.
        /// </summary>
        /// <param name="name">Name of the product category.</param>
        /// <param name="reference">Reference identifying the product category.</param>
        public DiscoveredProductCategoryInput(string name, string reference)
        {
            this.name = Set("name", name);
            this.reference = Set("reference", reference);
        }
    }
}
