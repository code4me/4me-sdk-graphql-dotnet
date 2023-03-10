namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/customcollectioncreateinput/">CustomCollectionCreateInput</see> object.
    /// </summary>
    public class CustomCollectionCreateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private string? uiExtensionId;
        private string? description;
        private bool? disabled;
        private string? name;
        private string? reference;
        private List<CustomCollectionElementInput>? newCollectionElements;
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
        /// User interface extension that is to be applied to the record.
        /// </summary>
        [JsonProperty("uiExtensionId")]
        public string? UiExtensionId
        {
            get => uiExtensionId;
            set => uiExtensionId = Set("uiExtensionId", value);
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
        /// Whether the collection may not be used for new custom views.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
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
        /// The Reference field defaults to the Name field value, written in lower case characters and with all spaces replaced by the underscore character. This reference can be used to link the collection to an element using the 4me APIs or the 4me Import functionality.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference
        {
            get => reference;
            set => reference = Set("reference", value);
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
