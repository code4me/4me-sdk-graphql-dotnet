namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/sprintupdateinput/">SprintUpdateInput</see> object.
    /// </summary>
    public class SprintUpdateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private DateTime? endAt;
        private long? number;
        private string? scrumWorkspaceId;
        private string? description;
        private DateTime? startAt;
        private SprintStatus? status;
        private List<SprintBacklogItemInput>? newSprintBacklogItems;
        private string? id;
        private List<string>? sprintBacklogItemsToDelete;
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
        /// The date and time the sprint ended, or will end.
        /// </summary>
        [JsonProperty("endAt")]
        public DateTime? EndAt
        {
            get => endAt;
            set => endAt = Set("endAt", value);
        }

        /// <summary>
        /// Sequence number of this sprint.
        /// </summary>
        [JsonProperty("number")]
        public long? Number
        {
            get => number;
            set => number = Set("number", value);
        }

        /// <summary>
        /// Identifier of scrum workspace this sprint belongs to.
        /// </summary>
        [JsonProperty("scrumWorkspaceId")]
        public string? ScrumWorkspaceId
        {
            get => scrumWorkspaceId;
            set => scrumWorkspaceId = Set("scrumWorkspaceId", value);
        }

        /// <summary>
        /// Description of this sprint (e.g. goal of the sprint).
        /// </summary>
        [JsonProperty("description")]
        public string? Description
        {
            get => description;
            set => description = Set("description", value);
        }

        /// <summary>
        /// The date and time the sprint started, or will start.
        /// </summary>
        [JsonProperty("startAt")]
        public DateTime? StartAt
        {
            get => startAt;
            set => startAt = Set("startAt", value);
        }

        /// <summary>
        /// The current status of the sprint.
        /// </summary>
        [JsonProperty("status")]
        public SprintStatus? Status
        {
            get => status;
            set => status = Set("status", value);
        }

        /// <summary>
        /// Sprint backlog items of this sprint.
        /// </summary>
        [JsonProperty("newSprintBacklogItems")]
        public List<SprintBacklogItemInput>? NewSprintBacklogItems
        {
            get => newSprintBacklogItems;
            set => newSprintBacklogItems = Set("newSprintBacklogItems", value);
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
        /// Identifiers of sprint backlog items to remove from the sprint.
        /// </summary>
        [JsonProperty("sprintBacklogItemsToDelete")]
        public List<string>? SprintBacklogItemsToDelete
        {
            get => sprintBacklogItemsToDelete;
            set => sprintBacklogItemsToDelete = Set("sprintBacklogItemsToDelete", value);
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
