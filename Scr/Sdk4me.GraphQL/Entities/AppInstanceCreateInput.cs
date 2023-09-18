namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/appinstancecreateinput/">AppInstanceCreateInput</see> object.
    /// </summary>
    public class AppInstanceCreateInput : PropertyChangeSet
    {
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private string? customerRepresentativeId;
        private bool? disabled;
        private bool? enabledByCustomer;
        private bool? suspended;
        private string? suspensionComment;
        private string? clientMutationId;
        private string? customerAccountId;
        private string? appOfferingId;

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
        /// Identifier of the contact person of customer regarding this app instance.
        /// </summary>
        [JsonProperty("customerRepresentativeId")]
        public string? CustomerRepresentativeId
        {
            get => customerRepresentativeId;
            set => customerRepresentativeId = Set("customerRepresentativeId", value);
        }

        /// <summary>
        /// Whether the app instance is currently enabled for this customer.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Whether the customer has enabled this app instance.
        /// </summary>
        [JsonProperty("enabledByCustomer")]
        public bool? EnabledByCustomer
        {
            get => enabledByCustomer;
            set => enabledByCustomer = Set("enabledByCustomer", value);
        }

        /// <summary>
        /// Whether the app instance is currently suspended for this customer.
        /// </summary>
        [JsonProperty("suspended")]
        public bool? Suspended
        {
            get => suspended;
            set => suspended = Set("suspended", value);
        }

        /// <summary>
        /// Extra information why the app instance is currently suspended for this customer.
        /// </summary>
        [JsonProperty("suspensionComment")]
        public string? SuspensionComment
        {
            get => suspensionComment;
            set => suspensionComment = Set("suspensionComment", value);
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
        /// Identifier of the account this app instance is for.
        /// </summary>
        [JsonProperty("customerAccountId")]
        public string? CustomerAccountId
        {
            get => customerAccountId;
            set => customerAccountId = Set("customerAccountId", value);
        }

        /// <summary>
        /// Identifier of the app offering to create an instance of.
        /// </summary>
        [JsonProperty("appOfferingId")]
        public string? AppOfferingId
        {
            get => appOfferingId;
            set => appOfferingId = Set("appOfferingId", value);
        }
    }
}
