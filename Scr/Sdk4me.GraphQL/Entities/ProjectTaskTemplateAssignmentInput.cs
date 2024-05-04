using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/projecttasktemplateassignmentinput/">ProjectTaskTemplateAssignmentInput</see> object.
    /// </summary>
    public class ProjectTaskTemplateAssignmentInput : PropertyChangeSet
    {
        private string? assigneeId;
        private string? id;
        private long? plannedEffort;

        /// <summary>
        /// Identifier of the person who is selected as the assignee for the assignment.
        /// </summary>
        [JsonProperty("assigneeId")]
        public string? AssigneeId
        {
            get => assigneeId;
            set => assigneeId = Set("assigneeId", value);
        }

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
        /// The number of minutes the assignee is expected to spend working on the project task to which the assignment belongs.
        /// </summary>
        [JsonProperty("plannedEffort")]
        public long? PlannedEffort
        {
            get => plannedEffort;
            set => plannedEffort = Set("plannedEffort", value);
        }
    }
}
