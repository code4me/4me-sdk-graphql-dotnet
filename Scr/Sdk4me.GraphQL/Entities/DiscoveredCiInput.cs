using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/discoveredciinput/">DiscoveredCiInput</see> object.
    /// </summary>
    public class DiscoveredCiInput : PropertyChangeSet
    {
        private DiscoveredCiRelationInput? ciRelations;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
#if NET6_0_OR_GREATER
        private DateOnly? endOfSupportDate;
#else
        private DateTime? endOfSupportDate;
#endif
#if NET6_0_OR_GREATER
        private DateOnly? inUseSince;
#else
        private DateTime? inUseSince;
#endif
        private string? label;
        private DateTime? lastSeenAt;
        private string? location;
        private DiscoveredItemMetaData? meta;
        private string name;
        private long? nrOfCores;
        private long? nrOfProcessors;
        private string? operatingSystemId;
        private decimal? purchaseValue;
        private string? purchaseValueCurrency;
        private decimal? ramAmount;
        private string? remarks;
        private string? serialNr;
        private string? service;
        private string sourceID;
        private CiStatus? status;
        private string? systemID;
        private List<string>? userIds;
#if NET6_0_OR_GREATER
        private DateOnly? warrantyExpiryDate;
#else
        private DateTime? warrantyExpiryDate;
#endif

        /// <summary>
        /// Relations to other configuration items.
        /// </summary>
        [JsonProperty("ciRelations")]
        public DiscoveredCiRelationInput? CiRelations
        {
            get => ciRelations;
            set => ciRelations = Set("ciRelations", value);
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
        /// The date at which the support for this configuration item ends.
        /// </summary>
        [JsonProperty("endOfSupportDate")]
#if NET6_0_OR_GREATER
        public DateOnly? EndOfSupportDate
#else
        public DateTime? EndOfSupportDate
#endif
        {
            get => endOfSupportDate;
            set => endOfSupportDate = Set("endOfSupportDate", value);
        }

        /// <summary>
        /// The date on which the expense for the configuration item (CI) was incurred or, if the CI is depreciated over time, the date on which the depreciation was started. This is typically the invoice date.
        /// </summary>
        [JsonProperty("inUseSince")]
#if NET6_0_OR_GREATER
        public DateOnly? InUseSince
#else
        public DateTime? InUseSince
#endif
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
        /// The name or number of the room in which the CI is located, if it concerns a hardware CI.
        /// </summary>
        [JsonProperty("location")]
        public string? Location
        {
            get => location;
            set => location = Set("location", value);
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
        /// Name of the configuration item.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsRequiredForMutation = true)]
        public string Name
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
        public decimal? RamAmount
        {
            get => ramAmount;
            set => ramAmount = Set("ramAmount", value);
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
        /// Serial number of the configuration item. The concatenation of <c>product</c>'s' <c>brand</c> and <c>serialNr</c> must be unique within a 4me account.
        /// </summary>
        [JsonProperty("serialNr")]
        public string? SerialNr
        {
            get => serialNr;
            set => serialNr = Set("serialNr", value);
        }

        /// <summary>
        /// The name of the service the configuration item is, or will be, a part of. When no value is specified for this field, it is set to the service of the CI's product.
        /// </summary>
        [JsonProperty("service")]
        public string? Service
        {
            get => service;
            set => service = Set("service", value);
        }

        /// <summary>
        /// The unique identifier of the configuration item in an external system
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(IsRequiredForMutation = true)]
        public string SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
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
        /// System identifier of the configuration item.
        /// </summary>
        [JsonProperty("systemID")]
        public string? SystemID
        {
            get => systemID;
            set => systemID = Set("systemID", value);
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
#if NET6_0_OR_GREATER
        public DateOnly? WarrantyExpiryDate
#else
        public DateTime? WarrantyExpiryDate
#endif
        {
            get => warrantyExpiryDate;
            set => warrantyExpiryDate = Set("warrantyExpiryDate", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredCiInput"/> class without providing the required values.
        /// </summary>
        public DiscoveredCiInput()
        {
            name = string.Empty;
            sourceID = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredCiInput"/> class.
        /// </summary>
        /// <param name="name">Name of the configuration item.</param>
        /// <param name="sourceID">The unique identifier of the configuration item in an external system</param>
        public DiscoveredCiInput(string name, string sourceID)
        {
            this.name = Set("name", name);
            this.sourceID = Set("sourceID", sourceID);
        }
    }
}
