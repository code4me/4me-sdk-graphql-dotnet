namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/contractcreateinput/">ContractCreateInput</see> object.
    /// </summary>
    public class ContractCreateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private string? uiExtensionId;
        private ContractCategory? category;
        private string? customerId;
        private string? customerRepresentativeId;
        private DateOnly? expiryDate;
        private string? name;
        private DateOnly? noticeDate;
        private string? remarks;
        private DateOnly? startDate;
        private AgreementStatus? status;
        private string? supplierId;
        private string? supplierContactId;
        private string? timeZone;
        private List<string>? configurationItemIds;
        private string? clientMutationId;

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
        /// Values for custom fields to be used by the user interface Extension that is linked to the record.
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
        /// User interface extension that is to be applied to the record.
        /// </summary>
        [JsonProperty("uiExtensionId")]
        public string? UiExtensionId
        {
            get => uiExtensionId;
            set => uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// Used to select the appropriate category for the contract.
        /// </summary>
        [JsonProperty("category")]
        public ContractCategory? Category
        {
            get => category;
            set => category = Set("category", value);
        }

        /// <summary>
        /// Identifier of the organization that pays for the contract.
        /// </summary>
        [JsonProperty("customerId")]
        public string? CustomerId
        {
            get => customerId;
            set => customerId = Set("customerId", value);
        }

        /// <summary>
        /// Identifier of the person who represents the customer of the contract.
        /// </summary>
        [JsonProperty("customerRepresentativeId")]
        public string? CustomerRepresentativeId
        {
            get => customerRepresentativeId;
            set => customerRepresentativeId = Set("customerRepresentativeId", value);
        }

        /// <summary>
        /// <br>The date through which the contract will be active. The contract expires at the end of this day if it is not renewed before then.</br>
        /// <br>When the contract has expired, its status will automatically be set to `expired`.</br>
        /// <br>As long as notice still needs to be given to terminate the contract, the `expiryDate` field is to remain empty.</br>.
        /// </summary>
        [JsonProperty("expiryDate")]
        public DateOnly? ExpiryDate
        {
            get => expiryDate;
            set => expiryDate = Set("expiryDate", value);
        }

        /// <summary>
        /// <br>The name of the contract.</br>
        /// <br>If a unique identifier is given to each contract, then this identifier can be added at the start of the name.</br>
        /// <br>Example:</br>
        /// <br>* 2EGXQ2W – Dell 3-Year ProSupport and Next Business Day Onsite Repair for CMP00035</br>.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// <br>The last day on which the supplier organization can still be contacted to terminate the contract to ensure that it expires on the intended expiry date.</br>
        /// <br>The `noticeDate` field is left empty, and the `expiryDate` field is filled out, when the contract is to expire on a specific date and no notice needs to be given to terminate it.</br>
        /// <br>As long as notice still needs to be given to terminate the contract, the `expiryDate` field is to remain empty.</br>.
        /// </summary>
        [JsonProperty("noticeDate")]
        public DateOnly? NoticeDate
        {
            get => noticeDate;
            set => noticeDate = Set("noticeDate", value);
        }

        /// <summary>
        /// Any additional information about the contract that might prove useful.
        /// </summary>
        [JsonProperty("remarks")]
        public string? Remarks
        {
            get => remarks;
            set => remarks = Set("remarks", value);
        }

        /// <summary>
        /// The first day during which the contract is active.
        /// </summary>
        [JsonProperty("startDate")]
        public DateOnly? StartDate
        {
            get => startDate;
            set => startDate = Set("startDate", value);
        }

        /// <summary>
        /// The current status of the contract.
        /// </summary>
        [JsonProperty("status")]
        public AgreementStatus? Status
        {
            get => status;
            set => status = Set("status", value);
        }

        /// <summary>
        /// Identifier of the organization that has provided the contract to the customer.
        /// </summary>
        [JsonProperty("supplierId")]
        public string? SupplierId
        {
            get => supplierId;
            set => supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// Identifier of the person who represents the supplier of the contract.
        /// </summary>
        [JsonProperty("supplierContactId")]
        public string? SupplierContactId
        {
            get => supplierContactId;
            set => supplierContactId = Set("supplierContactId", value);
        }

        /// <summary>
        /// <br>The time zone that applies to the start date, notice date and expiry date of the contract.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see></br>.
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone
        {
            get => timeZone;
            set => timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// Identifiers of the configuration items of the contract.
        /// </summary>
        [JsonProperty("configurationItemIds")]
        public List<string>? ConfigurationItemIds
        {
            get => configurationItemIds;
            set => configurationItemIds = Set("configurationItemIds", value);
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
    }
}
