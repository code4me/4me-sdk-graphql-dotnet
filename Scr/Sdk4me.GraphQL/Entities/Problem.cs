using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/problem/">Problem</see> object.
    /// </summary>
    public class Problem : Node, IHasLifeCycleState, IHasNotes, IHasSprintBacklogItems, IHasTimeEntries
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
        /// Used to specify when the current assignee needs to have completed the root cause analysis of the problem.
        /// </summary>
        [JsonProperty("analysisTargetAt"), Sdk4meField(true)]
        public DateTime? AnalysisTargetAt { get; internal set; }

        /// <summary>
        /// The category of the problem.
        /// </summary>
        [JsonProperty("category")]
        public ProblemCategory? Category { get; internal set; }

        [JsonProperty("configurationItems")]
        internal NodeCollection<ConfigurationItem>? ConfigurationItemsCollection { get; set; }

        /// <summary>
        /// Configuration items of this problem.
        /// </summary>
        public DataList<ConfigurationItem>? ConfigurationItems
        {
            get => ConfigurationItemsCollection?.Data;
        }

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
        /// Used to select the extent to which the service is impacted when an incident occurs that is caused by the problem.
        /// </summary>
        [JsonProperty("impact"), Sdk4meField(true)]
        public ProblemImpact? Impact { get; internal set; }

        /// <summary>
        /// The knowledge article which instructions should be followed to resolve incidents caused by this problem until a structural solution has been implemented.
        /// </summary>
        [JsonProperty("knowledgeArticle")]
        public KnowledgeArticle? KnowledgeArticle { get; internal set; }

        /// <summary>
        /// Whether the underlying cause of the problem has been found and a temporary workaround has been proposed.
        /// </summary>
        [JsonProperty("knownError"), Sdk4meField(true)]
        public bool? KnownError { get; internal set; }

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [JsonProperty("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// Person who is responsible for coordinating the problem through root cause analysis, the proposal of a structural solution and ultimately its closure.
        /// </summary>
        [JsonProperty("manager"), Sdk4meField(true)]
        public Person? Manager { get; internal set; }

        /// <summary>
        /// The person to whom the problem is to be assigned.
        /// </summary>
        [JsonProperty("member"), Sdk4meField(true)]
        public Person? Member { get; internal set; }

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
        /// The number of minutes the member is expected to spend working on the problem.
        /// </summary>
        [JsonProperty("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        /// <summary>
        /// The record ID as displayed in the UI
        /// </summary>
        [JsonProperty("problemId"), Sdk4meField(true)]
        public string? ProblemId { get; internal set; }

        /// <summary>
        /// Product backlog this item is placed on.
        /// </summary>
        [JsonProperty("productBacklog")]
        public ProductBacklog? ProductBacklog { get; internal set; }

        /// <summary>
        /// Estimate of the relative size of this item on the product backlog.
        /// </summary>
        [JsonProperty("productBacklogEstimate")]
        public long? ProductBacklogEstimate { get; internal set; }

        /// <summary>
        /// The (one based) position of this item on the backlog.
        /// </summary>
        [JsonProperty("productBacklogPosition")]
        public long? ProductBacklogPosition { get; internal set; }

        /// <summary>
        /// Used to link the problem to a project.
        /// </summary>
        [JsonProperty("project")]
        public Project? Project { get; internal set; }

        [JsonProperty("requests")]
        internal NodeCollection<Request>? RequestsCollection { get; set; }

        /// <summary>
        /// Requests of this problem.
        /// </summary>
        public DataList<Request>? Requests
        {
            get => RequestsCollection?.Data;
        }

        /// <summary>
        /// The number of minutes it took to complete this problem, which is calculated as the difference between the <c>createdAt</c> and <c>solvedAt</c> values.
        /// </summary>
        [JsonProperty("resolutionDuration")]
        public long? ResolutionDuration { get; internal set; }

        /// <summary>
        /// The service in which instance(s) the problem resides.
        /// </summary>
        [JsonProperty("service"), Sdk4meField(true)]
        public Service? Service { get; internal set; }

        [JsonProperty("serviceInstances")]
        internal NodeCollection<ServiceInstance>? ServiceInstancesCollection { get; set; }

        /// <summary>
        /// Service instances of this problem.
        /// </summary>
        public DataList<ServiceInstance>? ServiceInstances
        {
            get => ServiceInstancesCollection?.Data;
        }

        /// <summary>
        /// Automatically set to the date and time at which the problem is saved with the status "Solved".
        /// </summary>
        [JsonProperty("solvedAt"), Sdk4meField(true)]
        public DateTime? SolvedAt { get; internal set; }

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
        /// The current status of the problem.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public ProblemStatus? Status { get; internal set; }

        /// <summary>
        /// A short description of the symptoms that the problem causes.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// The supplier organization that has been asked for a solution to the problem.
        /// </summary>
        [JsonProperty("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The identifier under which the request to help with the solution of the problem has been registered at the supplier organization. If the supplier provided a link to the request, enter the entire URL in this field.
        /// </summary>
        [JsonProperty("supplierRequestID")]
        public string? SupplierRequestID { get; internal set; }

        /// <summary>
        /// The team to which the problem is to be assigned. After a service has been selected in the Service field, the support team of the service is automatically selected in this field.
        /// </summary>
        [JsonProperty("team")]
        public Team? Team { get; internal set; }

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
        /// Whether the problem has been marked as urgent.
        /// </summary>
        [JsonProperty("urgent")]
        public bool? Urgent { get; internal set; }

        /// <summary>
        /// The date and time at which the status of the problem is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
        /// </summary>
        [JsonProperty("waitingUntil")]
        public DateTime? WaitingUntil { get; internal set; }

        /// <summary>
        /// Used to describe the temporary workaround that should be applied to resolve incidents caused by this problem until a structural solution has been implemented.
        /// </summary>
        [JsonProperty("workaround")]
        public string? Workaround { get; internal set; }

        [JsonProperty("workaroundAttachments")]
        internal NodeCollection<Attachment>? WorkaroundAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Workaround field.
        /// </summary>
        public DataList<Attachment>? WorkaroundAttachments
        {
            get => WorkaroundAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The workflow that will implement the proposed permanent solution for the problem.
        /// </summary>
        [JsonProperty("workflow")]
        public Workflow? Workflow { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(ConfigurationItemsCollection?.GetQueryPageInfo("configurationItems", depth + 1));
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(NotesCollection?.GetQueryPageInfo("notes", depth + 1));
            retval.AddRange(RequestsCollection?.GetQueryPageInfo("requests", depth + 1));
            retval.AddRange(ServiceInstancesCollection?.GetQueryPageInfo("serviceInstances", depth + 1));
            retval.AddRange(SprintBacklogItemsCollection?.GetQueryPageInfo("sprintBacklogItems", depth + 1));
            retval.AddRange(TimeEntriesCollection?.GetQueryPageInfo("timeEntries", depth + 1));
            retval.AddRange(WorkaroundAttachmentsCollection?.GetQueryPageInfo("workaroundAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            ConfigurationItems?.AddRange((data as Problem)?.ConfigurationItems);
            CustomFieldsAttachments?.AddRange((data as Problem)?.CustomFieldsAttachments);
            Notes?.AddRange((data as Problem)?.Notes);
            Requests?.AddRange((data as Problem)?.Requests);
            ServiceInstances?.AddRange((data as Problem)?.ServiceInstances);
            SprintBacklogItems?.AddRange((data as Problem)?.SprintBacklogItems);
            TimeEntries?.AddRange((data as Problem)?.TimeEntries);
            WorkaroundAttachments?.AddRange((data as Problem)?.WorkaroundAttachments);
        }
    }
}
