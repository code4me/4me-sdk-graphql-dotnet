namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/productcategory/">ProductCategory</see> object.
    /// </summary>
    public class ProductCategory : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the product category may not be related to any more products.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Used to include the product category in a group.
        /// </summary>
        [JsonProperty("group"), Sdk4meField(true)]
        public string? Group { get; internal set; }

        /// <summary>
        /// The name of the product category.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

        [JsonProperty("products")]
        internal NodeCollection<Product>? ProductsCollection { get; set; }

        /// <summary>
        /// Products in this category.
        /// </summary>
        public DataList<Product>? Products
        {
            get => ProductsCollection?.Data;
        }

        /// <summary>
        /// Automatically set to the concatenation of the Group field value and the Name field value, separated by a forward slash, written in lower case characters and with all spaces replaced by an underscore character.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference { get; internal set; }

        /// <summary>
        /// Used to select a set of rules that are to be applied to the products to which the product category is related, as well as the configuration items that are related to those products. The selected rule set dictates which fields are available for these product and configuration items.
        /// </summary>
        [JsonProperty("ruleSet"), Sdk4meField(true)]
        public ProductCategoryRuleSet? RuleSet { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(true)]
        public string? SourceID { get; internal set; }

        [JsonProperty("translations")]
        internal NodeCollection<Translation>? TranslationsCollection { get; set; }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public DataList<Translation>? Translations
        {
            get => TranslationsCollection?.Data;
        }

        /// <summary>
        /// User interface extension that is linked to the product category.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the `createdAt` value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(ProductsCollection?.GetQueryPageInfo("products", depth + 1));
            retval.AddRange(TranslationsCollection?.GetQueryPageInfo("translations", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Products?.AddRange((data as ProductCategory)?.Products);
            Translations?.AddRange((data as ProductCategory)?.Translations);
        }
    }
}
