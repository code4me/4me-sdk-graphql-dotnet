namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projecttask/">ProjectTask</see> object.
    /// </summary>
    public class ProjectTask : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Board this item is placed on.
        /// </summary>
        [JsonProperty("agileBoard")]
        public AgileBoard? AgileBoard { get; internal set; }

        /// <summary>
        /// Column this item is placed in.
        /// </summary>
        [JsonProperty("agileBoardColumn")]
        public AgileBoardColumn? AgileBoardColumn { get; internal set; }

        /// <summary>
        /// The (one based) position of this item in its column.
        /// </summary>
        [JsonProperty("agileBoardColumnPosition")]
        public long? AgileBoardColumnPosition { get; internal set; }

        /// <summary>
        /// The date and time at which the project task is currently expected to be assigned.
        /// </summary>
        [JsonProperty("anticipatedAssignmentAt")]
        public DateTime? AnticipatedAssignmentAt { get; internal set; }

        /// <summary>
        /// Automatically set to the current date and time when the project task is assigned.
        /// </summary>
        [JsonProperty("assignedAt")]
        public DateTime? AssignedAt { get; internal set; }

        [JsonProperty("assignments")]
        internal NodeCollection<ProjectTaskAssignment>? AssignmentsCollection { get; set; }

        /// <summary>
        /// Assignments of the project task.
        /// </summary>
        public DataList<ProjectTaskAssignment>? Assignments
        {
            get => AssignmentsCollection?.Data;
        }

        [JsonProperty("automationRules")]
        internal NodeCollection<AutomationRule>? AutomationRulesCollection { get; set; }

        /// <summary>
        /// Automation rules associated with this record.
        /// </summary>
        public DataList<AutomationRule>? AutomationRules
        {
            get => AutomationRulesCollection?.Data;
        }

        /// <summary>
        /// The category of the project task. Activity tasks are used to assign project-related work to people. Approval tasks are used to collect approvals for projects. Milestones are used to mark specific points along a project's implementation plan.
        /// </summary>
        [JsonProperty("category"), Sdk4meField(true)]
        public ProjectTaskCategory? Category { get; internal set; }

        /// <summary>
        /// The date and time at which the project task is expected to be completed.
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
        /// The date and time at which the milestone needs to have been reached.
        /// </summary>
        [JsonProperty("deadline")]
        public DateTime? Deadline { get; internal set; }

        /// <summary>
        /// The Finished field is automatically set to the date and time at which the project task is saved with the status "Failed", "Rejected", "Completed", "Approved" or "Canceled".
        /// </summary>
        [JsonProperty("finishedAt"), Sdk4meField(true)]
        public DateTime? FinishedAt { get; internal set; }

        /// <summary>
        /// Used to provide instructions for the person(s) to whom the project task will be assigned.
        /// </summary>
        [JsonProperty("instructions")]
        public string? Instructions { get; internal set; }

        [JsonProperty("instructionsAttachments")]
        internal NodeCollection<Attachment>? InstructionsAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Instructions field.
        /// </summary>
        public DataList<Attachment>? InstructionsAttachments
        {
            get => InstructionsAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [JsonProperty("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// Influences the behavior of the note field on completion or approval.
        /// </summary>
        [JsonProperty("noteBehavior")]
        public ProjectTaskNoteBehavior? NoteBehavior { get; internal set; }

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
        /// The PDF design associated with the task.
        /// </summary>
        [JsonProperty("pdfDesign")]
        public PdfDesign? PdfDesign { get; internal set; }

        /// <summary>
        /// The phase of the project to which the project task belongs.
        /// </summary>
        [JsonProperty("phase")]
        public ProjectPhase? Phase { get; internal set; }

        /// <summary>
        /// The number of minutes it is expected to take for the project task to be completed following its assignment, or following its fixed start date and time if the Start no earlier than field is filled out.
        /// </summary>
        [JsonProperty("plannedDuration")]
        public long? PlannedDuration { get; internal set; }

        /// <summary>
        /// The number of minutes the team is expected to spend working on the project task.
        /// </summary>
        [JsonProperty("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        [JsonProperty("predecessors")]
        internal NodeCollection<ProjectTask>? PredecessorsCollection { get; set; }

        /// <summary>
        /// Predecessors of the project task.
        /// </summary>
        public DataList<ProjectTask>? Predecessors
        {
            get => PredecessorsCollection?.Data;
        }

        /// <summary>
        /// The project to which the project task belongs.
        /// </summary>
        [JsonProperty("project")]
        public Project? Project { get; internal set; }

        /// <summary>
        /// The record identifier as displayed in the user interface.
        /// </summary>
        [JsonProperty("projectTaskId")]
        public string? ProjectTaskId { get; internal set; }

        /// <summary>
        /// The number of assignees who need to have provided their approval before the status of the project task gets updated to "Approved".
        /// </summary>
        [JsonProperty("requiredApprovals")]
        public long? RequiredApprovals { get; internal set; }

        /// <summary>
        /// The number of minutes it took to complete this project task, which is calculated as the difference between the `assignedAt` and `finishedAt` values.
        /// </summary>
        [JsonProperty("resolutionDuration")]
        public long? ResolutionDuration { get; internal set; }

        /// <summary>
        /// Skill pool that represents the specific expertise needed to complete the task.
        /// </summary>
        [JsonProperty("skillPool")]
        public SkillPool? SkillPool { get; internal set; }

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

        [JsonProperty("sprintBacklogItems")]
        internal NodeCollection<SprintBacklogItem>? SprintBacklogItemsCollection { get; set; }

        /// <summary>
        /// Sprint backlog items associated with this object.
        /// </summary>
        public DataList<SprintBacklogItem>? SprintBacklogItems
        {
            get => SprintBacklogItemsCollection?.Data;
        }

        /// <summary>
        /// Only used when work on the project task may not start before a specific date and time.
        /// </summary>
        [JsonProperty("startAt")]
        public DateTime? StartAt { get; internal set; }

        /// <summary>
        /// The current status of the project task.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public ProjectTaskStatus? Status { get; internal set; }

        /// <summary>
        /// A short description of the objective of the project task.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(true)]
        public string? Subject { get; internal set; }

        [JsonProperty("successors")]
        internal NodeCollection<ProjectTask>? SuccessorsCollection { get; set; }

        /// <summary>
        /// Successors of the project task.
        /// </summary>
        public DataList<ProjectTask>? Successors
        {
            get => SuccessorsCollection?.Data;
        }

        /// <summary>
        /// The supplier organization that has been asked to assist with the completion of the project task.
        /// </summary>
        [JsonProperty("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The identifier under which the request to help with the execution of the project task has been registered at the supplier organization. If the supplier provided a link to the request, enter the entire URL in this field.
        /// </summary>
        [JsonProperty("supplierRequestID")]
        public string? SupplierRequestID { get; internal set; }

        /// <summary>
        /// The team to which the project task is to be assigned.
        /// </summary>
        [JsonProperty("team")]
        public Team? Team { get; internal set; }

        /// <summary>
        /// The project task template that was used to register the project task.
        /// </summary>
        [JsonProperty("template")]
        public ProjectTaskTemplate? Template { get; internal set; }

        [JsonProperty("timeEntries")]
        internal NodeCollection<TimeEntry>? TimeEntriesCollection { get; set; }

        /// <summary>
        /// Time entries for this record.
        /// </summary>
        public DataList<TimeEntry>? TimeEntries
        {
            get => TimeEntriesCollection?.Data;
        }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the `createdAt` value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Whether the project task is urgent.
        /// </summary>
        [JsonProperty("urgent")]
        public bool? Urgent { get; internal set; }

        /// <summary>
        /// The date and time at which the status of the project task is to be updated from `waiting_for` to `assigned`. This field is available only when the Status field is set to `waiting_for`.
        /// </summary>
        [JsonProperty("waitingUntil")]
        public DateTime? WaitingUntil { get; internal set; }

        /// <summary>
        /// When set to true, the completion target of the project task is calculated using a 24x7 calendar rather than normal business hours.
        /// </summary>
        [JsonProperty("workHoursAre24x7")]
        public bool? WorkHoursAre24x7 { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(AssignmentsCollection?.GetQueryPageInfo("assignments", depth + 1));
            retval.AddRange(AutomationRulesCollection?.GetQueryPageInfo("automationRules", depth + 1));
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(InstructionsAttachmentsCollection?.GetQueryPageInfo("instructionsAttachments", depth + 1));
            retval.AddRange(NotesCollection?.GetQueryPageInfo("notes", depth + 1));
            retval.AddRange(PredecessorsCollection?.GetQueryPageInfo("predecessors", depth + 1));
            retval.AddRange(SprintBacklogItemsCollection?.GetQueryPageInfo("sprintBacklogItems", depth + 1));
            retval.AddRange(SuccessorsCollection?.GetQueryPageInfo("successors", depth + 1));
            retval.AddRange(TimeEntriesCollection?.GetQueryPageInfo("timeEntries", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Assignments?.AddRange((data as ProjectTask)?.Assignments);
            AutomationRules?.AddRange((data as ProjectTask)?.AutomationRules);
            CustomFieldsAttachments?.AddRange((data as ProjectTask)?.CustomFieldsAttachments);
            InstructionsAttachments?.AddRange((data as ProjectTask)?.InstructionsAttachments);
            Notes?.AddRange((data as ProjectTask)?.Notes);
            Predecessors?.AddRange((data as ProjectTask)?.Predecessors);
            SprintBacklogItems?.AddRange((data as ProjectTask)?.SprintBacklogItems);
            Successors?.AddRange((data as ProjectTask)?.Successors);
            TimeEntries?.AddRange((data as ProjectTask)?.TimeEntries);
        }
    }
}
