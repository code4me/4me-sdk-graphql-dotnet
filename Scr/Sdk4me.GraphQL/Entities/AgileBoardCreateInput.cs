using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/agileboardcreateinput/">AgileBoardCreateInput</see> object.
    /// </summary>
    public class AgileBoardCreateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private List<string>? customerRepresentativeSlaIds;
        private string? description;
        private List<AttachmentInput>? descriptionAttachments;
        private bool? disabled;
        private string? managerId;
        private string name;
        private List<AgileBoardColumnInput>? newColumns;
        private string? pictureUri;
        private string? source;
        private string? sourceID;

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
        /// Identifiers of the service level agreements of which the customer representatives can view this board in Self Service.
        /// </summary>
        [JsonProperty("customerRepresentativeSlaIds")]
        public List<string>? CustomerRepresentativeSlaIds
        {
            get => customerRepresentativeSlaIds;
            set => customerRepresentativeSlaIds = Set("customerRepresentativeSlaIds", value);
        }

        /// <summary>
        /// Description of the agile board.
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
        /// Whether the board may not be used to place items on.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Identifier of the manager of the agile board.
        /// </summary>
        [JsonProperty("managerId")]
        public string? ManagerId
        {
            get => managerId;
            set => managerId = Set("managerId", value);
        }

        /// <summary>
        /// Name of the agile board.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Columns of this agile board.
        /// </summary>
        [JsonProperty("newColumns")]
        public List<AgileBoardColumnInput>? NewColumns
        {
            get => newColumns;
            set => newColumns = Set("newColumns", value);
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
        /// Initializes a new instance of the <see cref="AgileBoardCreateInput"/> class.
        /// </summary>
        /// <param name="name">Name of the agile board.</param>
        public AgileBoardCreateInput(string name)
        {
            this.name = Set("name", name);
        }
    }
}
