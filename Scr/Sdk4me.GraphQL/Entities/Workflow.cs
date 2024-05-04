using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/workflow/">Workflow</see> object.
    /// </summary>
    public class Workflow : Node, IHasAutomationRules, IHasLifeCycleState, IHasNotes
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The total time that has already been spent on the workflow. This is the sum of the time spent on each of the workflow's tasks and the requests and problems that are related to the workflow.
        /// </summary>
        [JsonProperty("actualEffort")]
        public long? ActualEffort { get; internal set; }

        /// <summary>
        /// The actual effort as a percentage of the planned effort.
        /// </summary>
        [JsonProperty("actualVsPlannedEffortPercentage")]
        public long? ActualVsPlannedEffortPercentage { get; internal set; }

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
        /// The category of the workflow.
        /// </summary>
        [JsonProperty("category"), Sdk4meField(true)]
        public WorkflowCategory? Category { get; internal set; }

        /// <summary>
        /// The date and time at which the workflow is saved with the status "Completed".
        /// </summary>
        [JsonProperty("completedAt"), Sdk4meField(true)]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// Used to select the appropriate completion reason for the workflow when it has been completed. It is automatically set to "Complete" when all tasks related to the workflow have reached the status "Completed", "Approved" or "Canceled".
        /// </summary>
        [JsonProperty("completionReason")]
        public WorkflowCompletionReason? CompletionReason { get; internal set; }

        /// <summary>
        /// Shows the target date and time of the last task of the workflow.
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
        /// The maximum impact level that is selected in the tasks that are a part of the workflow. This indicates the maximum extent to which the service is impacted when the implementation tasks that are related to the workflow are executed.
        /// </summary>
        [JsonProperty("impact"), Sdk4meField(true)]
        public TaskImpact? Impact { get; internal set; }

        [JsonProperty("invoices")]
        internal NodeCollection<Invoice>? InvoicesCollection { get; set; }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        public DataList<Invoice>? Invoices
        {
            get => InvoicesCollection?.Data;
        }

        /// <summary>
        /// The reason why the workflow was requested.
        /// </summary>
        [JsonProperty("justification")]
        public WorkflowJustification? Justification { get; internal set; }

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [JsonProperty("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// Who is responsible for coordinating the implementation of the workflow. If a manager is not specified for a new workflow, the API user is selected in the Manager field by default.
        /// </summary>
        [JsonProperty("manager"), Sdk4meField(true)]
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

        [JsonProperty("phases")]
        internal NodeCollection<WorkflowPhase>? PhasesCollection { get; set; }

        /// <summary>
        /// Phases of the workflow.
        /// </summary>
        public DataList<WorkflowPhase>? Phases
        {
            get => PhasesCollection?.Data;
        }

        /// <summary>
        /// The total planned effort of the workflow. This is the sum of the planned effort (or planned duration if the planned effort is empty) of the workflow's tasks.
        /// </summary>
        [JsonProperty("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        [JsonProperty("problems")]
        internal NodeCollection<Problem>? ProblemsCollection { get; set; }

        /// <summary>
        /// All problems of this workflow.
        /// </summary>
        public DataList<Problem>? Problems
        {
            get => ProblemsCollection?.Data;
        }

        /// <summary>
        /// Linked project
        /// </summary>
        [JsonProperty("project"), Sdk4meField(true)]
        public Project? Project { get; internal set; }

        /// <summary>
        /// The release that the workflow is a part of.
        /// </summary>
        [JsonProperty("release"), Sdk4meField(true)]
        public Release? Release { get; internal set; }

        [JsonProperty("requests")]
        internal NodeCollection<Request>? RequestsCollection { get; set; }

        /// <summary>
        /// All requests of this workflow.
        /// </summary>
        public DataList<Request>? Requests
        {
            get => RequestsCollection?.Data;
        }

        /// <summary>
        /// The number of minutes it took to complete this workflow, which is calculated as the difference between the <c>createdAt</c> and <c>completedAt</c> values.
        /// </summary>
        [JsonProperty("resolutionDuration")]
        public long? ResolutionDuration { get; internal set; }

        /// <summary>
        /// The service that will directly be affected by the workflow implementation, or in case of an emergency change, the service that was directly affected by the workflow implementation.
        /// </summary>
        [JsonProperty("service"), Sdk4meField(true)]
        public Service? Service { get; internal set; }

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
        /// The date and time at which the Status field of the first tasks of the workflow will automatically be set to "Assigned".
        /// </summary>
        [JsonProperty("startAt"), Sdk4meField(true)]
        public DateTime? StartAt { get; internal set; }

        /// <summary>
        /// Automatically set based on the status of the workflow's tasks.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public WorkflowStatus? Status { get; internal set; }

        /// <summary>
        /// A short description of the objective of the workflow.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(true)]
        public string? Subject { get; internal set; }

        [JsonProperty("tasks")]
        internal NodeCollection<Task>? TasksCollection { get; set; }

        /// <summary>
        /// All tasks of this workflow.
        /// </summary>
        public DataList<Task>? Tasks
        {
            get => TasksCollection?.Data;
        }

        /// <summary>
        /// The workflow template that was used to register the workflow.
        /// </summary>
        [JsonProperty("template"), Sdk4meField(true)]
        public WorkflowTemplate? Template { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The record ID as displayed in the UI
        /// </summary>
        [JsonProperty("workflowId")]
        public string? WorkflowId { get; internal set; }

        /// <summary>
        /// Used to indicate the type of the workflow.
        /// </summary>
        [JsonProperty("workflowType")]
        public string? WorkflowType { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(AutomationRulesCollection?.GetQueryPageInfo("automationRules", depth + 1));
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(InvoicesCollection?.GetQueryPageInfo("invoices", depth + 1));
            retval.AddRange(NotesCollection?.GetQueryPageInfo("notes", depth + 1));
            retval.AddRange(PhasesCollection?.GetQueryPageInfo("phases", depth + 1));
            retval.AddRange(ProblemsCollection?.GetQueryPageInfo("problems", depth + 1));
            retval.AddRange(RequestsCollection?.GetQueryPageInfo("requests", depth + 1));
            retval.AddRange(TasksCollection?.GetQueryPageInfo("tasks", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            AutomationRules?.AddRange((data as Workflow)?.AutomationRules);
            CustomFieldsAttachments?.AddRange((data as Workflow)?.CustomFieldsAttachments);
            Invoices?.AddRange((data as Workflow)?.Invoices);
            Notes?.AddRange((data as Workflow)?.Notes);
            Phases?.AddRange((data as Workflow)?.Phases);
            Problems?.AddRange((data as Workflow)?.Problems);
            Requests?.AddRange((data as Workflow)?.Requests);
            Tasks?.AddRange((data as Workflow)?.Tasks);
        }
    }
}
