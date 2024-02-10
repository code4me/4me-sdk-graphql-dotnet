namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/projecttaskupdateinput/">ProjectTaskUpdateInput</see> object.
    /// </summary>
    public class ProjectTaskUpdateInput : PropertyChangeSet
    {
        private string? agileBoardColumnId;
        private long? agileBoardColumnPosition;
        private string? agileBoardId;
        private DateTime? assignedAt;
        private List<string>? assignmentsToDelete;
        private ProjectTaskCategory? category;
        private string? clientMutationId;
        private CustomFieldCollection? customFields;
        private List<AttachmentInput>? customFieldsAttachments;
        private DateTime? deadline;
        private string? id;
        private string? instructions;
        private List<ProjectTaskAssignmentInput>? newAssignments;
        private string? note;
        private string? pdfDesignId;
        private string? phaseId;
        private long? plannedDuration;
        private long? plannedEffort;
        private List<string>? predecessorIds;
        private long? requiredApprovals;
        private string? skillPoolId;
        private string? source;
        private string? sourceID;
        private DateTime? startAt;
        private ProjectTaskStatus? status;
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
        /// Automatically set to the current date and time when the project task is assigned.
        /// </summary>
        [JsonProperty("assignedAt")]
        public DateTime? AssignedAt
        {
            get => assignedAt;
            set => assignedAt = Set("assignedAt", value);
        }

        /// <summary>
        /// Identifiers of assignments to remove from the project task.
        /// </summary>
        [JsonProperty("assignmentsToDelete")]
        public List<string>? AssignmentsToDelete
        {
            get => assignmentsToDelete;
            set => assignmentsToDelete = Set("assignmentsToDelete", value);
        }

        /// <summary>
        /// The category of the project task. Activity tasks are used to assign project-related work to people. Approval tasks are used to collect approvals for projects. Milestones are used to mark specific points along a project's implementation plan.
        /// </summary>
        [JsonProperty("category")]
        public ProjectTaskCategory? Category
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
        /// The date and time at which the milestone needs to have been reached.
        /// </summary>
        [JsonProperty("deadline")]
        public DateTime? Deadline
        {
            get => deadline;
            set => deadline = Set("deadline", value);
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
        /// Used to provide instructions for the person(s) to whom the project task will be assigned.
        /// </summary>
        [JsonProperty("instructions")]
        public string? Instructions
        {
            get => instructions;
            set => instructions = Set("instructions", value);
        }

        /// <summary>
        /// Assignments of the project task.
        /// </summary>
        [JsonProperty("newAssignments")]
        public List<ProjectTaskAssignmentInput>? NewAssignments
        {
            get => newAssignments;
            set => newAssignments = Set("newAssignments", value);
        }

        /// <summary>
        /// Used to provide information for the person to whom the project task is assigned. It is also used to provide a summary of the actions that have been taken to date and the results of these actions.
        /// </summary>
        [JsonProperty("note")]
        public string? Note
        {
            get => note;
            set => note = Set("note", value);
        }

        /// <summary>
        /// Identifier of the PDF design to link to the task.
        /// </summary>
        [JsonProperty("pdfDesignId")]
        public string? PdfDesignId
        {
            get => pdfDesignId;
            set => pdfDesignId = Set("pdfDesignId", value);
        }

        /// <summary>
        /// Identifier of the phase of the project to which the project task belongs.
        /// </summary>
        [JsonProperty("phaseId")]
        public string? PhaseId
        {
            get => phaseId;
            set => phaseId = Set("phaseId", value);
        }

        /// <summary>
        /// The number of minutes it is expected to take for the project task to be completed following its assignment, or following its fixed start date and time if the Start no earlier than field is filled out.
        /// </summary>
        [JsonProperty("plannedDuration")]
        public long? PlannedDuration
        {
            get => plannedDuration;
            set => plannedDuration = Set("plannedDuration", value);
        }

        /// <summary>
        /// The number of minutes the team is expected to spend working on the project task.
        /// </summary>
        [JsonProperty("plannedEffort")]
        public long? PlannedEffort
        {
            get => plannedEffort;
            set => plannedEffort = Set("plannedEffort", value);
        }

        /// <summary>
        /// Identifiers of the predecessors of the project task.
        /// </summary>
        [JsonProperty("predecessorIds")]
        public List<string>? PredecessorIds
        {
            get => predecessorIds;
            set => predecessorIds = Set("predecessorIds", value);
        }

        /// <summary>
        /// The number of assignees who need to have provided their approval before the status of the project task gets updated to "Approved".
        /// </summary>
        [JsonProperty("requiredApprovals")]
        public long? RequiredApprovals
        {
            get => requiredApprovals;
            set => requiredApprovals = Set("requiredApprovals", value);
        }

        /// <summary>
        /// Skill pool that represents the specific expertise needed to complete the task.
        /// </summary>
        [JsonProperty("skillPoolId")]
        public string? SkillPoolId
        {
            get => skillPoolId;
            set => skillPoolId = Set("skillPoolId", value);
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
        /// Only used when work on the project task may not start before a specific date and time.
        /// </summary>
        [JsonProperty("startAt")]
        public DateTime? StartAt
        {
            get => startAt;
            set => startAt = Set("startAt", value);
        }

        /// <summary>
        /// The current status of the project task.
        /// </summary>
        [JsonProperty("status")]
        public ProjectTaskStatus? Status
        {
            get => status;
            set => status = Set("status", value);
        }

        /// <summary>
        /// A short description of the objective of the project task.
        /// </summary>
        [JsonProperty("subject")]
        public string? Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// Identifiers of the successors of the project task.
        /// </summary>
        [JsonProperty("successorIds")]
        public List<string>? SuccessorIds
        {
            get => successorIds;
            set => successorIds = Set("successorIds", value);
        }

        /// <summary>
        /// The supplier organization that has been asked to assist with the completion of the project task.
        /// </summary>
        [JsonProperty("supplierId")]
        public string? SupplierId
        {
            get => supplierId;
            set => supplierId = Set("supplierId", value);
        }

        /// <summary>
        /// The identifier under which the request to help with the execution of the project task has been registered at the supplier organization.
        /// </summary>
        [JsonProperty("supplierRequestID")]
        public string? SupplierRequestID
        {
            get => supplierRequestID;
            set => supplierRequestID = Set("supplierRequestID", value);
        }

        /// <summary>
        /// The team to which the project task is to be assigned.
        /// </summary>
        [JsonProperty("teamId")]
        public string? TeamId
        {
            get => teamId;
            set => teamId = Set("teamId", value);
        }

        /// <summary>
        /// The project task template that was used to register the project task.
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
        /// Whether the project task is urgent.
        /// </summary>
        [JsonProperty("urgent")]
        public bool? Urgent
        {
            get => urgent;
            set => urgent = Set("urgent", value);
        }

        /// <summary>
        /// The date and time at which the status of the project task is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
        /// </summary>
        [JsonProperty("waitingUntil")]
        public DateTime? WaitingUntil
        {
            get => waitingUntil;
            set => waitingUntil = Set("waitingUntil", value);
        }

        /// <summary>
        /// When set to true, the completion target of the project task is calculated using a 24x7 calendar rather than normal business hours.
        /// </summary>
        [JsonProperty("workHoursAre24x7")]
        public bool? WorkHoursAre24x7
        {
            get => workHoursAre24x7;
            set => workHoursAre24x7 = Set("workHoursAre24x7", value);
        }
    }
}
