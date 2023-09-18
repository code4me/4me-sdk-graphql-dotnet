namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/workflowtemplateupdateinput/">WorkflowTemplateUpdateInput</see> object.
    /// </summary>
    public class WorkflowTemplateUpdateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private string? uiExtensionId;
        private WorkflowCategory? category;
        private string? workflowManagerId;
        private string? workflowTypeId;
        private bool? disabled;
        private string? instructions;
        private WorkflowJustification? justification;
        private string? note;
        private RecurrenceInput? recurrence;
        private string? serviceId;
        private string? subject;
        private List<WorkflowTemplateTaskTemplateInput>? newTaskTemplateRelations;
        private string? clientMutationId;
        private string? id;
        private List<string>? taskTemplateRelationsToDelete;

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
        /// UI extension that is to be applied to the record.
        /// </summary>
        [JsonProperty("uiExtensionId")]
        public string? UiExtensionId
        {
            get => uiExtensionId;
            set => uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// The category that needs to be selected in the Category field of a new workflow when it is being created based on the template.
        /// </summary>
        [JsonProperty("category")]
        public WorkflowCategory? Category
        {
            get => category;
            set => category = Set("category", value);
        }

        /// <summary>
        /// The person who will be responsible for coordinating the workflows that will be generated automatically in accordance with the recurrence schedule.
        /// </summary>
        [JsonProperty("workflowManagerId")]
        public string? WorkflowManagerId
        {
            get => workflowManagerId;
            set => workflowManagerId = Set("workflowManagerId", value);
        }

        /// <summary>
        /// The type that needs to be selected in the Type field of a new workflow when it is being created based on the template.
        /// </summary>
        [JsonProperty("workflowTypeId")]
        public string? WorkflowTypeId
        {
            get => workflowTypeId;
            set => workflowTypeId = Set("workflowTypeId", value);
        }

        /// <summary>
        /// Whether the workflow template may not be used to help register new workflows.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// The information that needs to be shown when a new workflow is being created based on the template. This field typically contains instructions about how to register the workflow.
        /// </summary>
        [JsonProperty("instructions")]
        public string? Instructions
        {
            get => instructions;
            set => instructions = Set("instructions", value);
        }

        /// <summary>
        /// The justification that needs to be selected in the Justification field of a new workflow when it is being created based on the template. This field is required when there are request templates linked to the workflow template.
        /// </summary>
        [JsonProperty("justification")]
        public WorkflowJustification? Justification
        {
            get => justification;
            set => justification = Set("justification", value);
        }

        /// <summary>
        /// The information that needs to be copied to the Note field of a new workflow when it is being created based on the template.
        /// </summary>
        [JsonProperty("note")]
        public string? Note
        {
            get => note;
            set => note = Set("note", value);
        }

        /// <summary>
        /// Recurrence for the workflow template.
        /// </summary>
        [JsonProperty("recurrence")]
        public RecurrenceInput? Recurrence
        {
            get => recurrence;
            set => recurrence = Set("recurrence", value);
        }

        /// <summary>
        /// The service that should be selected in the Service field of a new workflow when it is being created based on the template.
        /// </summary>
        [JsonProperty("serviceId")]
        public string? ServiceId
        {
            get => serviceId;
            set => serviceId = Set("serviceId", value);
        }

        /// <summary>
        /// Short description that needs to be copied to the Subject field of a new workflow when it is being created based on the template.
        /// </summary>
        [JsonProperty("subject")]
        public string? Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// Task template relations of the workflow template.
        /// </summary>
        [JsonProperty("newTaskTemplateRelations")]
        public List<WorkflowTemplateTaskTemplateInput>? NewTaskTemplateRelations
        {
            get => newTaskTemplateRelations;
            set => newTaskTemplateRelations = Set("newTaskTemplateRelations", value);
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
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Identifiers of task template relations to remove from the workflow template.
        /// </summary>
        [JsonProperty("taskTemplateRelationsToDelete")]
        public List<string>? TaskTemplateRelationsToDelete
        {
            get => taskTemplateRelationsToDelete;
            set => taskTemplateRelationsToDelete = Set("taskTemplateRelationsToDelete", value);
        }
    }
}
