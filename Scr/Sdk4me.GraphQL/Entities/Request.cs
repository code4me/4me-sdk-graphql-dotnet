namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/request/">Request</see> object.
    /// </summary>
    public class Request : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// When the Satisfaction field of the request is set to 'Dissatisfied', a person who has the Service Desk Manager role, can check the Addressed box to indicate that the requester has been conciliated.
        /// </summary>
        [JsonProperty("addressed")]
        public bool? Addressed { get; internal set; }

        [JsonProperty("affectedSlas")]
        internal NodeCollection<AffectedSla>? AffectedSlasCollection { get; set; }

        /// <summary>
        /// Affected service level agreements of the request.
        /// </summary>
        public DataList<AffectedSla>? AffectedSlas
        {
            get => AffectedSlasCollection?.Data;
        }

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
        /// Automatically set to the number of times that the Team field of the request has been set to a team that is registered in the accounts from which the request data is retrieved.
        /// </summary>
        [JsonProperty("assignmentCount")]
        public long? AssignmentCount { get; internal set; }

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
        /// The category of the request.
        /// </summary>
        [JsonProperty("category"), Sdk4meField(true)]
        public RequestCategory? Category { get; internal set; }

        /// <summary>
        /// Automatically set to the date and time at which the request is saved with the status "Completed".
        /// </summary>
        [JsonProperty("completedAt"), Sdk4meField(true)]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// The appropriate completion reason for the request when it has been completed.
        /// </summary>
        [JsonProperty("completionReason")]
        public RequestCompletionReason? CompletionReason { get; internal set; }

        [JsonProperty("configurationItems")]
        internal NodeCollection<ConfigurationItem>? ConfigurationItemsCollection { get; set; }

        /// <summary>
        /// Configuration items of the request.
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
        /// Automatically set to the person who submitted the request.
        /// </summary>
        [JsonProperty("createdBy")]
        public Person? CreatedBy { get; internal set; }

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
        /// The date and time that has been agreed on for the completion of the request. The desired completion overwrites the automatically calculated resolution target of any affected service level agreement that is related to the request when the desired completion is later than the affected service level agreements resolution target. By default, the person selected in the Requested by field receives a notification based on the 'Desired Completion Set for Request' email template whenever the value in the Desired completion field is set, updated or removed.
        /// </summary>
        [JsonProperty("desiredCompletionAt")]
        public DateTime? DesiredCompletionAt { get; internal set; }

        /// <summary>
        /// The actual date and time at which the service became available again.
        /// </summary>
        [JsonProperty("downtimeEndAt")]
        public DateTime? DowntimeEndAt { get; internal set; }

        /// <summary>
        /// The actual date and time at which the service outage started.
        /// </summary>
        [JsonProperty("downtimeStartAt")]
        public DateTime? DowntimeStartAt { get; internal set; }

        /// <summary>
        /// The `satisfiedUrl` and the `dissatisfiedUrl` of the `requestedFor`. In case the `requestedBy` is different form the `requestedFor`, the satisfaction link of the `requestedBy` are also included. Feedback is `null` in case no feedback for the request can be provided at this time.
        /// </summary>
        [JsonProperty("feedback")]
        public Feedback? Feedback { get; internal set; }

        /// <summary>
        /// The request group that is used to group the requests that have been submitted for the resolution of exactly the same incident, for the implementation of exactly the same change, for the provision of exactly the same information, etc.
        /// </summary>
        [JsonProperty("groupedInto")]
        public Request? GroupedInto { get; internal set; }

        [JsonProperty("groupedRequests")]
        internal NodeCollection<Request>? GroupedRequestsCollection { get; set; }

        /// <summary>
        /// Requests that are grouped into this request group.
        /// </summary>
        public DataList<Request>? GroupedRequests
        {
            get => GroupedRequestsCollection?.Data;
        }

        /// <summary>
        /// Default: `none`.
        /// </summary>
        [JsonProperty("grouping"), Sdk4meField(true)]
        public RequestGrouping? Grouping { get; internal set; }

        /// <summary>
        /// The extent to which the service instance is impacted.
        /// </summary>
        [JsonProperty("impact"), Sdk4meField(true)]
        public RequestImpact? Impact { get; internal set; }

        /// <summary>
        /// Automatically set to the latest knowledge article that was applied to the request.
        /// </summary>
        [JsonProperty("knowledgeArticle")]
        public KnowledgeArticle? KnowledgeArticle { get; internal set; }

        /// <summary>
        /// Current state of the record.
        /// </summary>
        [JsonProperty("lifeCycleState")]
        public LifeCycleState? LifeCycleState { get; internal set; }

        /// <summary>
        /// Used to indicate the status in the major incident management process.
        /// </summary>
        [JsonProperty("majorIncidentStatus")]
        public RequestMajorIncidentStatus? MajorIncidentStatus { get; internal set; }

        /// <summary>
        /// The person to whom the request is to be assigned.
        /// </summary>
        [JsonProperty("member"), Sdk4meField(true)]
        public Person? Member { get; internal set; }

        /// <summary>
        /// Empty when the status of the request is `completed`. The next target equals the response target when a response target exists and the response target is less than the desired completion. Otherwise, the next target equals the desired completion when a desired completion exists. Otherwise, if the status is `waiting_for_customer` the next target is `clock_stopped` when an affected service level agreement is linked to the request which Accountability field is set to `provider` or `supplier`. Otherwise, if the status is `waiting_for_customer` the next target is `best_effort`. Otherwise the next target is the resolution target when a resolution target exists. In all other cases, the next target is `best_effort`.
        /// </summary>
        [JsonProperty("nextTargetAt"), Sdk4meField(true)]
        public string? NextTargetAt { get; internal set; }

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
        /// Automatically set when the request is saved for the first time to the organization that the person, who is selected in the Requested for field, belongs.
        /// </summary>
        [JsonProperty("organization")]
        public Organization? Organization { get; internal set; }

        /// <summary>
        /// The number of minutes the member is expected to spend working on the request.
        /// </summary>
        [JsonProperty("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        /// <summary>
        /// Used to link the request to a problem.
        /// </summary>
        [JsonProperty("problem")]
        public Problem? Problem { get; internal set; }

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
        /// Used to link the request to a project.
        /// </summary>
        [JsonProperty("project")]
        public Project? Project { get; internal set; }

        /// <summary>
        /// Whether the provider currently indicates not to be accountable.
        /// </summary>
        [JsonProperty("providerNotAccountable")]
        public bool? ProviderNotAccountable { get; internal set; }

        /// <summary>
        /// Whether the provider has at any point in time indicated not to be accountable.
        /// </summary>
        [JsonProperty("providerWasNotAccountable")]
        public bool? ProviderWasNotAccountable { get; internal set; }

        /// <summary>
        /// Automatically set to the number of times that the status of the request has changed from `completed` to a different value in the account from which the request data is retrieved.
        /// </summary>
        [JsonProperty("reopenCount")]
        public long? ReopenCount { get; internal set; }

        /// <summary>
        /// The record identifier as displayed in the user interface.
        /// </summary>
        [JsonProperty("requestId")]
        public string? RequestId { get; internal set; }

        /// <summary>
        /// The person who submitted the request.
        /// </summary>
        [JsonProperty("requestedBy")]
        public Person? RequestedBy { get; internal set; }

        /// <summary>
        /// The person for whom the request was submitted. The person selected in the Requested by field is automatically selected in this field, but another person can be selected if the request is submitted for another person.
        /// </summary>
        [JsonProperty("requestedFor")]
        public Person? RequestedFor { get; internal set; }

        /// <summary>
        /// Automatically set to the most stringent resolution target of the request's affected service level agreements, which Accountability field is not set to `sla_not_affected` and which are linked to an service level agreement for which the person who is selected in the Requested for field has coverage.
        /// </summary>
        [JsonProperty("requesterResolutionTargetAt")]
        public DateTime? RequesterResolutionTargetAt { get; internal set; }

        /// <summary>
        /// The number of minutes it took to complete this request, which is calculated as the difference between the `createdAt` and `completedAt` values.
        /// </summary>
        [JsonProperty("resolutionDuration")]
        public long? ResolutionDuration { get; internal set; }

        /// <summary>
        /// Automatically indicates when the current assignment team needs to have completed the request. The target displayed in this field is the most stringent resolution target of the affected service level agreements that are related to the request and for which the current assignment team is responsible.
        /// </summary>
        [JsonProperty("resolutionTargetAt")]
        public string? ResolutionTargetAt { get; internal set; }

        /// <summary>
        /// Automatically indicates when the current assignment team needs to have responded to the request. The target displayed in this field is the most stringent response target of the affected service level agreements that are related to the request and for which the current assignment team is responsible.
        /// </summary>
        [JsonProperty("responseTargetAt")]
        public string? ResponseTargetAt { get; internal set; }

        /// <summary>
        /// <br>A request can be marked as reviewed by the problem manager of the service of the service instance that is linked to the request. Marking a request as reviewed excludes it from the 'Requests for Problem Identification' view.</br>
        /// <br>This field is automatically set to `true` when the Service instance field is empty, when the request is linked to a problem or workflow, or when the Grouping field is set to `grouped`. This field is also set to `true` when the completion_reason is `solved` and the impact is different from `top`</br>.
        /// </summary>
        [JsonProperty("reviewed")]
        public bool? Reviewed { get; internal set; }

        /// <summary>
        /// The Satisfaction field is set when a requester uses the hyperlinks defined in the 'Request Set to Completed' email template to indicate whether or not he/she is satisfied with the manner in which a request has been handled.
        /// </summary>
        [JsonProperty("satisfaction")]
        public FeedbackSatisfaction? Satisfaction { get; internal set; }

        /// <summary>
        /// The date and time the requester indicated satisfaction.
        /// </summary>
        [JsonProperty("satisfactionAt")]
        public DateTime? SatisfactionAt { get; internal set; }

        /// <summary>
        /// The service instance in which the cause of the incident resides, for which the change is requested, or about which information is needed.
        /// </summary>
        [JsonProperty("serviceInstance"), Sdk4meField(true)]
        public ServiceInstance? ServiceInstance { get; internal set; }

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
        /// Used to select the current status of the request.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public RequestStatus? Status { get; internal set; }

        /// <summary>
        /// A short description of the request.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// The supplier organization that has been asked to assist with the request. The supplier organization is automatically selected in this field after a service instance has been selected that is provided by an external service provider organization.
        /// </summary>
        [JsonProperty("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The identifier under which the request has been registered at the supplier organization. If the supplier provided a link to the request, enter the entire URL in this field.
        /// </summary>
        [JsonProperty("supplierRequestID")]
        public string? SupplierRequestID { get; internal set; }

        /// <summary>
        /// The task that caused the request to be automatically generated.
        /// </summary>
        [JsonProperty("task")]
        public Task? Task { get; internal set; }

        /// <summary>
        /// The team to which the request is to be assigned. By default, the first line team of the service instance that is related to the request will be selected. If a first line team has not been specified for the service instance, the support team of the service instance will be selected instead.
        /// </summary>
        [JsonProperty("team"), Sdk4meField(true)]
        public Team? Team { get; internal set; }

        /// <summary>
        /// The link to the request template that was last applied to the request.
        /// </summary>
        [JsonProperty("template")]
        public RequestTemplate? Template { get; internal set; }

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
        /// Whether the request has been marked as urgent.
        /// </summary>
        [JsonProperty("urgent")]
        public bool? Urgent { get; internal set; }

        /// <summary>
        /// Used to specify the date and time at which the status of the request is to be updated from `waiting_for` to `assigned`. This field is available only when the Status field is set to `waiting_for`.
        /// </summary>
        [JsonProperty("waitingUntil")]
        public DateTime? WaitingUntil { get; internal set; }

        [JsonProperty("watches")]
        internal NodeCollection<Watch>? WatchesCollection { get; set; }

        /// <summary>
        /// List of all people watching the request.
        /// </summary>
        public DataList<Watch>? Watches
        {
            get => WatchesCollection?.Data;
        }

        /// <summary>
        /// Used to link the request to a workflow.
        /// </summary>
        [JsonProperty("workflow")]
        public Workflow? Workflow { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(AffectedSlasCollection?.GetQueryPageInfo("affectedSlas", depth + 1));
            retval.AddRange(AutomationRulesCollection?.GetQueryPageInfo("automationRules", depth + 1));
            retval.AddRange(ConfigurationItemsCollection?.GetQueryPageInfo("configurationItems", depth + 1));
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(GroupedRequestsCollection?.GetQueryPageInfo("groupedRequests", depth + 1));
            retval.AddRange(NotesCollection?.GetQueryPageInfo("notes", depth + 1));
            retval.AddRange(SprintBacklogItemsCollection?.GetQueryPageInfo("sprintBacklogItems", depth + 1));
            retval.AddRange(TimeEntriesCollection?.GetQueryPageInfo("timeEntries", depth + 1));
            retval.AddRange(WatchesCollection?.GetQueryPageInfo("watches", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            AffectedSlas?.AddRange((data as Request)?.AffectedSlas);
            AutomationRules?.AddRange((data as Request)?.AutomationRules);
            ConfigurationItems?.AddRange((data as Request)?.ConfigurationItems);
            CustomFieldsAttachments?.AddRange((data as Request)?.CustomFieldsAttachments);
            GroupedRequests?.AddRange((data as Request)?.GroupedRequests);
            Notes?.AddRange((data as Request)?.Notes);
            SprintBacklogItems?.AddRange((data as Request)?.SprintBacklogItems);
            TimeEntries?.AddRange((data as Request)?.TimeEntries);
            Watches?.AddRange((data as Request)?.Watches);
        }
    }
}
