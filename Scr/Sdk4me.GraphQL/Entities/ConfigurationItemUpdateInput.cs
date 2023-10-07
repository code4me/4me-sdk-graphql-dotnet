namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/configurationitemupdateinput/">ConfigurationItemUpdateInput</see> object.
    /// </summary>
    public class ConfigurationItemUpdateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private string? pictureUri;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private List<string>? alternateNames;
        private string? assetID;
        private DateOnly? endOfSupportDate;
        private List<string>? contractIds;
        private string? financialOwnerId;
        private DateOnly? inUseSince;
        private string? label;
        private DateTime? lastSeenAt;
        private DateOnly? licenseExpiryDate;
        private CiLicenseType? licenseType;
        private List<string>? licensedSiteIds;
        private string? location;
        private string? name;
        private long? nrOfCores;
        private long? nrOfLicenses;
        private long? nrOfProcessors;
        private string? operatingSystemId;
        private string? productId;
        private decimal? purchaseValue;
        private string? purchaseValueCurrency;
        private long? ramAmount;
        private RecurrenceInput? recurrence;
        private string? remarks;
        private List<AttachmentInput>? remarksAttachments;
        private ProductCategoryRuleSet? ruleSet;
        private string? serialNr;
        private string? serviceId;
        private List<string>? serviceInstanceIds;
        private string? siteId;
        private bool? siteLicense;
        private CiStatus? status;
        private string? supplierId;
        private string? supportTeamId;
        private string? systemID;
        private bool? temporaryLicense;
        private List<string>? userIds;
        private DateOnly? warrantyExpiryDate;
        private string? workflowManagerId;
        private string? workflowTemplateId;
        private List<CiRelationInput>? newCiRelations;
        private string? clientMutationId;
        private string? id;
        private List<string>? ciRelationsToDelete;

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
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri
        {
            get => pictureUri;
            set => pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// Values for custom fields to be used by the UI Extension that is linked to the record.
        /// </summary>
        [JsonProperty("customFields")]
        public CustomFieldCollection? CustomFields
        {
            get => customFields;
            set => customFields = Set("customFields", value);
        }

        /// <summary>
        /// The attachments used in the custom fields' values.
        /// </summary>
        [JsonProperty("customFieldsAttachments")]
        public List<AttachmentInput>? CustomFieldsAttachments
        {
            get => customFieldsAttachments;
            set => customFieldsAttachments = Set("customFieldsAttachments", value);
        }

        /// <summary>
        /// Alternate names the configuration item is also known by.
        /// </summary>
        [JsonProperty("alternateNames")]
        public List<string>? AlternateNames
        {
            get => alternateNames;
            set => alternateNames = Set("alternateNames", value);
        }

        /// <summary>
        /// Asset identifier of the configuration item.
        /// </summary>
        [JsonProperty("assetID")]
        public string? AssetID
        {
            get => assetID;
            set => assetID = Set("assetID", value);
        }

        /// <summary>
        /// The date at which the support for this configuration item ends.
        /// </summary>
        [JsonProperty("endOfSupportDate")]
        public DateOnly? EndOfSupportDate
        {
            get => endOfSupportDate;
            set => endOfSupportDate = Set("endOfSupportDate", value);
        }

        /// <summary>
        /// Identifiers of the contracts of this configuration item.
        /// </summary>
        [JsonProperty("contractIds")]
        public List<string>? ContractIds
        {
            get => contractIds;
            set => contractIds = Set("contractIds", value);
        }

        /// <summary>
        /// Identifier of the internal organization which budget is used to pay for the configuration item. If the CI is leased or rented, the organization that pays the lease or rent is selected in this field. When creating a new CI and a value is not specified for this field, it is set to the financial owner of the CI's product.
        /// </summary>
        [JsonProperty("financialOwnerId")]
        public string? FinancialOwnerId
        {
            get => financialOwnerId;
            set => financialOwnerId = Set("financialOwnerId", value);
        }

        /// <summary>
        /// The date on which the expense for the configuration item (CI) was incurred or, if the CI is depreciated over time, the date on which the depreciation was started. This is typically the invoice date.
        /// </summary>
        [JsonProperty("inUseSince")]
        public DateOnly? InUseSince
        {
            get => inUseSince;
            set => inUseSince = Set("inUseSince", value);
        }

        /// <summary>
        /// The label that is attached to the configuration item (CI). A label is automatically generated using the same prefix of other CIs of the same product category, followed by the next available number as the suffix.
        /// </summary>
        [JsonProperty("label")]
        public string? Label
        {
            get => label;
            set => label = Set("label", value);
        }

        /// <summary>
        /// The date and time at which the configuration item was last seen.
        /// </summary>
        [JsonProperty("lastSeenAt")]
        public DateTime? LastSeenAt
        {
            get => lastSeenAt;
            set => lastSeenAt = Set("lastSeenAt", value);
        }

        /// <summary>
        /// The date through which the temporary software license certificate is valid. The license certificate expires at the end of this day.
        /// </summary>
        [JsonProperty("licenseExpiryDate")]
        public DateOnly? LicenseExpiryDate
        {
            get => licenseExpiryDate;
            set => licenseExpiryDate = Set("licenseExpiryDate", value);
        }

        /// <summary>
        /// The type of license that the license certificate covers.
        /// </summary>
        [JsonProperty("licenseType")]
        public CiLicenseType? LicenseType
        {
            get => licenseType;
            set => licenseType = Set("licenseType", value);
        }

        /// <summary>
        /// Identifiers of the sites at which the software that is covered by the license certificate may be used.
        /// </summary>
        [JsonProperty("licensedSiteIds")]
        public List<string>? LicensedSiteIds
        {
            get => licensedSiteIds;
            set => licensedSiteIds = Set("licensedSiteIds", value);
        }

        /// <summary>
        /// The name or number of the room in which the CI is located, if it concerns a hardware CI.
        /// </summary>
        [JsonProperty("location")]
        public string? Location
        {
            get => location;
            set => location = Set("location", value);
        }

        /// <summary>
        /// The name of the configuration item (CI). When creating a new CI and a value is not specified for this field, it is set to the name of the CI's product.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The total number of processor cores that are installed in the server.
        /// </summary>
        [JsonProperty("nrOfCores")]
        public long? NrOfCores
        {
            get => nrOfCores;
            set => nrOfCores = Set("nrOfCores", value);
        }

        /// <summary>
        /// The number of licenses that the license certificate covers.
        /// </summary>
        [JsonProperty("nrOfLicenses")]
        public long? NrOfLicenses
        {
            get => nrOfLicenses;
            set => nrOfLicenses = Set("nrOfLicenses", value);
        }

        /// <summary>
        /// The number of processors that are installed in the server.
        /// </summary>
        [JsonProperty("nrOfProcessors")]
        public long? NrOfProcessors
        {
            get => nrOfProcessors;
            set => nrOfProcessors = Set("nrOfProcessors", value);
        }

        /// <summary>
        /// Identifier of the (software) configuration item representing the operating system of this configuration item.
        /// </summary>
        [JsonProperty("operatingSystemId")]
        public string? OperatingSystemId
        {
            get => operatingSystemId;
            set => operatingSystemId = Set("operatingSystemId", value);
        }

        /// <summary>
        /// Identifier of the related product.
        /// </summary>
        [JsonProperty("productId")]
        public string? ProductId
        {
            get => productId;
            set => productId = Set("productId", value);
        }

        /// <summary>
        /// The amount that was paid for the configuration item (this is normally equal to the invoice amount).
        /// </summary>
        [JsonProperty("purchaseValue")]
        public decimal? PurchaseValue
        {
            get => purchaseValue;
            set => purchaseValue = Set("purchaseValue", value);
        }

        /// <summary>
        /// <br>The currency of the purchase value attributed to this configuration item.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("purchaseValueCurrency")]
        public string? PurchaseValueCurrency
        {
            get => purchaseValueCurrency;
            set => purchaseValueCurrency = Set("purchaseValueCurrency", value);
        }

        /// <summary>
        /// The amount of RAM (in GB) of this configuration item.
        /// </summary>
        [JsonProperty("ramAmount")]
        public long? RamAmount
        {
            get => ramAmount;
            set => ramAmount = Set("ramAmount", value);
        }

        /// <summary>
        /// Recurrence for maintenance of the configuration item.
        /// </summary>
        [JsonProperty("recurrence")]
        public RecurrenceInput? Recurrence
        {
            get => recurrence;
            set => recurrence = Set("recurrence", value);
        }

        /// <summary>
        /// Any additional information about the configuration item that might prove useful. When creating a new CI and a value is not specified for this field, it is set to the remarks of the CI's product.
        /// </summary>
        [JsonProperty("remarks")]
        public string? Remarks
        {
            get => remarks;
            set => remarks = Set("remarks", value);
        }

        /// <summary>
        /// The attachments used in the <c>remarks</c> field.
        /// </summary>
        [JsonProperty("remarksAttachments")]
        public List<AttachmentInput>? RemarksAttachments
        {
            get => remarksAttachments;
            set => remarksAttachments = Set("remarksAttachments", value);
        }

        /// <summary>
        /// The Rule set field is automatically set to the rule set of product category, except when the CI is a license certificate, in which case the rule set is <c>license_certificate</c>.
        /// </summary>
        [JsonProperty("ruleSet")]
        public ProductCategoryRuleSet? RuleSet
        {
            get => ruleSet;
            set => ruleSet = Set("ruleSet", value);
        }

        /// <summary>
        /// Serial number of the configuration item. The concatenation of <c>product</c>'s' <c>brand</c> and <c>serialNr</c> must be unique within a 4me account.
        /// </summary>
        [JsonProperty("serialNr")]
        public string? SerialNr
        {
            get => serialNr;
            set => serialNr = Set("serialNr", value);
        }

        /// <summary>
        /// Which service instance(s) the configuration item is, or will be, a part of. When creating a new CI and a value is not specified for this field, it is set to the service of the CI's product.
        /// </summary>
        [JsonProperty("serviceId")]
        public string? ServiceId
        {
            get => serviceId;
            set => serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// Identifiers of the service instances of this configuration item.
        /// </summary>
        [JsonProperty("serviceInstanceIds")]
        public List<string>? ServiceInstanceIds
        {
            get => serviceInstanceIds;
            set => serviceInstanceIds = Set("serviceInstanceIds", value);
        }

        /// <summary>
        /// Where the CI is located, if it concerns a hardware CI.
        /// </summary>
        [JsonProperty("siteId")]
        public string? SiteId
        {
            get => siteId;
            set => siteId = Set("siteId", value);
        }

        /// <summary>
        /// <c>true</c> for license certificates that may only be used at one or more specific locations.
        /// </summary>
        [JsonProperty("siteLicense")]
        public bool? SiteLicense
        {
            get => siteLicense;
            set => siteLicense = Set("siteLicense", value);
        }

        /// <summary>
        /// The appropriate status for the configuration item (CI).
        /// </summary>
        [JsonProperty("status")]
        public CiStatus? Status
        {
            get => status;
            set => status = Set("status", value);
        }

        /// <summary>
        /// Identifier of the supplier from which the configuration item (CI) has been obtained. When creating a new CI and a value is not specified for this field, it is set to the supplier of the CI's product.
        /// </summary>
        [JsonProperty("supplierId")]
        public string? SupplierId
        {
            get => supplierId;
            set => supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// Identifier of the team responsible for supporting the configuration item and maintaining its information in the configuration management database (CMDB). When creating a new CI and a value is not specified for this field, it is set to the support team of the CI's product. Optional when status of CI equals "Removed", required otherwise.
        /// </summary>
        [JsonProperty("supportTeamId")]
        public string? SupportTeamId
        {
            get => supportTeamId;
            set => supportTeamId = Set("supportTeamId", value);
        }

        /// <summary>
        /// System identifier of the configuration item.
        /// </summary>
        [JsonProperty("systemID")]
        public string? SystemID
        {
            get => systemID;
            set => systemID = Set("systemID", value);
        }

        /// <summary>
        /// <c>true</c> for license certificates that are not valid indefinitely.
        /// </summary>
        [JsonProperty("temporaryLicense")]
        public bool? TemporaryLicense
        {
            get => temporaryLicense;
            set => temporaryLicense = Set("temporaryLicense", value);
        }

        /// <summary>
        /// Identifiers of the users of this configuration item.
        /// </summary>
        [JsonProperty("userIds")]
        public List<string>? UserIds
        {
            get => userIds;
            set => userIds = Set("userIds", value);
        }

        /// <summary>
        /// The date through which the warranty coverage for the configuration item is valid. The warranty expires at the end of this day.
        /// </summary>
        [JsonProperty("warrantyExpiryDate")]
        public DateOnly? WarrantyExpiryDate
        {
            get => warrantyExpiryDate;
            set => warrantyExpiryDate = Set("warrantyExpiryDate", value);
        }

        /// <summary>
        /// The person who will be responsible for coordinating the workflows that will be generated automatically in accordance with the recurrence schedule.
        /// </summary>
        [JsonProperty("workflowManagerId")]
        public string? WorkflowManagerId
        {
            get => workflowManagerId;
            set => workflowManagerId = Set("workflowManagerId", value);
        }

        /// <summary>
        /// The workflow template that is used to periodically maintain the configuration item.
        /// </summary>
        [JsonProperty("workflowTemplateId")]
        public string? WorkflowTemplateId
        {
            get => workflowTemplateId;
            set => workflowTemplateId = Set("workflowTemplateId", value);
        }

        /// <summary>
        /// Relations to other configuration items.
        /// </summary>
        [JsonProperty("newCiRelations")]
        public List<CiRelationInput>? NewCiRelations
        {
            get => newCiRelations;
            set => newCiRelations = Set("newCiRelations", value);
        }

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
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Identifiers of relations other configuration items to remove from the configuration item.
        /// </summary>
        [JsonProperty("ciRelationsToDelete")]
        public List<string>? CiRelationsToDelete
        {
            get => ciRelationsToDelete;
            set => ciRelationsToDelete = Set("ciRelationsToDelete", value);
        }
    }
}
