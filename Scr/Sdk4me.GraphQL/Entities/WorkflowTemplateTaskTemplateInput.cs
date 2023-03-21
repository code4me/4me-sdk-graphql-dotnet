namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/workflowtemplatetasktemplateinput/">WorkflowTemplateTaskTemplateInput</see> object.
    /// </summary>
    public class WorkflowTemplateTaskTemplateInput : PropertyChangeSet
    {
        private string? id;
        private string? taskTemplateId;

        /// <summary>
        /// Identifier of the object to update using these values. For new objects it should be <c>null</c>.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Identifier of task template related to the workflow template.
        /// </summary>
        [JsonProperty("taskTemplateId")]
        public string? TaskTemplateId
        {
            get => taskTemplateId;
            set => taskTemplateId = Set("taskTemplateId", value);
        }
    }
}
