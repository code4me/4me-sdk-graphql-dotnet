namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/tasktemplate/">TaskTemplate</see> object.
    /// </summary>
    public class TaskTemplate : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        [JsonProperty("approvals")]
        internal NodeCollection<TaskTemplateApproval>? ApprovalsCollection { get; set; }

        /// <summary>
        /// Approvals of the task template.
        /// </summary>
        public DataList<TaskTemplateApproval>? Approvals
        {
            get => ApprovalsCollection?.Data;
        }

        /// <summary>
        /// Whether a new task that is being created based on the template is to be assigned to the person who is selected in the Requested for field of the request for which the workflow is being generated.
        /// </summary>
        [JsonProperty("assignToRequester")]
        public bool? AssignToRequester { get; internal set; }

        /// <summary>
        /// Whether a new task that is being created based on the template is to be assigned to the person who is selected in the Manager field of the business unit to which the organization belongs that is linked to the person who is selected in the Requested for field of the request for which the workflow is being generated.
        /// </summary>
        [JsonProperty("assignToRequesterBusinessUnitManager")]
        public bool? AssignToRequesterBusinessUnitManager { get; internal set; }

        /// <summary>
        /// Whether the manager of the requester of the first related request is to be selected in the Approver field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("assignToRequesterManager")]
        public bool? AssignToRequesterManager { get; internal set; }

        /// <summary>
        /// Whether a new task that is being created based on the template is to be assigned to the person who is selected in the Service owner field of the service that is linked to the workflow that the new task is a part of.
        /// </summary>
        [JsonProperty("assignToServiceOwner")]
        public bool? AssignToServiceOwner { get; internal set; }

        /// <summary>
        /// Whether a new task that is being created based on the template is to be assigned to the person who is selected in the Manager field of the workflow to which the task belongs.
        /// </summary>
        [JsonProperty("assignToWorkflowManager")]
        public bool? AssignToWorkflowManager { get; internal set; }

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
        /// The category that needs to be selected in the Category field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("category"), Sdk4meField(true)]
        public TaskCategory? Category { get; internal set; }

        [JsonProperty("configurationItems")]
        internal NodeCollection<ConfigurationItem>? ConfigurationItemsCollection { get; set; }

        /// <summary>
        /// Configuration items of the task template.
        /// </summary>
        public DataList<ConfigurationItem>? ConfigurationItems
        {
            get => ConfigurationItemsCollection?.Data;
        }

        /// <summary>
        /// Whether the Copy note to workflow box of tasks that were created based on the template needs to be checked by default. (The Copy notes to workflow checkbox is called "Copy notes to workflow by default" when the task template is in Edit mode.)
        /// </summary>
        [JsonProperty("copyNotesToWorkflow")]
        public bool? CopyNotesToWorkflow { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the task template may not be used to help register new tasks.
        /// </summary>
        [JsonProperty("disabled"), Sdk4meField(true)]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on a task created based on the template.
        /// </summary>
        [JsonProperty("effortClass")]
        public EffortClass? EffortClass { get; internal set; }

        /// <summary>
        /// The impact level that needs to be selected in the Impact field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("impact"), Sdk4meField(true)]
        public TaskImpact? Impact { get; internal set; }

        /// <summary>
        /// The information that needs to be copied to the Instructions field of a new task when it is being created based on the template.
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
        /// The person who should be selected in the Member field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("member")]
        public Person? Member { get; internal set; }

        /// <summary>
        /// The information that needs to be copied to the Note field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("note")]
        public string? Note { get; internal set; }

        [JsonProperty("noteAttachments")]
        internal NodeCollection<Attachment>? NoteAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Note field.
        /// </summary>
        public DataList<Attachment>? NoteAttachments
        {
            get => NoteAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Influences the behavior of the note field on completion or approval.
        /// </summary>
        [JsonProperty("noteBehavior")]
        public TaskNoteBehavior? NoteBehavior { get; internal set; }

        /// <summary>
        /// The PDF design that needs to be copied to the PDF design field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("pdfDesign")]
        public PdfDesign? PdfDesign { get; internal set; }

        /// <summary>
        /// The number of minutes that should be entered in the Planned duration field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("plannedDuration")]
        public long? PlannedDuration { get; internal set; }

        /// <summary>
        /// The number of minutes the member is expected to spend working on a task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        /// <summary>
        /// The number of minutes the person, who is selected in the Requested for field of the first related request, is expected to spend working on a task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortRequester")]
        public long? PlannedEffortRequester { get; internal set; }

        /// <summary>
        /// The number of minutes the business unit manager of the requester of the first related request is expected to spend working on a task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortRequesterBusinessUnitManager")]
        public long? PlannedEffortRequesterBusinessUnitManager { get; internal set; }

        /// <summary>
        /// The number of minutes the manager of the requester of the first related request is expected to spend working on a task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortRequesterManager")]
        public long? PlannedEffortRequesterManager { get; internal set; }

        /// <summary>
        /// The number of minutes the owner of the service of the related to the workflow is expected to spend working on a task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortServiceOwner")]
        public long? PlannedEffortServiceOwner { get; internal set; }

        /// <summary>
        /// The number of minutes the workflow manager is expected to spend working on a task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortWorkflowManager")]
        public long? PlannedEffortWorkflowManager { get; internal set; }

        /// <summary>
        /// Whether the provider indicates not to be accountable for the affected SLAs linked to the requests that are linked to the workflow of a task that was created based on the template.
        /// </summary>
        [JsonProperty("providerNotAccountable")]
        public bool? ProviderNotAccountable { get; internal set; }

        /// <summary>
        /// The service instance that should be selected in the Request service instance field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("requestServiceInstance")]
        public ServiceInstance? RequestServiceInstance { get; internal set; }

        /// <summary>
        /// The request template that should be selected in the Request template field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("requestTemplate")]
        public RequestTemplate? RequestTemplate { get; internal set; }

        /// <summary>
        /// The number that needs to be specified in the Required approvals field of a new approval task when it is being created based on the template.
        /// </summary>
        [JsonProperty("requiredApprovals")]
        public long? RequiredApprovals { get; internal set; }

        [JsonProperty("serviceInstances")]
        internal NodeCollection<ServiceInstance>? ServiceInstancesCollection { get; set; }

        /// <summary>
        /// Service instances of the task template.
        /// </summary>
        public DataList<ServiceInstance>? ServiceInstances
        {
            get => ServiceInstancesCollection?.Data;
        }

        /// <summary>
        /// The skill pool that should be selected in the Skill pool field of a new task when it is being created based on the template.
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

        /// <summary>
        /// A short description that needs to be copied to the Subject field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// The supplier organization that should be selected in the Supplier field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("supplier")]
        public Organization? Supplier { get; internal set; }

        [JsonProperty("tasks")]
        internal NodeCollection<Task>? TasksCollection { get; set; }

        /// <summary>
        /// Tasks created using the task template.
        /// </summary>
        public DataList<Task>? Tasks
        {
            get => TasksCollection?.Data;
        }

        /// <summary>
        /// The team that should be selected in the Team field of a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("team")]
        public Team? Team { get; internal set; }

        /// <summary>
        /// UI extension that is to be added to a new task when it is being created based on the template.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Whether a new task that is created based on the template is to be marked as urgent.
        /// </summary>
        [JsonProperty("urgent")]
        public bool? Urgent { get; internal set; }

        /// <summary>
        /// Whether the completion target of tasks created based on the template are calculated using a 24x7 calendar rather than normal business hours.
        /// </summary>
        [JsonProperty("workHoursAre24x7")]
        public bool? WorkHoursAre24x7 { get; internal set; }

        [JsonProperty("workflowTemplates")]
        internal NodeCollection<WorkflowTemplate>? WorkflowTemplatesCollection { get; set; }

        /// <summary>
        /// Workflow templates that include the task template.
        /// </summary>
        public DataList<WorkflowTemplate>? WorkflowTemplates
        {
            get => WorkflowTemplatesCollection?.Data;
        }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(ApprovalsCollection?.GetQueryPageInfo("approvals", depth + 1));
            retval.AddRange(AutomationRulesCollection?.GetQueryPageInfo("automationRules", depth + 1));
            retval.AddRange(ConfigurationItemsCollection?.GetQueryPageInfo("configurationItems", depth + 1));
            retval.AddRange(InstructionsAttachmentsCollection?.GetQueryPageInfo("instructionsAttachments", depth + 1));
            retval.AddRange(NoteAttachmentsCollection?.GetQueryPageInfo("noteAttachments", depth + 1));
            retval.AddRange(ServiceInstancesCollection?.GetQueryPageInfo("serviceInstances", depth + 1));
            retval.AddRange(TasksCollection?.GetQueryPageInfo("tasks", depth + 1));
            retval.AddRange(WorkflowTemplatesCollection?.GetQueryPageInfo("workflowTemplates", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Approvals?.AddRange((data as TaskTemplate)?.Approvals);
            AutomationRules?.AddRange((data as TaskTemplate)?.AutomationRules);
            ConfigurationItems?.AddRange((data as TaskTemplate)?.ConfigurationItems);
            InstructionsAttachments?.AddRange((data as TaskTemplate)?.InstructionsAttachments);
            NoteAttachments?.AddRange((data as TaskTemplate)?.NoteAttachments);
            ServiceInstances?.AddRange((data as TaskTemplate)?.ServiceInstances);
            Tasks?.AddRange((data as TaskTemplate)?.Tasks);
            WorkflowTemplates?.AddRange((data as TaskTemplate)?.WorkflowTemplates);
        }
    }
}
