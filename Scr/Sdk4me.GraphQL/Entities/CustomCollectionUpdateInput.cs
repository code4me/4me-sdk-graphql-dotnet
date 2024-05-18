using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/customcollectionupdateinput/">CustomCollectionUpdateInput</see> object.
    /// </summary>
    public class CustomCollectionUpdateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private List<string>? collectionElementsToDelete;
        private string? description;
        private List<AttachmentInput>? descriptionAttachments;
        private bool? disabled;
        private string id;
        private string? name;
        private List<CustomCollectionElementInput>? newCollectionElements;
        private string? reference;
        private string? source;
        private string? sourceID;
        private string? uiExtensionId;

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
        /// Identifiers of elements to remove from the collection.
        /// </summary>
        [JsonProperty("collectionElementsToDelete")]
        public List<string>? CollectionElementsToDelete
        {
            get => collectionElementsToDelete;
            set => collectionElementsToDelete = Set("collectionElementsToDelete", value);
        }

        /// <summary>
        /// Description of the collection.
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
        /// Whether the collection may not be used for new custom views.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
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
        /// Name of the collection.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Elements of this custom collection.
        /// </summary>
        [JsonProperty("newCollectionElements")]
        public List<CustomCollectionElementInput>? NewCollectionElements
        {
            get => newCollectionElements;
            set => newCollectionElements = Set("newCollectionElements", value);
        }

        /// <summary>
        /// The Reference field defaults to the Name field value, written in lower case characters and with all spaces replaced by the underscore character. This reference can be used to link the collection to an element using the 4me APIs or the 4me Import functionality.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference
        {
            get => reference;
            set => reference = Set("reference", value);
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
        /// UI extension that is to be applied to the record.
        /// </summary>
        [JsonProperty("uiExtensionId")]
        public string? UiExtensionId
        {
            get => uiExtensionId;
            set => uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomCollectionUpdateInput"/> class.
        /// </summary>
        /// <param name="id">The node ID of the record to update.</param>
        public CustomCollectionUpdateInput(string id)
        {
            this.id = Set("id", id);
        }
    }
}
