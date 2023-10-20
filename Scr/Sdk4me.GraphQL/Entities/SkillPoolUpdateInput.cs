namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/skillpoolupdateinput/">SkillPoolUpdateInput</see> object.
    /// </summary>
    public class SkillPoolUpdateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private decimal? costPerHour;
        private string? costPerHourCurrency;
        private bool? disabled;
        private List<string>? effortClassIds;
        private string? id;
        private string? managerId;
        private List<string>? memberIds;
        private string? name;
        private string? pictureUri;
        private string? remarks;
        private List<AttachmentInput>? remarksAttachments;
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
        /// The skill pool's estimated total cost per work hour for the service provider organization.
        /// </summary>
        [JsonProperty("costPerHour")]
        public decimal? CostPerHour
        {
            get => costPerHour;
            set => costPerHour = Set("costPerHour", value);
        }

        /// <summary>
        /// <br>The currency of the cost per hour value attributed to this skill pool.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("costPerHourCurrency")]
        public string? CostPerHourCurrency
        {
            get => costPerHourCurrency;
            set => costPerHourCurrency = Set("costPerHourCurrency", value);
        }

        /// <summary>
        /// Whether the skill pool may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// Effort classes that are linked to the skill pool.
        /// </summary>
        [JsonProperty("effortClassIds")]
        public List<string>? EffortClassIds
        {
            get => effortClassIds;
            set => effortClassIds = Set("effortClassIds", value);
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
        /// The manager or supervisor of the skill pool. This person is able to maintain the information about the skill pool. The manager of a skill pool does not need to be a member of the skill pool.
        /// </summary>
        [JsonProperty("managerId")]
        public string? ManagerId
        {
            get => managerId;
            set => managerId = Set("managerId", value);
        }

        /// <summary>
        /// People that are linked as member to the skill pool.
        /// </summary>
        [JsonProperty("memberIds")]
        public List<string>? MemberIds
        {
            get => memberIds;
            set => memberIds = Set("memberIds", value);
        }

        /// <summary>
        /// The name of the skill pool.
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
        /// Any additional information about the skill pool that might prove useful.
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
    }
}
