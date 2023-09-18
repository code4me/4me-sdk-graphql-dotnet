namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/productbacklogcreateinput/">ProductBacklogCreateInput</see> object.
    /// </summary>
    public class ProductBacklogCreateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private string? pictureUri;
        private bool? disabled;
        private string? description;
        private List<AttachmentInput>? descriptionAttachments;
        private string? productOwnerId;
        private string? clientMutationId;
        private string? name;

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
        /// Whether the backlog may not be used to place items on.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Description of the product backlog.
        /// </summary>
        [JsonProperty("description")]
        public string? Description
        {
            get => description;
            set => description = Set("description", value);
        }

        /// <summary>
        /// The attachments used in the <c>description</c> field.
        /// </summary>
        [JsonProperty("descriptionAttachments")]
        public List<AttachmentInput>? DescriptionAttachments
        {
            get => descriptionAttachments;
            set => descriptionAttachments = Set("descriptionAttachments", value);
        }

        /// <summary>
        /// Identifier of the person responsible for maximizing the value of the work done based on this product backlog.
        /// </summary>
        [JsonProperty("productOwnerId")]
        public string? ProductOwnerId
        {
            get => productOwnerId;
            set => productOwnerId = Set("productOwnerId", value);
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
        /// Name of the product backlog.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }
    }
}
