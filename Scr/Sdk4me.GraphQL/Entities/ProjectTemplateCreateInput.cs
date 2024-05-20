using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/projecttemplatecreateinput/">ProjectTemplateCreateInput</see> object.
    /// </summary>
    public class ProjectTemplateCreateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private bool? disabled;
        private List<ProjectPhaseInput>? newPhases;
        private List<ProjectTemplateTaskTemplateInput>? newTaskTemplateRelations;
        private string? source;
        private string? sourceID;
        private string subject;

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
        /// Whether the project template may not be used to help register new projects.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
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
        /// A short description that needs to be copied to the Subject field of a new project when it is being created based on the template.
        /// </summary>
        [JsonProperty("subject"), Sdk4meField(IsRequiredForMutation = true)]
        public string Subject
        {
            get => subject;
            set => subject = Set("subject", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTemplateCreateInput"/> class without providing the required values.
        /// </summary>
        public ProjectTemplateCreateInput()
        {
            subject = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTemplateCreateInput"/> class.
        /// </summary>
        /// <param name="subject">A short description that needs to be copied to the Subject field of a new project when it is being created based on the template.</param>
        public ProjectTemplateCreateInput(string subject)
        {
            this.subject = Set("subject", subject);
        }
    }
}
