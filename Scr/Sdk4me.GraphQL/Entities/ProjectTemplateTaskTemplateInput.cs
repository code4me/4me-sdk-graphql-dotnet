namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/projecttemplatetasktemplateinput/">ProjectTemplateTaskTemplateInput</see> object.
    /// </summary>
    public class ProjectTemplateTaskTemplateInput : PropertyChangeSet
    {
        private string? id;
        private string? taskTemplateId;
        private string? phaseName;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be `null`.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Identifier of the project task template that is related to the project template.
        /// </summary>
        [JsonProperty("taskTemplateId")]
        public string? TaskTemplateId
        {
            get => taskTemplateId;
            set => taskTemplateId = Set("taskTemplateId", value);
        }

        /// <summary>
        /// Name of the phase of the project template that the project task template is a part of.
        /// </summary>
        [JsonProperty("phaseName")]
        public string? PhaseName
        {
            get => phaseName;
            set => phaseName = Set("phaseName", value);
        }
    }
}
