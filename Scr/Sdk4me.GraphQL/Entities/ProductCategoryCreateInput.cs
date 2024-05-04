using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/productcategorycreateinput/">ProductCategoryCreateInput</see> object.
    /// </summary>
    public class ProductCategoryCreateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private bool? disabled;
        private string? group;
        private string? name;
        private string? pictureUri;
        private ProductCategoryRuleSet? ruleSet;
        private string? source;
        private string? sourceID;
        private string? uiExtensionId;

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// Whether the product category may not be related to any more products.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Used to include the product category in a group.
        /// </summary>
        [JsonProperty("group")]
        public string? Group
        {
            get => group;
            set => group = Set("group", value);
        }

        /// <summary>
        /// The name of the product category.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri
        {
            get => pictureUri;
            set => pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// Used to select a set of rules that are to be applied to the products to which the product category is related, as well as the configuration items that are related to those products. The selected rule set dictates which fields are available for these product and configuration items.
        /// </summary>
        [JsonProperty("ruleSet")]
        public ProductCategoryRuleSet? RuleSet
        {
            get => ruleSet;
            set => ruleSet = Set("ruleSet", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
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
    }
}
