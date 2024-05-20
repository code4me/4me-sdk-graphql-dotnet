using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/task/">Task</see> object.
    /// </summary>
    public class Task : Node, IHasAutomationRules, IHasLifeCycleState, IHasNotes, IHasSprintBacklogItems, IHasTimeEntries
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(IsDefaultQueryProperty = true)]
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
        /// The date and time at which the task is currently expected to be assigned.
        /// </summary>
        [JsonProperty("anticipatedAssignmentAt")]
        public DateTime? AnticipatedAssignmentAt { get; internal set; }

        [JsonProperty("approvals")]
        internal NodeCollection<TaskApproval>? ApprovalsCollection { get; set; }

        /// <summary>
        /// Approvals of the task.
        /// </summary>
        public DataList<TaskApproval>? Approvals
        {
            get => ApprovalsCollection?.Data;
        }

        /// <summary>
        /// Automatically set to the current date and time when the task is assigned.
        /// </summary>
        [JsonProperty("assignedAt")]
        public DateTime? AssignedAt { get; internal set; }

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
        /// The category of the task. Risk &amp; impact tasks are used to help plan workflows. Approval tasks are used to collect approvals for workflows. These can be used at various stages in the life of the workflow. Implementation tasks are added to workflows for development, installation, configuration, test, transfer and administrative work that needs to be completed for the implementation of the workflow.
        /// </summary>
        [JsonProperty("category"), Sdk4meField(IsDefaultQueryProperty = true)]
        public TaskCategory? Category { get; internal set; }

        /// <summary>
        /// The names of the checked items from any of the checklists in the instructions.
        /// </summary>
        [JsonProperty("checkedItems")]
        public List<string>? CheckedItems { get; internal set; }

        /// <summary>
        /// The date and time at which the task is expected to be completed.
        /// </summary>
        [JsonProperty("completionTargetAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? CompletionTargetAt { get; internal set; }

        [JsonProperty("configurationItems")]
        internal NodeCollection<ConfigurationItem>? ConfigurationItemsCollection { get; set; }

        /// <summary>
        /// Configuration items of the task.
        /// </summary>
        public DataList<ConfigurationItem>? ConfigurationItems
        {
            get => ConfigurationItemsCollection?.Data;
        }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(IsDefaultQueryProperty = true)]
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
        /// The task that will be assigned in case this task is failed or rejected.
        /// </summary>
        [JsonProperty("failureTask")]
        public Task? FailureTask { get; internal set; }

        /// <summary>
        /// Automatically set to the date and time at which the task is saved with the status "Failed", "Rejected", "Completed", "Approved" or "Canceled".
        /// </summary>
        [JsonProperty("finishedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? FinishedAt { get; internal set; }

        /// <summary>
        /// The extent to which the service instances related to the task will be impacted by the completion of the task.
        /// </summary>
        [JsonProperty("impact"), Sdk4meField(IsDefaultQueryProperty = true)]
        public TaskImpact? Impact { get; internal set; }

        /// <summary>
        /// Used to provide instructions for the person to whom the task will be assigned.
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
        /// The person to whom the task is to be assigned. This field's value is <c>null</c> in case of an approval task with multiple approvers.
        /// </summary>
        [JsonProperty("member"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Person? Member { get; internal set; }

        /// <summary>
        /// Influences the behavior of the note field on completion or approval.
        /// </summary>
        [JsonProperty("noteBehavior")]
        public TaskNoteBehavior? NoteBehavior { get; internal set; }

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
        /// The order line related to the fulfillment task.
        /// </summary>
        [JsonProperty("orderLine")]
        public ShopOrderLine? OrderLine { get; internal set; }

        /// <summary>
        /// The PDF design associated with the task.
        /// </summary>
        [JsonProperty("pdfDesign")]
        public PdfDesign? PdfDesign { get; internal set; }

        /// <summary>
        /// The phase of the workflow to which the task belongs.
        /// </summary>
        [JsonProperty("phase")]
        public WorkflowPhase? Phase { get; internal set; }

        /// <summary>
        /// The number of minutes it is expected to take for the task to be completed following its assignment, or following its fixed start date and time if the Start no earlier than field is filled out.
        /// </summary>
        [JsonProperty("plannedDuration")]
        public long? PlannedDuration { get; internal set; }

        /// <summary>
        /// The number of minutes the member is expected to spend working on the task.
        /// </summary>
        [JsonProperty("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        /// <summary>
        /// Whether the provider indicates not to be accountable for the affected SLAs linked to the requests that are linked to the workflow of a task that was created based on the template.
        /// </summary>
        [JsonProperty("providerNotAccountable")]
        public bool? ProviderNotAccountable { get; internal set; }

        /// <summary>
        /// Automatically set to the number of times that an approval task is rejected.
        /// </summary>
        [JsonProperty("rejectionCount")]
        public long? RejectionCount { get; internal set; }

        /// <summary>
        /// The request related to this task. When this request is solved the task will be completed.
        /// </summary>
        [JsonProperty("request")]
        public Request? Request { get; internal set; }

        /// <summary>
        /// The service instance that should be used to create the request for this task.
        /// </summary>
        [JsonProperty("requestServiceInstance")]
        public ServiceInstance? RequestServiceInstance { get; internal set; }

        /// <summary>
        /// The request template that should be used to create the request for this task.
        /// </summary>
        [JsonProperty("requestTemplate")]
        public RequestTemplate? RequestTemplate { get; internal set; }

        /// <summary>
        /// The number of approvers who need to have provided their approval before the status of the task gets updated to "Approved".
        /// </summary>
        [JsonProperty("requiredApprovals")]
        public long? RequiredApprovals { get; internal set; }

        /// <summary>
        /// The number of minutes it took to complete this problem, which is calculated as the difference between the <c>assignedAt</c> and <c>finishedAt</c> values.
        /// </summary>
        [JsonProperty("resolutionDuration")]
        public long? ResolutionDuration { get; internal set; }

        [JsonProperty("serviceInstances")]
        internal NodeCollection<ServiceInstance>? ServiceInstancesCollection { get; set; }

        /// <summary>
        /// Service instances of the task.
        /// </summary>
        public DataList<ServiceInstance>? ServiceInstances
        {
            get => ServiceInstancesCollection?.Data;
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(IsDefaultQueryProperty = true)]
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
        /// Only used when work on the task may not start before a specific date and time.
        /// </summary>
        [JsonProperty("startAt")]
        public DateTime? StartAt { get; internal set; }

        /// <summary>
        /// The Status field is used to select the current status of the task.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(IsDefaultQueryProperty = true)]
        public TaskStatus? Status { get; internal set; }

        /// <summary>
        /// A short description of the objective of the task.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// The supplier organization that has been asked to assist with the completion of the task.
        /// </summary>
        [JsonProperty("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The identifier under which the request to help with the execution of the task has been registered at the supplier organization. If the supplier provided a link to the request, enter the entire URL in this field.
        /// </summary>
        [JsonProperty("supplierRequestID")]
        public string? SupplierRequestID { get; internal set; }

        /// <summary>
        /// The record ID as displayed in the UI
        /// </summary>
        [JsonProperty("taskId")]
        public string? TaskId { get; internal set; }

        /// <summary>
        /// The team to which the task is to be assigned.
        /// </summary>
        [JsonProperty("team"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Team? Team { get; internal set; }

        /// <summary>
        /// The task template that was used to register the task.
        /// </summary>
        [JsonProperty("template")]
        public TaskTemplate? Template { get; internal set; }

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
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Whether the task has been marked as urgent.
        /// </summary>
        [JsonProperty("urgent")]
        public bool? Urgent { get; internal set; }

        /// <summary>
        /// The date and time at which the status of the task is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
        /// </summary>
        [JsonProperty("waitingUntil")]
        public DateTime? WaitingUntil { get; internal set; }

        /// <summary>
        /// The workflow to which the task belongs.
        /// </summary>
        [JsonProperty("workflow")]
        public Workflow? Workflow { get; internal set; }

        /// <summary>
        /// When set to true, the completion target of the task is calculated using a 24x7 calendar rather than normal business hours.
        /// </summary>
        [JsonProperty("workHoursAre24x7")]
        public bool? WorkHoursAre24x7 { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(ApprovalsCollection?.GetQueryPageInfo("approvals", depth + 1));
            retval.AddRange(AutomationRulesCollection?.GetQueryPageInfo("automationRules", depth + 1));
            retval.AddRange(ConfigurationItemsCollection?.GetQueryPageInfo("configurationItems", depth + 1));
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(InstructionsAttachmentsCollection?.GetQueryPageInfo("instructionsAttachments", depth + 1));
            retval.AddRange(NotesCollection?.GetQueryPageInfo("notes", depth + 1));
            retval.AddRange(ServiceInstancesCollection?.GetQueryPageInfo("serviceInstances", depth + 1));
            retval.AddRange(SprintBacklogItemsCollection?.GetQueryPageInfo("sprintBacklogItems", depth + 1));
            retval.AddRange(TimeEntriesCollection?.GetQueryPageInfo("timeEntries", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Approvals?.AddRange((data as Task)?.Approvals);
            AutomationRules?.AddRange((data as Task)?.AutomationRules);
            ConfigurationItems?.AddRange((data as Task)?.ConfigurationItems);
            CustomFieldsAttachments?.AddRange((data as Task)?.CustomFieldsAttachments);
            InstructionsAttachments?.AddRange((data as Task)?.InstructionsAttachments);
            Notes?.AddRange((data as Task)?.Notes);
            ServiceInstances?.AddRange((data as Task)?.ServiceInstances);
            SprintBacklogItems?.AddRange((data as Task)?.SprintBacklogItems);
            TimeEntries?.AddRange((data as Task)?.TimeEntries);
        }
    }
}
