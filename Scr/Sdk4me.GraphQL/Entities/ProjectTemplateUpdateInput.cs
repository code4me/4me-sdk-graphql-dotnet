namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/projecttemplateupdateinput/">ProjectTemplateUpdateInput</see> object.
    /// </summary>
    public class ProjectTemplateUpdateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private bool? disabled;
        private string? subject;
        private List<ProjectPhaseInput>? newPhases;
        private List<ProjectTemplateTaskTemplateInput>? newTaskTemplateRelations;
        private string? id;
        private List<string>? phasesToDelete;
        private List<string>? taskTemplateRelationsToDelete;
        private string? clientMutationId;

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
        /// Whether the project template may not be used to help register new projects.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// A short description that needs to be copied to the Subject field of a new project when it is being created based on the template.
        /// </summary>
        [JsonProperty("subject")]
        public string? Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// Phases of the project template.
        /// </summary>
        [JsonProperty("newPhases")]
        public List<ProjectPhaseInput>? NewPhases
        {
            get => newPhases;
            set => newPhases = Set("newPhases", value);
        }

        /// <summary>
        /// Project task template relations of the project template.
        /// </summary>
        [JsonProperty("newTaskTemplateRelations")]
        public List<ProjectTemplateTaskTemplateInput>? NewTaskTemplateRelations
        {
            get => newTaskTemplateRelations;
            set => newTaskTemplateRelations = Set("newTaskTemplateRelations", value);
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
        /// Identifiers of phases to remove from the project template.
        /// </summary>
        [JsonProperty("phasesToDelete")]
        public List<string>? PhasesToDelete
        {
            get => phasesToDelete;
            set => phasesToDelete = Set("phasesToDelete", value);
        }

        /// <summary>
        /// Identifiers of task template relations to remove from the project template.
        /// </summary>
        [JsonProperty("taskTemplateRelationsToDelete")]
        public List<string>? TaskTemplateRelationsToDelete
        {
            get => taskTemplateRelationsToDelete;
            set => taskTemplateRelationsToDelete = Set("taskTemplateRelationsToDelete", value);
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
    }
}
