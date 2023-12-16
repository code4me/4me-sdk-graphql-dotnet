namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/workflowtemplate/">WorkflowTemplate</see> object.
    /// </summary>
    public class WorkflowTemplate : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Whether Requests and Problems are assigned to the workflow manager when the relations are linked to the workflow.
        /// </summary>
        [JsonProperty("assignRelationsToWorkflowManager")]
        public bool? AssignRelationsToWorkflowManager { get; internal set; }

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
        /// The category that needs to be selected in the Category field of a new workflow when it is being created based on the template.
        /// </summary>
        [JsonProperty("category")]
        public WorkflowCategory? Category { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the workflow template may not be used to help register new workflows.
        /// </summary>
        [JsonProperty("disabled"), Sdk4meField(true)]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The maximum impact level that is selected in the task templates that are a part of the workflow template.
        /// </summary>
        [JsonProperty("impact")]
        public TaskImpact? Impact { get; internal set; }

        /// <summary>
        /// The information that needs to be shown when a new workflow is being created based on the template. This field typically contains instructions about how to register the workflow.
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
        /// The justification that needs to be selected in the Justification field of a new workflow when it is being created based on the template. This field is required when there are request templates linked to the workflow template.
        /// </summary>
        [JsonProperty("justification")]
        public WorkflowJustification? Justification { get; internal set; }

        /// <summary>
        /// The information that needs to be copied to the Note field of a new workflow when it is being created based on the template.
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

        [JsonProperty("phases")]
        internal NodeCollection<WorkflowTemplatePhase>? PhasesCollection { get; set; }

        /// <summary>
        /// Phases of the workflow template.
        /// </summary>
        public DataList<WorkflowTemplatePhase>? Phases
        {
            get => PhasesCollection?.Data;
        }

        /// <summary>
        /// Recurrency for the workflow template.
        /// </summary>
        [JsonProperty("recurrence")]
        public Recurrence? Recurrence { get; internal set; }

        /// <summary>
        /// The service that should be selected in the Service field of a new workflow when it is being created based on the template.
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
        /// Short description that needs to be copied to the Subject field of a new workflow when it is being created based on the template.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(true)]
        public string? Subject { get; internal set; }

        [JsonProperty("taskTemplateRelations")]
        internal NodeCollection<WorkflowTaskTemplateRelation>? TaskTemplateRelationsCollection { get; set; }

        /// <summary>
        /// Task template relations of the workflow template
        /// </summary>
        public DataList<WorkflowTaskTemplateRelation>? TaskTemplateRelations
        {
            get => TaskTemplateRelationsCollection?.Data;
        }

        /// <summary>
        /// UI extension that is to be added to a new workflow when it is being created based on the template.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// The person who will be responsible for coordinating the workflows that will be generated automatically in accordance with the recurrence schedule.
        /// </summary>
        [JsonProperty("workflowManager")]
        public Person? WorkflowManager { get; internal set; }

        [JsonProperty("workflows")]
        internal NodeCollection<Workflow>? WorkflowsCollection { get; set; }

        /// <summary>
        /// Workflows of the workflow template.
        /// </summary>
        public DataList<Workflow>? Workflows
        {
            get => WorkflowsCollection?.Data;
        }

        /// <summary>
        /// The type that needs to be selected in the Type field of a new workflow when it is being created based on the template.
        /// </summary>
        [JsonProperty("workflowType")]
        public WorkflowType? WorkflowType { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(AutomationRulesCollection?.GetQueryPageInfo("automationRules", depth + 1));
            retval.AddRange(InstructionsAttachmentsCollection?.GetQueryPageInfo("instructionsAttachments", depth + 1));
            retval.AddRange(NoteAttachmentsCollection?.GetQueryPageInfo("noteAttachments", depth + 1));
            retval.AddRange(PhasesCollection?.GetQueryPageInfo("phases", depth + 1));
            retval.AddRange(TaskTemplateRelationsCollection?.GetQueryPageInfo("taskTemplateRelations", depth + 1));
            retval.AddRange(WorkflowsCollection?.GetQueryPageInfo("workflows", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            AutomationRules?.AddRange((data as WorkflowTemplate)?.AutomationRules);
            InstructionsAttachments?.AddRange((data as WorkflowTemplate)?.InstructionsAttachments);
            NoteAttachments?.AddRange((data as WorkflowTemplate)?.NoteAttachments);
            Phases?.AddRange((data as WorkflowTemplate)?.Phases);
            TaskTemplateRelations?.AddRange((data as WorkflowTemplate)?.TaskTemplateRelations);
            Workflows?.AddRange((data as WorkflowTemplate)?.Workflows);
        }
    }
}
