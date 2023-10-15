namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/product/">Product</see> object.
    /// </summary>
    public class Product : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The brand name is typically the name of the product's manufacturer.
        /// </summary>
        [JsonProperty("brand"), Sdk4meField(true)]
        public string? Brand { get; internal set; }

        [JsonProperty("configurationItems")]
        internal NodeCollection<ConfigurationItem>? ConfigurationItemsCollection { get; set; }

        /// <summary>
        /// Configuration items of the product.
        /// </summary>
        public DataList<ConfigurationItem>? ConfigurationItems
        {
            get => ConfigurationItemsCollection?.Data;
        }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        [JsonProperty("customFields")]
        public CustomFieldCollection? CustomFields { get; internal set; }

        [JsonProperty("customFieldsAttachments")]
        internal NodeCollection<Attachment>? CustomFieldsAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public DataList<Attachment>? CustomFieldsAttachments
        {
            get => CustomFieldsAttachmentsCollection?.Data;
        }

        /// <summary>
        /// <br>Used to specify whether or not configuration items that are based on the product are typically depreciated and if so, which depreciation method is normally applied. Valid values are:</br>
        /// <br>• <c>not_depreciated</c>: Not Depreciated</br>
        /// <br>• <c>double_declining_balance</c>: Double Declining Balance</br>
        /// <br>• <c>reducing_balance</c>: Reducing Balance (or Diminishing Value)</br>
        /// <br>• <c>straight_line</c>: Straight Line (or Prime Cost)</br>
        /// <br>• <c>sum_of_the_years_digits</c>: Sum of the Year's Digits</br>
        /// </summary>
        [JsonProperty("depreciationMethod")]
        public ProductDepreciationMethod? DepreciationMethod { get; internal set; }

        /// <summary>
        /// Whether the product may no longer be used to register new configuration items.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The internal organization which budget is normally used to obtain the product.
        /// </summary>
        [JsonProperty("financialOwner")]
        public Organization? FinancialOwner { get; internal set; }

        /// <summary>
        /// The model of the product.
        /// </summary>
        [JsonProperty("model")]
        public string? Model { get; internal set; }

        /// <summary>
        /// The name of the product. Fill out the Brand, Model, Product ID (optional) and Category fields to automatically generate a name based on the values entered in these fields.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

        /// <summary>
        /// The appropriate product category for the product.
        /// </summary>
        [JsonProperty("productCategory"), Sdk4meField(true)]
        public ProductCategory? ProductCategory { get; internal set; }

        /// <summary>
        /// The unique identifier of the product that is used by the manufacturer. The concatenation of <c>brand</c> and <c>productID</c> must be unique within a 4me account.
        /// </summary>
        [JsonProperty("productID")]
        public string? ProductID { get; internal set; }

        /// <summary>
        /// The yearly rate that should normally be applied to calculate the depreciation of configuration items that are based on the product using the reducing balance (or diminishing value) method.
        /// </summary>
        [JsonProperty("rate")]
        public long? Rate { get; internal set; }

        /// <summary>
        /// Recurrence for maintenance of configuration items created from the product.
        /// </summary>
        [JsonProperty("recurrence")]
        public RecurrenceTemplate? Recurrence { get; internal set; }

        /// <summary>
        /// Any additional information about the product that might prove useful.
        /// </summary>
        [JsonProperty("remarks")]
        public string? Remarks { get; internal set; }

        [JsonProperty("remarksAttachments")]
        internal NodeCollection<Attachment>? RemarksAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Remarks field.
        /// </summary>
        public DataList<Attachment>? RemarksAttachments
        {
            get => RemarksAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The rule set of the related product category.
        /// </summary>
        [JsonProperty("ruleSet")]
        public ProductCategoryRuleSet? RuleSet { get; internal set; }

        /// <summary>
        /// The value of this product at the end of its useful life (i.e. at the end of its depreciation period). When a value is not specified for this field, it is set to zero.
        /// </summary>
        [JsonProperty("salvageValue")]
        public decimal? SalvageValue { get; internal set; }

        /// <summary>
        /// <br>The currency of the salvage value of this product.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("salvageValueCurrency")]
        public string? SalvageValueCurrency { get; internal set; }

        /// <summary>
        /// The Service which Service Instances would typically include the product.
        /// </summary>
        [JsonProperty("service")]
        public Service? Service { get; internal set; }

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

        /// <summary>
        /// The organization from which the product is typically obtained. If the product is developed internally, select the internal organization that develops it. Note that a lease company should be selected in this field if the product is normally leased.
        /// </summary>
        [JsonProperty("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The team responsible for maintaining the product's information in the configuration management database (CMDB).
        /// </summary>
        [JsonProperty("supportTeam")]
        public Team? SupportTeam { get; internal set; }

        /// <summary>
        /// UI extension that is to be added to the configuration items that are based on the product.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The number of years within which configuration items that are based on the product are typically depreciated.
        /// </summary>
        [JsonProperty("usefulLife")]
        public long? UsefulLife { get; internal set; }

        /// <summary>
        /// The person who will be responsible for coordinating the workflows that will be generated automatically in accordance with the recurrence schedule.
        /// </summary>
        [JsonProperty("workflowManager")]
        public Person? WorkflowManager { get; internal set; }

        /// <summary>
        /// The workflow template that is used to periodically maintain configuration items created from the product.
        /// </summary>
        [JsonProperty("workflowTemplate")]
        public WorkflowTemplate? WorkflowTemplate { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(ConfigurationItemsCollection?.GetQueryPageInfo("configurationItems", depth + 1));
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(RemarksAttachmentsCollection?.GetQueryPageInfo("remarksAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            ConfigurationItems?.AddRange((data as Product)?.ConfigurationItems);
            CustomFieldsAttachments?.AddRange((data as Product)?.CustomFieldsAttachments);
            RemarksAttachments?.AddRange((data as Product)?.RemarksAttachments);
        }
    }
}
