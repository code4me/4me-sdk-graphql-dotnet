namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/taskcreateinput/">TaskCreateInput</see> object.
    /// </summary>
    public class TaskCreateInput : PropertyChangeSet
    {
        private string? agileBoardColumnId;
        private long? agileBoardColumnPosition;
        private string? agileBoardId;
        private DateTime? assignedAt;
        private TaskCategory? category;
        private string? clientMutationId;
        private List<string>? configurationItemIds;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private DateTime? finishedAt;
        private TaskImpact? impact;
        private string? instructions;
        private List<AttachmentInput>? instructionsAttachments;
        private string? memberId;
        private List<TaskApprovalInput>? newApprovals;
        private string? note;
        private List<AttachmentInput>? noteAttachments;
        private string? pdfDesignId;
        private long? plannedDuration;
        private long? plannedEffort;
        private List<string>? predecessorIds;
        private string? requestServiceInstanceId;
        private string? requestTemplateId;
        private long? requiredApprovals;
        private List<string>? serviceInstanceIds;
        private string? source;
        private string? sourceID;
        private DateTime? startAt;
        private TaskStatus? status;
        private string? subject;
        private List<string>? successorIds;
        private string? supplierId;
        private string? supplierRequestID;
        private string? teamId;
        private string? templateId;
        private long? timeSpent;
        private string? timeSpentEffortClassId;
        private bool? urgent;
        private DateTime? waitingUntil;
        private string? workflowId;
        private bool? workHoursAre24x7;

        /// <summary>
        /// ID of the column this item is placed in.
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
        /// ID of the board this item is placed on.
        /// </summary>
        [JsonProperty("agileBoardId")]
        public string? AgileBoardId
        {
            get => agileBoardId;
            set => agileBoardId = Set("agileBoardId", value);
        }

        /// <summary>
        /// Automatically set to the current date and time when the task is assigned.
        /// </summary>
        [JsonProperty("assignedAt")]
        public DateTime? AssignedAt
        {
            get => assignedAt;
            set => assignedAt = Set("assignedAt", value);
        }

        /// <summary>
        /// The category of the task. Risk &amp; impact tasks are used to help plan workflows. Approval tasks are used to collect approvals for workflows. These can be used at various stages in the life of the workflow. Implementation tasks are added to workflows for development, installation, configuration, test, transfer and administrative work that needs to be completed for the implementation of the workflow.
        /// </summary>
        [JsonProperty("category")]
        public TaskCategory? Category
        {
            get => category;
            set => category = Set("category", value);
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
        /// Identifiers of the configuration items of the task.
        /// </summary>
        [JsonProperty("configurationItemIds")]
        public List<string>? ConfigurationItemIds
        {
            get => configurationItemIds;
            set => configurationItemIds = Set("configurationItemIds", value);
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
        /// Automatically set to the date and time at which the task is saved with the status "Failed", "Rejected", "Completed", "Approved" or "Canceled".
        /// </summary>
        [JsonProperty("finishedAt")]
        public DateTime? FinishedAt
        {
            get => finishedAt;
            set => finishedAt = Set("finishedAt", value);
        }

        /// <summary>
        /// The extent to which the service instances related to the task will be impacted by the completion of the task.
        /// </summary>
        [JsonProperty("impact")]
        public TaskImpact? Impact
        {
            get => impact;
            set => impact = Set("impact", value);
        }

        /// <summary>
        /// Used to provide instructions for the person to whom the task will be assigned.
        /// </summary>
        [JsonProperty("instructions")]
        public string? Instructions
        {
            get => instructions;
            set => instructions = Set("instructions", value);
        }

        /// <summary>
        /// The attachments used in the <c>instructions</c> field.
        /// </summary>
        [JsonProperty("instructionsAttachments")]
        public List<AttachmentInput>? InstructionsAttachments
        {
            get => instructionsAttachments;
            set => instructionsAttachments = Set("instructionsAttachments", value);
        }

        /// <summary>
        /// Identifier of the person to whom the task is to be assigned. This field's value is <c>null</c> in case of an approval task with multiple approvers.
        /// </summary>
        [JsonProperty("memberId")]
        public string? MemberId
        {
            get => memberId;
            set => memberId = Set("memberId", value);
        }

        /// <summary>
        /// Approvals of the task.
        /// </summary>
        [JsonProperty("newApprovals")]
        public List<TaskApprovalInput>? NewApprovals
        {
            get => newApprovals;
            set => newApprovals = Set("newApprovals", value);
        }

        /// <summary>
        /// Used to provide information for the person to whom the task is assigned. It is also used to provide a summary of the actions that have been taken to date and the results of these actions.
        /// </summary>
        [JsonProperty("note")]
        public string? Note
        {
            get => note;
            set => note = Set("note", value);
        }

        /// <summary>
        /// The attachments used in the <c>note</c> field.
        /// </summary>
        [JsonProperty("noteAttachments")]
        public List<AttachmentInput>? NoteAttachments
        {
            get => noteAttachments;
            set => noteAttachments = Set("noteAttachments", value);
        }

        /// <summary>
        /// Identifier of the PDF design associated with the task.
        /// </summary>
        [JsonProperty("pdfDesignId")]
        public string? PdfDesignId
        {
            get => pdfDesignId;
            set => pdfDesignId = Set("pdfDesignId", value);
        }

        /// <summary>
        /// The number of minutes it is expected to take for the task to be completed following its assignment, or following its fixed start date and time if the Start no earlier than field is filled out.
        /// </summary>
        [JsonProperty("plannedDuration")]
        public long? PlannedDuration
        {
            get => plannedDuration;
            set => plannedDuration = Set("plannedDuration", value);
        }

        /// <summary>
        /// The number of minutes the member is expected to spend working on the task.
        /// </summary>
        [JsonProperty("plannedEffort")]
        public long? PlannedEffort
        {
            get => plannedEffort;
            set => plannedEffort = Set("plannedEffort", value);
        }

        /// <summary>
        /// Identifiers of predecessors of the task.
        /// </summary>
        [JsonProperty("predecessorIds")]
        public List<string>? PredecessorIds
        {
            get => predecessorIds;
            set => predecessorIds = Set("predecessorIds", value);
        }

        /// <summary>
        /// The identifier of the service instance that should be used to create the request for this task.
        /// </summary>
        [JsonProperty("requestServiceInstanceId")]
        public string? RequestServiceInstanceId
        {
            get => requestServiceInstanceId;
            set => requestServiceInstanceId = Set("requestServiceInstanceId", value);
        }

        /// <summary>
        /// The identifier of the request template that should be used to create the request for this task.
        /// </summary>
        [JsonProperty("requestTemplateId")]
        public string? RequestTemplateId
        {
            get => requestTemplateId;
            set => requestTemplateId = Set("requestTemplateId", value);
        }

        /// <summary>
        /// The number of approvers who need to have provided their approval before the status of the task gets updated to "Approved".
        /// </summary>
        [JsonProperty("requiredApprovals")]
        public long? RequiredApprovals
        {
            get => requiredApprovals;
            set => requiredApprovals = Set("requiredApprovals", value);
        }

        /// <summary>
        /// Identifiers of service instances of the task.
        /// </summary>
        [JsonProperty("serviceInstanceIds")]
        public List<string>? ServiceInstanceIds
        {
            get => serviceInstanceIds;
            set => serviceInstanceIds = Set("serviceInstanceIds", value);
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
        /// Only used when work on the task may not start before a specific date and time.
        /// </summary>
        [JsonProperty("startAt")]
        public DateTime? StartAt
        {
            get => startAt;
            set => startAt = Set("startAt", value);
        }

        /// <summary>
        /// The Status field is used to select the current status of the task.
        /// </summary>
        [JsonProperty("status")]
        public TaskStatus? Status
        {
            get => status;
            set => status = Set("status", value);
        }

        /// <summary>
        /// A short description of the objective of the task.
        /// </summary>
        [JsonProperty("subject")]
        public string? Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// Identifiers of successors of the task.
        /// </summary>
        [JsonProperty("successorIds")]
        public List<string>? SuccessorIds
        {
            get => successorIds;
            set => successorIds = Set("successorIds", value);
        }

        /// <summary>
        /// Identifier of the supplier organization that has been asked to assist with the completion of the task.
        /// </summary>
        [JsonProperty("supplierId")]
        public string? SupplierId
        {
            get => supplierId;
            set => supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// The identifier under which the request to help with the execution of the task has been registered at the supplier organization.
        /// </summary>
        [JsonProperty("supplierRequestID")]
        public string? SupplierRequestID
        {
            get => supplierRequestID;
            set => supplierRequestID = Set("supplierRequestID", value);
        }

        /// <summary>
        /// Identifier of the team to which the task is to be assigned.
        /// </summary>
        [JsonProperty("teamId")]
        public string? TeamId
        {
            get => teamId;
            set => teamId = Set("teamId", value);
        }

        /// <summary>
        /// Identifier of the task template that was used to register the task.
        /// </summary>
        [JsonProperty("templateId")]
        public string? TemplateId
        {
            get => templateId;
            set => templateId = Set("templateId", value);
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
        /// Whether the task has been marked as urgent.
        /// </summary>
        [JsonProperty("urgent")]
        public bool? Urgent
        {
            get => urgent;
            set => urgent = Set("urgent", value);
        }

        /// <summary>
        /// The date and time at which the status of the task is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
        /// </summary>
        [JsonProperty("waitingUntil")]
        public DateTime? WaitingUntil
        {
            get => waitingUntil;
            set => waitingUntil = Set("waitingUntil", value);
        }

        /// <summary>
        /// Identifier of the workflow to which the task belongs.
        /// </summary>
        [JsonProperty("workflowId")]
        public string? WorkflowId
        {
            get => workflowId;
            set => workflowId = Set("workflowId", value);
        }

        /// <summary>
        /// When set to true, the completion target of the task is calculated using a 24x7 calendar rather than normal business hours.
        /// </summary>
        [JsonProperty("workHoursAre24x7")]
        public bool? WorkHoursAre24x7
        {
            get => workHoursAre24x7;
            set => workHoursAre24x7 = Set("workHoursAre24x7", value);
        }
    }
}
