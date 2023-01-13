namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/shoporderlineupdateinput/">ShopOrderLineUpdateInput</see> object.
    /// </summary>
    public class ShopOrderLineUpdateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private string? requestedForId;
        private string? shopArticleId;
        private long? quantity;
        private List<AddressInput>? newAddresses;
        private string? id;
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
        /// The person for whom the shop order line was submitted.
        /// </summary>
        [JsonProperty("requestedForId")]
        public string? RequestedForId
        {
            get => requestedForId;
            set => requestedForId = Set("requestedForId", value);
        }

        /// <summary>
        /// The shop article that is ordered.
        /// </summary>
        [JsonProperty("shopArticleId")]
        public string? ShopArticleId
        {
            get => shopArticleId;
            set => shopArticleId = Set("shopArticleId", value);
        }

        /// <summary>
        /// The number units ordered.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity
        {
            get => quantity;
            set => quantity = Set("quantity", value);
        }

        /// <summary>
        /// New or updated addresses of the shop order line.
        /// </summary>
        [JsonProperty("newAddresses")]
        public List<AddressInput>? NewAddresses
        {
            get => newAddresses;
            set => newAddresses = Set("newAddresses", value);
        }

        /// <summary>
        /// The node identifier of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
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
