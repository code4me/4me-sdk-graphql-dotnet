namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/scrumworkspace/">ScrumWorkspace</see> object.
    /// </summary>
    public class ScrumWorkspace : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Agile board used to track the progress of this workspace's active sprint.
        /// </summary>
        [JsonProperty("agileBoard")]
        public AgileBoard? AgileBoard { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Additional information about the scrum workspace.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; internal set; }

        [JsonProperty("descriptionAttachments")]
        internal NodeCollection<Attachment>? DescriptionAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the description field.
        /// </summary>
        public DataList<Attachment>? DescriptionAttachments
        {
            get => DescriptionAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Whether the scrum workspace is in use.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Name of the scrum workspace.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

        /// <summary>
        /// Product backlog used when planning sprints.
        /// </summary>
        [JsonProperty("productBacklog")]
        public ProductBacklog? ProductBacklog { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(true)]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// Standard length in weeks of new sprints planned in this scrum workspace.
        /// </summary>
        [JsonProperty("sprintLength")]
        public long? SprintLength { get; internal set; }

        [JsonProperty("sprints")]
        internal NodeCollection<Sprint>? SprintsCollection { get; set; }

        /// <summary>
        /// Sprints of this scrum workspace.
        /// </summary>
        public DataList<Sprint>? Sprints
        {
            get => SprintsCollection?.Data;
        }

        /// <summary>
        /// Team planning their work using this scrum workspace.
        /// </summary>
        [JsonProperty("team")]
        public Team? Team { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the `createdAt` value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(DescriptionAttachmentsCollection?.GetQueryPageInfo("descriptionAttachments", depth + 1));
            retval.AddRange(SprintsCollection?.GetQueryPageInfo("sprints", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            DescriptionAttachments?.AddRange((data as ScrumWorkspace)?.DescriptionAttachments);
            Sprints?.AddRange((data as ScrumWorkspace)?.Sprints);
        }
    }
}
