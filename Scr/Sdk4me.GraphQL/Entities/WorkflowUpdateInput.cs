namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/workflowupdateinput/">WorkflowUpdateInput</see> object.
    /// </summary>
    public class WorkflowUpdateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private WorkflowCategory? category;
        private string? workflowType;
        private WorkflowCompletionReason? completionReason;
        private WorkflowJustification? justification;
        private string? managerId;
        private string? note;
        private string? projectId;
        private string? releaseId;
        private string? serviceId;
        private DateTime? startAt;
        private WorkflowStatus? status;
        private string? subject;
        private string? templateId;
        private List<string>? requestIds;
        private List<string>? problemIds;
        private string? clientMutationId;
        private string? id;

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
        /// The category of the workflow.
        /// </summary>
        [JsonProperty("category")]
        public WorkflowCategory? Category
        {
            get => category;
            set => category = Set("category", value);
        }

        /// <summary>
        /// Used to indicate whether the workflow needs to be implemented following the procedure steps for application changes or for infrastructure changes.
        /// </summary>
        [JsonProperty("workflowType")]
        public string? WorkflowType
        {
            get => workflowType;
            set => workflowType = Set("workflowType", value);
        }

        /// <summary>
        /// Used to select the appropriate completion reason for the workflow when it has been completed. It is automatically set to "Complete" when all tasks related to the workflow have reached the status "Completed", "Approved" or "Canceled".
        /// </summary>
        [JsonProperty("completionReason")]
        public WorkflowCompletionReason? CompletionReason
        {
            get => completionReason;
            set => completionReason = Set("completionReason", value);
        }

        /// <summary>
        /// The reason why the change was requested.
        /// </summary>
        [JsonProperty("justification")]
        public WorkflowJustification? Justification
        {
            get => justification;
            set => justification = Set("justification", value);
        }

        /// <summary>
        /// Who is responsible for coordinating the implementation of the workflow. If a manager is not specified for a new workflow, the API user is selected in the Manager field by default.
        /// </summary>
        [JsonProperty("managerId")]
        public string? ManagerId
        {
            get => managerId;
            set => managerId = Set("managerId", value);
        }

        /// <summary>
        /// High-level description of the result that should be accomplished by the implementation of the workflow. It is also used to add any information that could prove useful for anyone affected by the workflow, including the people whose approval is needed and the specialists who are helping to implement it.
        /// </summary>
        [JsonProperty("note")]
        public string? Note
        {
            get => note;
            set => note = Set("note", value);
        }

        /// <summary>
        /// Linked project
        /// </summary>
        [JsonProperty("projectId")]
        public string? ProjectId
        {
            get => projectId;
            set => projectId = Set("projectId", value);
        }

        /// <summary>
        /// The release that the workflow is a part of.
        /// </summary>
        [JsonProperty("releaseId")]
        public string? ReleaseId
        {
            get => releaseId;
            set => releaseId = Set("releaseId", value);
        }

        /// <summary>
        /// The service that will directly be affected by the workflow implementation, or in case of an emergency change, the service that was directly affected by the workflow implementation.
        /// </summary>
        [JsonProperty("serviceId")]
        public string? ServiceId
        {
            get => serviceId;
            set => serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// The date and time at which the Status field of the first tasks of the workflow will automatically be set to "Assigned".
        /// </summary>
        [JsonProperty("startAt")]
        public DateTime? StartAt
        {
            get => startAt;
            set => startAt = Set("startAt", value);
        }

        /// <summary>
        /// Automatically set based on the status of the workflow's tasks.
        /// </summary>
        [JsonProperty("status")]
        public WorkflowStatus? Status
        {
            get => status;
            set => status = Set("status", value);
        }

        /// <summary>
        /// A short description of the objective of the workflow.
        /// </summary>
        [JsonProperty("subject")]
        public string? Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// The workflow template that was used to register the workflow.
        /// </summary>
        [JsonProperty("templateId")]
        public string? TemplateId
        {
            get => templateId;
            set => templateId = Set("templateId", value);
        }

        /// <summary>
        /// Identifiers of all requests linked to this workflow.
        /// </summary>
        [JsonProperty("requestIds")]
        public List<string>? RequestIds
        {
            get => requestIds;
            set => requestIds = Set("requestIds", value);
        }

        /// <summary>
        /// Identifiers of all problems linked of this workflow.
        /// </summary>
        [JsonProperty("problemIds")]
        public List<string>? ProblemIds
        {
            get => problemIds;
            set => problemIds = Set("problemIds", value);
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
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }
    }
}
