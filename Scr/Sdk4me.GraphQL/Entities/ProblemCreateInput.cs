namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/problemcreateinput/">ProblemCreateInput</see> object.
    /// </summary>
    public class ProblemCreateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private string? uiExtensionId;
        private long? timeSpent;
        private string? timeSpentEffortClassId;
        private string? agileBoardId;
        private string? agileBoardColumnId;
        private long? agileBoardColumnPosition;
        private string? productBacklogId;
        private long? productBacklogPosition;
        private long? productBacklogEstimate;
        private DateTime? analysisTargetAt;
        private ProblemCategory? category;
        private string? changeId;
        private string? workflowId;
        private ProblemImpact? impact;
        private string? knowledgeArticleId;
        private bool? knownError;
        private string? managerId;
        private string? memberId;
        private string? note;
        private string? projectId;
        private string? serviceId;
        private ProblemStatus? status;
        private string? subject;
        private string? supplierId;
        private string? supplierRequestID;
        private string? teamId;
        private bool? urgent;
        private DateTime? waitingUntil;
        private string? workaround;
        private List<string>? configurationItemIds;
        private List<string>? requestIds;
        private List<string>? serviceInstanceIds;
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
        /// User interface extension that is to be applied to the record.
        /// </summary>
        [JsonProperty("uiExtensionId")]
        public string? UiExtensionId
        {
            get => uiExtensionId;
            set => uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// The time that you have spent working on the request since you started to work on it or, if you already entered some time for this request, since you last added your time spent in it.
        /// </summary>
        [JsonProperty("timeSpent")]
        public long? TimeSpent
        {
            get => timeSpent;
            set => timeSpent = Set("timeSpent", value);
        }

        /// <summary>
        /// The effort class that best reflects the type of effort for which time spent is being registered.
        /// </summary>
        [JsonProperty("timeSpentEffortClassId")]
        public string? TimeSpentEffortClassId
        {
            get => timeSpentEffortClassId;
            set => timeSpentEffortClassId = Set("timeSpentEffortClassId", value);
        }

        /// <summary>
        /// Identifier of the board this item is placed on.
        /// </summary>
        [JsonProperty("agileBoardId")]
        public string? AgileBoardId
        {
            get => agileBoardId;
            set => agileBoardId = Set("agileBoardId", value);
        }

        /// <summary>
        /// Identifier of the column this item is placed in.
        /// </summary>
        [JsonProperty("agileBoardColumnId")]
        public string? AgileBoardColumnId
        {
            get => agileBoardColumnId;
            set => agileBoardColumnId = Set("agileBoardColumnId", value);
        }

        /// <summary>
        /// The (one based) position of this item in its column.
        /// </summary>
        [JsonProperty("agileBoardColumnPosition")]
        public long? AgileBoardColumnPosition
        {
            get => agileBoardColumnPosition;
            set => agileBoardColumnPosition = Set("agileBoardColumnPosition", value);
        }

        /// <summary>
        /// Identifier of the product backlog this item is placed on.
        /// </summary>
        [JsonProperty("productBacklogId")]
        public string? ProductBacklogId
        {
            get => productBacklogId;
            set => productBacklogId = Set("productBacklogId", value);
        }

        /// <summary>
        /// The (one based) position of this item on the backlog.
        /// </summary>
        [JsonProperty("productBacklogPosition")]
        public long? ProductBacklogPosition
        {
            get => productBacklogPosition;
            set => productBacklogPosition = Set("productBacklogPosition", value);
        }

        /// <summary>
        /// Estimate of the relative size of this item on the product backlog.
        /// </summary>
        [JsonProperty("productBacklogEstimate")]
        public long? ProductBacklogEstimate
        {
            get => productBacklogEstimate;
            set => productBacklogEstimate = Set("productBacklogEstimate", value);
        }

        /// <summary>
        /// Used to specify when the current assignee needs to have completed the root cause analysis of the problem.
        /// </summary>
        [JsonProperty("analysisTargetAt")]
        public DateTime? AnalysisTargetAt
        {
            get => analysisTargetAt;
            set => analysisTargetAt = Set("analysisTargetAt", value);
        }

        /// <summary>
        /// The category of the problem.
        /// </summary>
        [JsonProperty("category")]
        public ProblemCategory? Category
        {
            get => category;
            set => category = Set("category", value);
        }

        /// <summary>
        /// DEPRECATED: Use "workflowId" instead.
        /// </summary>
        [JsonProperty("changeId")]
        public string? ChangeId
        {
            get => changeId;
            set => changeId = Set("changeId", value);
        }

        /// <summary>
        /// Identifier of the workflow that will implement the proposed permanent solution for the problem.
        /// </summary>
        [JsonProperty("workflowId")]
        public string? WorkflowId
        {
            get => workflowId;
            set => workflowId = Set("workflowId", value);
        }

        /// <summary>
        /// Used to select the extent to which the service is impacted when an incident occurs that is caused by the problem. Defaults to `none`.
        /// </summary>
        [JsonProperty("impact")]
        public ProblemImpact? Impact
        {
            get => impact;
            set => impact = Set("impact", value);
        }

        /// <summary>
        /// Identifier of the knowledge article which instructions should be followed to resolve incidents caused by this problem until a structural solution has been implemented.
        /// </summary>
        [JsonProperty("knowledgeArticleId")]
        public string? KnowledgeArticleId
        {
            get => knowledgeArticleId;
            set => knowledgeArticleId = Set("knowledgeArticleId", value);
        }

        /// <summary>
        /// Whether the underlying cause of the problem has been found and a temporary workaround has been proposed.
        /// </summary>
        [JsonProperty("knownError")]
        public bool? KnownError
        {
            get => knownError;
            set => knownError = Set("knownError", value);
        }

        /// <summary>
        /// Identifier of the person who is responsible for coordinating the problem through root cause analysis, the proposal of a structural solution and ultimately its closure. Defaults to the current authenticated person.
        /// </summary>
        [JsonProperty("managerId")]
        public string? ManagerId
        {
            get => managerId;
            set => managerId = Set("managerId", value);
        }

        /// <summary>
        /// Identifier of the person to whom the problem is to be assigned.
        /// </summary>
        [JsonProperty("memberId")]
        public string? MemberId
        {
            get => memberId;
            set => memberId = Set("memberId", value);
        }

        /// <summary>
        /// Detailed description of the symptoms that are caused by the problem.
        /// </summary>
        [JsonProperty("note")]
        public string? Note
        {
            get => note;
            set => note = Set("note", value);
        }

        /// <summary>
        /// Identifier of the project to link the problem to.
        /// </summary>
        [JsonProperty("projectId")]
        public string? ProjectId
        {
            get => projectId;
            set => projectId = Set("projectId", value);
        }

        /// <summary>
        /// Identifier of the service in which instance(s) the problem resides.
        /// </summary>
        [JsonProperty("serviceId")]
        public string? ServiceId
        {
            get => serviceId;
            set => serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// The current status of the problem.
        /// </summary>
        [JsonProperty("status")]
        public ProblemStatus? Status
        {
            get => status;
            set => status = Set("status", value);
        }

        /// <summary>
        /// A short description of the symptoms that the problem causes.
        /// </summary>
        [JsonProperty("subject")]
        public string? Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// Identifier of the supplier organization that has been asked for a solution to the problem.
        /// </summary>
        [JsonProperty("supplierId")]
        public string? SupplierId
        {
            get => supplierId;
            set => supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// The identifier under which the request to help with the solution of the problem has been registered at the supplier organization.
        /// </summary>
        [JsonProperty("supplierRequestID")]
        public string? SupplierRequestID
        {
            get => supplierRequestID;
            set => supplierRequestID = Set("supplierRequestID", value);
        }

        /// <summary>
        /// Identifier of the team to which the problem is to be assigned. Defaults to the support team of the service if no team or member is present.
        /// </summary>
        [JsonProperty("teamId")]
        public string? TeamId
        {
            get => teamId;
            set => teamId = Set("teamId", value);
        }

        /// <summary>
        /// Whether the problem has been marked as urgent.
        /// </summary>
        [JsonProperty("urgent")]
        public bool? Urgent
        {
            get => urgent;
            set => urgent = Set("urgent", value);
        }

        /// <summary>
        /// The date and time at which the status of the problem is to be updated from `waiting_for` to `assigned`. This field is available only when the Status field is set to `waiting_for`.
        /// </summary>
        [JsonProperty("waitingUntil")]
        public DateTime? WaitingUntil
        {
            get => waitingUntil;
            set => waitingUntil = Set("waitingUntil", value);
        }

        /// <summary>
        /// Used to describe the temporary workaround that should be applied to resolve incidents caused by this problem until a structural solution has been implemented.
        /// </summary>
        [JsonProperty("workaround")]
        public string? Workaround
        {
            get => workaround;
            set => workaround = Set("workaround", value);
        }

        /// <summary>
        /// Identifiers of configuration items of this problem.
        /// </summary>
        [JsonProperty("configurationItemIds")]
        public List<string>? ConfigurationItemIds
        {
            get => configurationItemIds;
            set => configurationItemIds = Set("configurationItemIds", value);
        }

        /// <summary>
        /// Identifiers of requests of this problem.
        /// </summary>
        [JsonProperty("requestIds")]
        public List<string>? RequestIds
        {
            get => requestIds;
            set => requestIds = Set("requestIds", value);
        }

        /// <summary>
        /// Identifiers of service instances of this problem.
        /// </summary>
        [JsonProperty("serviceInstanceIds")]
        public List<string>? ServiceInstanceIds
        {
            get => serviceInstanceIds;
            set => serviceInstanceIds = Set("serviceInstanceIds", value);
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
