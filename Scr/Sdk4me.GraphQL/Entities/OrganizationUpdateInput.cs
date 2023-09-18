namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/organizationupdateinput/">OrganizationUpdateInput</see> object.
    /// </summary>
    public class OrganizationUpdateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private string? pictureUri;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private string? uiExtensionId;
        private bool? businessUnit;
        private string? businessUnitOrganizationId;
        private bool? disabled;
        private string? financialID;
        private string? managerId;
        private string? name;
        private string? parentId;
        private string? region;
        private string? remarks;
        private List<AttachmentInput>? remarksAttachments;
        private string? substituteId;
        private List<string>? timeAllocationIds;
        private List<AddressInput>? newAddresses;
        private List<ContactInput>? newContacts;
        private string? clientMutationId;
        private string? id;
        private List<string>? addressesToDelete;
        private List<string>? contactsToDelete;

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
        /// UI extension that is to be applied to the record.
        /// </summary>
        [JsonProperty("uiExtensionId")]
        public string? UiExtensionId
        {
            get => uiExtensionId;
            set => uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// Whether the organization needs to be treated as a separate entity from a reporting perspective. This checkbox is only available for internal organizations.
        /// </summary>
        [JsonProperty("businessUnit")]
        public bool? BusinessUnit
        {
            get => businessUnit;
            set => businessUnit = Set("businessUnit", value);
        }

        /// <summary>
        /// Refers to itself if the organization is a business unit, or refers to the business unit that the organization belongs to.
        /// </summary>
        [JsonProperty("businessUnitOrganizationId")]
        public string? BusinessUnitOrganizationId
        {
            get => businessUnitOrganizationId;
            set => businessUnitOrganizationId = Set("businessUnitOrganizationId", value);
        }

        /// <summary>
        /// Whether the organization may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// The unique identifier by which the organization is known in the financial system.
        /// </summary>
        [JsonProperty("financialID")]
        public string? FinancialID
        {
            get => financialID;
            set => financialID = Set("financialID", value);
        }

        /// <summary>
        /// The manager of the organization.
        /// </summary>
        [JsonProperty("managerId")]
        public string? ManagerId
        {
            get => managerId;
            set => managerId = Set("managerId", value);
        }

        /// <summary>
        /// The full name of the organization.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The organization's parent organization.
        /// </summary>
        [JsonProperty("parentId")]
        public string? ParentId
        {
            get => parentId;
            set => parentId = Set("parentId", value);
        }

        /// <summary>
        /// <br>Which region the organization belongs to. It is possible to select a previously entered region name or to enter a new one. The Region field of a business unit's child organizations cannot be modified, as it is automatically set to the same value as the Region field of the business unit.</br>
        /// <br>Examples of commonly used region names are:</br>
        /// <br></br>
        /// <br>- Asia Pacific (APAC)</br>
        /// <br>- Europe, Middle East &amp; Africa (EMEA)</br>
        /// <br>- North America (NA)</br>
        /// </summary>
        [JsonProperty("region")]
        public string? Region
        {
            get => region;
            set => region = Set("region", value);
        }

        /// <summary>
        /// Any additional information about the organization that might prove useful.
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
        /// The person who acts as the substitute of the organization's manager.
        /// </summary>
        [JsonProperty("substituteId")]
        public string? SubstituteId
        {
            get => substituteId;
            set => substituteId = Set("substituteId", value);
        }

        /// <summary>
        /// Time allocations of the organization.
        /// </summary>
        [JsonProperty("timeAllocationIds")]
        public List<string>? TimeAllocationIds
        {
            get => timeAllocationIds;
            set => timeAllocationIds = Set("timeAllocationIds", value);
        }

        /// <summary>
        /// New or updated addresses of the organization.
        /// </summary>
        [JsonProperty("newAddresses")]
        public List<AddressInput>? NewAddresses
        {
            get => newAddresses;
            set => newAddresses = Set("newAddresses", value);
        }

        /// <summary>
        /// New or updated contacts of the organization.
        /// </summary>
        [JsonProperty("newContacts")]
        public List<ContactInput>? NewContacts
        {
            get => newContacts;
            set => newContacts = Set("newContacts", value);
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
        /// Identifiers of addresses to remove from the organization.
        /// </summary>
        [JsonProperty("addressesToDelete")]
        public List<string>? AddressesToDelete
        {
            get => addressesToDelete;
            set => addressesToDelete = Set("addressesToDelete", value);
        }

        /// <summary>
        /// Identifiers of contacts to remove from the organization.
        /// </summary>
        [JsonProperty("contactsToDelete")]
        public List<string>? ContactsToDelete
        {
            get => contactsToDelete;
            set => contactsToDelete = Set("contactsToDelete", value);
        }
    }
}
