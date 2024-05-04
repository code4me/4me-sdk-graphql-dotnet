using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/productcreateinput/">ProductCreateInput</see> object.
    /// </summary>
    public class ProductCreateInput : PropertyChangeSet
    {
        private string? brand;
        private string? category;
        private string? clientMutationId;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private ProductDepreciationMethod? depreciationMethod;
        private bool? disabled;
        private string? financialOwnerId;
        private string? model;
        private string? name;
        private string? pictureUri;
        private string? productID;
        private long? rate;
        private RecurrenceInput? recurrence;
        private string? remarks;
        private List<AttachmentInput>? remarksAttachments;
        private decimal? salvageValue;
        private string? salvageValueCurrency;
        private string? serviceId;
        private string? source;
        private string? sourceID;
        private string? supplierId;
        private string? supportTeamId;
        private string? uiExtensionId;
        private long? usefulLife;
        private string? workflowManagerId;
        private string? workflowTemplateId;

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
        /// The appropriate product category for the product.
        /// </summary>
        [JsonProperty("category")]
        public string? Category
        {
            get => category;
            set => category = Set("category", value);
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
        /// <br>Used to specify whether or not configuration items that are based on the product are typically depreciated and if so, which depreciation method is normally applied. Valid values are:</br>
        /// <br>• <c>not_depreciated</c>: Not Depreciated</br>
        /// <br>• <c>double_declining_balance</c>: Double Declining Balance</br>
        /// <br>• <c>reducing_balance</c>: Reducing Balance (or Diminishing Value)</br>
        /// <br>• <c>straight_line</c>: Straight Line (or Prime Cost)</br>
        /// <br>• <c>sum_of_the_years_digits</c>: Sum of the Year's Digits</br>
        /// </summary>
        [JsonProperty("depreciationMethod")]
        public ProductDepreciationMethod? DepreciationMethod
        {
            get => depreciationMethod;
            set => depreciationMethod = Set("depreciationMethod", value);
        }

        /// <summary>
        /// Whether the product may no longer be used to register new configuration items.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Identifier of the internal organization which budget is normally used to obtain the product.
        /// </summary>
        [JsonProperty("financialOwnerId")]
        public string? FinancialOwnerId
        {
            get => financialOwnerId;
            set => financialOwnerId = Set("financialOwnerId", value);
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
        /// The name of the product. Fill out the Brand, Model, Product ID (optional) and Category fields to automatically generate a name based on the values entered in these fields.
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
        /// The unique identifier of the product that is used by the manufacturer. The concatenation of <c>brand</c> and <c>productID</c> must be unique within a 4me account.
        /// </summary>
        [JsonProperty("productID")]
        public string? ProductID
        {
            get => productID;
            set => productID = Set("productID", value);
        }

        /// <summary>
        /// The yearly rate that should normally be applied to calculate the depreciation of configuration items that are based on the product using the reducing balance (or diminishing value) method.
        /// </summary>
        [JsonProperty("rate")]
        public long? Rate
        {
            get => rate;
            set => rate = Set("rate", value);
        }

        /// <summary>
        /// Recurrence for maintenance of configuration items created from the product.
        /// </summary>
        [JsonProperty("recurrence")]
        public RecurrenceInput? Recurrence
        {
            get => recurrence;
            set => recurrence = Set("recurrence", value);
        }

        /// <summary>
        /// Any additional information about the product that might prove useful.
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
        /// The value of this configuration item at the end of its useful life (i.e. at the end of its depreciation period). When a value is not specified for this field, it is set to zero.
        /// </summary>
        [JsonProperty("salvageValue")]
        public decimal? SalvageValue
        {
            get => salvageValue;
            set => salvageValue = Set("salvageValue", value);
        }

        /// <summary>
        /// <br>The currency of the salvage value attributed to this configuration item.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("salvageValueCurrency")]
        public string? SalvageValueCurrency
        {
            get => salvageValueCurrency;
            set => salvageValueCurrency = Set("salvageValueCurrency", value);
        }

        /// <summary>
        /// Identifier of the Service which Service Instances would typically include the product.
        /// </summary>
        [JsonProperty("serviceId")]
        public string? ServiceId
        {
            get => serviceId;
            set => serviceId = Set("serviceId", value);
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
        /// Identifier of the organization from which the product is typically obtained. If the product is developed internally, select the internal organization that develops it. Note that a lease company should be selected in this field if the product is normally leased.
        /// </summary>
        [JsonProperty("supplierId")]
        public string? SupplierId
        {
            get => supplierId;
            set => supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// Identifier of the team responsible for maintaining the product's information in the configuration management database (CMDB).
        /// </summary>
        [JsonProperty("supportTeamId")]
        public string? SupportTeamId
        {
            get => supportTeamId;
            set => supportTeamId = Set("supportTeamId", value);
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
        /// The number of years within which configuration items that are based on the product are typically depreciated.
        /// </summary>
        [JsonProperty("usefulLife")]
        public long? UsefulLife
        {
            get => usefulLife;
            set => usefulLife = Set("usefulLife", value);
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
        /// The workflow template that is used to periodically maintain configuration items created from the product.
        /// </summary>
        [JsonProperty("workflowTemplateId")]
        public string? WorkflowTemplateId
        {
            get => workflowTemplateId;
            set => workflowTemplateId = Set("workflowTemplateId", value);
        }
    }
}
