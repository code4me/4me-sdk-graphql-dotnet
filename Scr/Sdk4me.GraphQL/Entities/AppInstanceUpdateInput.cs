using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/appinstanceupdateinput/">AppInstanceUpdateInput</see> object.
    /// </summary>
    public class AppInstanceUpdateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private string? customerRepresentativeId;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private bool? disabled;
        private bool? enabledByCustomer;
        private string id;
        private bool? suspended;
        private string? suspensionComment;

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
        /// Identifier of the contact person of customer regarding this app instance.
        /// </summary>
        [JsonProperty("customerRepresentativeId")]
        public string? CustomerRepresentativeId
        {
            get => customerRepresentativeId;
            set => customerRepresentativeId = Set("customerRepresentativeId", value);
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
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string ID
        {
            get => id;
            set => id = Set("id", value);
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
        /// Initializes a new instance of the <see cref="AppInstanceUpdateInput"/> class.
        /// </summary>
        /// <param name="id">The node ID of the record to update.</param>
        public AppInstanceUpdateInput(string id)
        {
            this.id = Set("id", id);
        }
    }
}
