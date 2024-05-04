using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/project/">Project</see> object.
    /// </summary>
    public class Project : Node, IHasLifeCycleState, IHasNotes
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Whether the project has been approved and no longer needs to be considered for funding by portfolio management.
        /// </summary>
        [JsonProperty("budgetAllocated")]
        public bool? BudgetAllocated { get; internal set; }

        /// <summary>
        /// The category of the project.
        /// </summary>
        [JsonProperty("category"), Sdk4meField(true)]
        public string? Category { get; internal set; }

        /// <summary>
        /// Automatically set to the date and time at which the project is saved with the status "Completed".
        /// </summary>
        [JsonProperty("completedAt"), Sdk4meField(true)]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// The appropriate completion reason for the project when it has been completed. It is automatically set to "Complete" when all tasks related to the project have reached the status "Completed", "Approved" or "Canceled".
        /// </summary>
        [JsonProperty("completionReason")]
        public ProjectCompletionReason? CompletionReason { get; internal set; }

        /// <summary>
        /// The target date and time of the last task of the project.
        /// </summary>
        [JsonProperty("completionTargetAt"), Sdk4meField(true)]
        public DateTime? CompletionTargetAt { get; internal set; }

        /// <summary>
        /// The estimated cost of the effort that will be needed from internal employees and/or long-term contractors to implement the project.
        /// </summary>
        [JsonProperty("costOfEffort")]
        public decimal? CostOfEffort { get; internal set; }

        /// <summary>
        /// The estimated cost of all purchases (for equipment, consulting effort, licenses, etc.) needed to implement the project. Recurring costs that will be incurred following the implementation of the project are to be included for the entire ROI calculation period.
        /// </summary>
        [JsonProperty("costOfPurchases")]
        public decimal? CostOfPurchases { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Used to select the organization for which the project is to be implemented.
        /// </summary>
        [JsonProperty("customer")]
        public Organization? Customer { get; internal set; }

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
        /// The estimated number of hours of effort that will be needed from internal employees and/or long-term contractors to implement the project.
        /// </summary>
        [JsonProperty("effort")]
        public long? Effort { get; internal set; }

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
        /// The reason why the project should be considered for implementation.
        /// </summary>
        [JsonProperty("justification")]
        public ProjectJustification? Justification { get; internal set; }

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [JsonProperty("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// The person who is responsible for coordinating the implementation of the project.
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

        [JsonProperty("phases")]
        internal NodeCollection<ProjectPhase>? PhasesCollection { get; set; }

        /// <summary>
        /// Phases of the project.
        /// </summary>
        public DataList<ProjectPhase>? Phases
        {
            get => PhasesCollection?.Data;
        }

        [JsonProperty("problems")]
        internal NodeCollection<Problem>? ProblemsCollection { get; set; }

        /// <summary>
        /// Problems of the project.
        /// </summary>
        public DataList<Problem>? Problems
        {
            get => ProblemsCollection?.Data;
        }

        /// <summary>
        /// Used to indicate which program the project is a part of.
        /// </summary>
        [JsonProperty("program")]
        public string? Program { get; internal set; }

        /// <summary>
        /// The record ID as displayed in the UI
        /// </summary>
        [JsonProperty("projectId"), Sdk4meField(true)]
        public string? ProjectId { get; internal set; }

        [JsonProperty("requests")]
        internal NodeCollection<Request>? RequestsCollection { get; set; }

        /// <summary>
        /// Requests of the project.
        /// </summary>
        public DataList<Request>? Requests
        {
            get => RequestsCollection?.Data;
        }

        /// <summary>
        /// The number of minutes it took to complete this project, which is calculated as the difference between the <c>createdAt</c> and <c>completedAt</c> values.
        /// </summary>
        [JsonProperty("resolutionDuration")]
        public long? ResolutionDuration { get; internal set; }

        /// <summary>
        /// The risk level of the project.
        /// </summary>
        [JsonProperty("riskLevel")]
        public string? RiskLevel { get; internal set; }

        [JsonProperty("risks")]
        internal NodeCollection<Risk>? RisksCollection { get; set; }

        /// <summary>
        /// Risks of the project.
        /// </summary>
        public DataList<Risk>? Risks
        {
            get => RisksCollection?.Data;
        }

        /// <summary>
        /// The estimated return on investment for the project. This percentage is calculated by dividing the value, minus the total costs, by the total costs and multiplying the result by 100.
        /// </summary>
        [JsonProperty("roi")]
        public long? Roi { get; internal set; }

        /// <summary>
        /// The service for which the project will be implemented.
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
        /// Automatically set based on the status of the project's tasks.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public ProjectStatus? Status { get; internal set; }

        /// <summary>
        /// A short description of the objective of the project.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(true)]
        public string? Subject { get; internal set; }

        [JsonProperty("tasks")]
        internal NodeCollection<ProjectTask>? TasksCollection { get; set; }

        /// <summary>
        /// Tasks of the project.
        /// </summary>
        public DataList<ProjectTask>? Tasks
        {
            get => TasksCollection?.Data;
        }

        /// <summary>
        /// <br>The time zone that applies to the selected work hours.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone { get; internal set; }

        /// <summary>
        /// The total estimated cost to implement the project. This is the sum of the estimated cost of effort and cost of purchases.
        /// </summary>
        [JsonProperty("totalCost")]
        public decimal? TotalCost { get; internal set; }

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

        /// <summary>
        /// The estimated financial value that the implementation of the project will deliver for the entire ROI calculation period.
        /// </summary>
        [JsonProperty("value")]
        public decimal? Value { get; internal set; }

        /// <summary>
        /// <br>The currency of the value of this project.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("valueCurrency")]
        public string? ValueCurrency { get; internal set; }

        [JsonProperty("workflows")]
        internal NodeCollection<Workflow>? WorkflowsCollection { get; set; }

        /// <summary>
        /// Workflows of the project.
        /// </summary>
        public DataList<Workflow>? Workflows
        {
            get => WorkflowsCollection?.Data;
        }

        /// <summary>
        /// The calendar that defines the work hours that are to be used to calculate the anticipated assignment and completion target for the tasks of the project.
        /// </summary>
        [JsonProperty("workHours")]
        public Calendar? WorkHours { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(InvoicesCollection?.GetQueryPageInfo("invoices", depth + 1));
            retval.AddRange(NotesCollection?.GetQueryPageInfo("notes", depth + 1));
            retval.AddRange(PhasesCollection?.GetQueryPageInfo("phases", depth + 1));
            retval.AddRange(ProblemsCollection?.GetQueryPageInfo("problems", depth + 1));
            retval.AddRange(RequestsCollection?.GetQueryPageInfo("requests", depth + 1));
            retval.AddRange(RisksCollection?.GetQueryPageInfo("risks", depth + 1));
            retval.AddRange(TasksCollection?.GetQueryPageInfo("tasks", depth + 1));
            retval.AddRange(WorkflowsCollection?.GetQueryPageInfo("workflows", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            CustomFieldsAttachments?.AddRange((data as Project)?.CustomFieldsAttachments);
            Invoices?.AddRange((data as Project)?.Invoices);
            Notes?.AddRange((data as Project)?.Notes);
            Phases?.AddRange((data as Project)?.Phases);
            Problems?.AddRange((data as Project)?.Problems);
            Requests?.AddRange((data as Project)?.Requests);
            Risks?.AddRange((data as Project)?.Risks);
            Tasks?.AddRange((data as Project)?.Tasks);
            Workflows?.AddRange((data as Project)?.Workflows);
        }
    }
}
