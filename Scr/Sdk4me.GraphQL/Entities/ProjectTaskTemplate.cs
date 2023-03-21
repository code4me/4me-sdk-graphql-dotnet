namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projecttasktemplate/">ProjectTaskTemplate</see> object.
    /// </summary>
    public class ProjectTaskTemplate : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Whether the project manager is to be selected in the Assignees field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("assignToProjectManager")]
        public bool? AssignToProjectManager { get; internal set; }

        /// <summary>
        /// Whether a new project task that is being created based on the template is to be assigned to the person who is selected in the Requested for field of the request for which the project was registered.
        /// </summary>
        [JsonProperty("assignToRequester")]
        public bool? AssignToRequester { get; internal set; }

        /// <summary>
        /// Whether a new project task that is being created based on the template is to be assigned to the person who is selected in the Manager field of the business unit to which the organization belongs that is linked to the person who is selected in the Requested for field of the request for which the project was registered.
        /// </summary>
        [JsonProperty("assignToRequesterBusinessUnitManager")]
        public bool? AssignToRequesterBusinessUnitManager { get; internal set; }

        /// <summary>
        /// Whether a new project task that is being created based on the template is to be assigned to the manager of the project's requester.
        /// </summary>
        [JsonProperty("assignToRequesterManager")]
        public bool? AssignToRequesterManager { get; internal set; }

        /// <summary>
        /// Whether a new project task that is being created based on the template is to be assigned to the person who is selected in the Service owner field of the service that is linked to the project that the new project task is a part of.
        /// </summary>
        [JsonProperty("assignToServiceOwner")]
        public bool? AssignToServiceOwner { get; internal set; }

        [JsonProperty("assignments")]
        internal NodeCollection<ProjectTaskTemplateAssignment>? AssignmentsCollection { get; set; }

        /// <summary>
        /// Assignments of the project task template.
        /// </summary>
        public DataList<ProjectTaskTemplateAssignment>? Assignments
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
        /// The category that needs to be selected in the Category field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("category"), Sdk4meField(true)]
        public ProjectTaskCategory? Category { get; internal set; }

        /// <summary>
        /// Whether the Copy note to project box of project tasks that were created based on the template needs to be checked by default. (The Copy notes to project checkbox is called "Copy notes to project by default" when the project task template is in Edit mode.)
        /// </summary>
        [JsonProperty("copyNotesToProject")]
        public bool? CopyNotesToProject { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the project task template may not be used to help register new project tasks.
        /// </summary>
        [JsonProperty("disabled"), Sdk4meField(true)]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on a project task created based on the template.
        /// </summary>
        [JsonProperty("effortClass")]
        public EffortClass? EffortClass { get; internal set; }

        /// <summary>
        /// The information that needs to be copied to the Instructions field of a new project task when it is being created based on the template.
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
        /// The information that needs to be copied to the Note field of a new project task when it is being created based on the template.
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
        public ProjectTaskNoteBehavior? NoteBehavior { get; internal set; }

        /// <summary>
        /// The PDF design that needs to be copied to the PDF design field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("pdfDesign")]
        public PdfDesign? PdfDesign { get; internal set; }

        /// <summary>
        /// Used to specify the number of minutes that should be entered in the Planned duration field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("plannedDuration")]
        public long? PlannedDuration { get; internal set; }

        /// <summary>
        /// Used to specify the number of minutes that the team is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffort")]
        public long? PlannedEffort { get; internal set; }

        /// <summary>
        /// Used to specify the number of minutes that the project manager is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortProjectManager")]
        public long? PlannedEffortProjectManager { get; internal set; }

        /// <summary>
        /// Used to specify the number of minutes that the requester is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortRequester")]
        public long? PlannedEffortRequester { get; internal set; }

        /// <summary>
        /// Used to specify the number of minutes that the requester's business unit manager is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortRequesterBusinessUnitManager")]
        public long? PlannedEffortRequesterBusinessUnitManager { get; internal set; }

        /// <summary>
        /// Used to specify the number of minutes that the requester's manager is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortRequesterManager")]
        public long? PlannedEffortRequesterManager { get; internal set; }

        /// <summary>
        /// Used to specify the number of minutes that the service owner is expected to spend working on a project task that was created based on the template.
        /// </summary>
        [JsonProperty("plannedEffortServiceOwner")]
        public long? PlannedEffortServiceOwner { get; internal set; }

        [JsonProperty("projectTemplates")]
        internal NodeCollection<ProjectTemplate>? ProjectTemplatesCollection { get; set; }

        /// <summary>
        /// Project templates that include the project task template.
        /// </summary>
        public DataList<ProjectTemplate>? ProjectTemplates
        {
            get => ProjectTemplatesCollection?.Data;
        }

        /// <summary>
        /// The number that needs to be specified in the Required approvals field of a new approval project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("requiredApprovals")]
        public long? RequiredApprovals { get; internal set; }

        /// <summary>
        /// The skill pool that should be selected in the Skill pool field of a new project task when it is being created based on the template.
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
        /// A short description that needs to be copied to the Subject field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(true)]
        public string? Subject { get; internal set; }

        /// <summary>
        /// The supplier organization that should be selected in the Supplier field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("supplier")]
        public Organization? Supplier { get; internal set; }

        [JsonProperty("tasks")]
        internal NodeCollection<ProjectTask>? TasksCollection { get; set; }

        /// <summary>
        /// Project tasks created using the project task template.
        /// </summary>
        public DataList<ProjectTask>? Tasks
        {
            get => TasksCollection?.Data;
        }

        /// <summary>
        /// The Team that should be selected in the Team field of a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("team")]
        public Team? Team { get; internal set; }

        /// <summary>
        /// UI extension that is to be added to a new project task when it is being created based on the template.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// When set to true, the completion target of project tasks created based on the template are calculated using a 24x7 calendar rather than normal business hours.
        /// </summary>
        [JsonProperty("workHoursAre24x7")]
        public bool? WorkHoursAre24x7 { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(AssignmentsCollection?.GetQueryPageInfo("assignments", depth + 1));
            retval.AddRange(AutomationRulesCollection?.GetQueryPageInfo("automationRules", depth + 1));
            retval.AddRange(InstructionsAttachmentsCollection?.GetQueryPageInfo("instructionsAttachments", depth + 1));
            retval.AddRange(NoteAttachmentsCollection?.GetQueryPageInfo("noteAttachments", depth + 1));
            retval.AddRange(ProjectTemplatesCollection?.GetQueryPageInfo("projectTemplates", depth + 1));
            retval.AddRange(TasksCollection?.GetQueryPageInfo("tasks", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Assignments?.AddRange((data as ProjectTaskTemplate)?.Assignments);
            AutomationRules?.AddRange((data as ProjectTaskTemplate)?.AutomationRules);
            InstructionsAttachments?.AddRange((data as ProjectTaskTemplate)?.InstructionsAttachments);
            NoteAttachments?.AddRange((data as ProjectTaskTemplate)?.NoteAttachments);
            ProjectTemplates?.AddRange((data as ProjectTaskTemplate)?.ProjectTemplates);
            Tasks?.AddRange((data as ProjectTaskTemplate)?.Tasks);
        }
    }
}
