namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/release/">Release</see> object.
    /// </summary>
    public class Release : Node, IHasLifeCycleState, IHasNotes
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the release is set to the status "Completed".
        /// </summary>
        [JsonProperty("completedAt"), Sdk4meField(true)]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// Automatically set based on the completion reason of the release's workflows.
        /// </summary>
        [JsonProperty("completionReason")]
        public WorkflowCompletionReason? CompletionReason { get; internal set; }

        /// <summary>
        /// The target date and time of the last task of the workflows that are related to the release.
        /// </summary>
        [JsonProperty("completionTargetAt"), Sdk4meField(true)]
        public DateTime? CompletionTargetAt { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        [JsonProperty("customFields")]
        public CustomFieldCollection? CustomFields { get; internal set; }

        [JsonProperty("customFieldsAttachments")]
        internal NodeCollection<Attachment>? CustomFieldsAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public DataList<Attachment>? CustomFieldsAttachments
        {
            get => CustomFieldsAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The maximum impact level that is selected in the tasks of the workflows that are related to the release. This indicates the maximum extent to which a service instance will be impacted by the implementation of the release.
        /// </summary>
        [JsonProperty("impact"), Sdk4meField(true)]
        public TaskImpact? Impact { get; internal set; }

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [JsonProperty("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// The person who is responsible for coordinating the implementation of the release. The person must have the release Manager role.
        /// </summary>
        [JsonProperty("manager")]
        public Person? Manager { get; internal set; }

        [JsonProperty("notes")]
        internal NodeCollection<Note>? NotesCollection { get; set; }

        /// <summary>
        /// Notes of the record.
        /// </summary>
        public DataList<Note>? Notes
        {
            get => NotesCollection?.Data;
        }

        /// <summary>
        /// The record ID as displayed in the UI
        /// </summary>
        [JsonProperty("releaseId")]
        public string? ReleaseId { get; internal set; }

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
        /// Automatically set based on the status of the release's workflows.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public WorkflowStatus? Status { get; internal set; }

        /// <summary>
        /// A short description of the objective of the release.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        [JsonProperty("workflows")]
        internal NodeCollection<Workflow>? WorkflowsCollection { get; set; }

        /// <summary>
        /// Workflows of the release.
        /// </summary>
        public DataList<Workflow>? Workflows
        {
            get => WorkflowsCollection?.Data;
        }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(NotesCollection?.GetQueryPageInfo("notes", depth + 1));
            retval.AddRange(WorkflowsCollection?.GetQueryPageInfo("workflows", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            CustomFieldsAttachments?.AddRange((data as Release)?.CustomFieldsAttachments);
            Notes?.AddRange((data as Release)?.Notes);
            Workflows?.AddRange((data as Release)?.Workflows);
        }
    }
}
