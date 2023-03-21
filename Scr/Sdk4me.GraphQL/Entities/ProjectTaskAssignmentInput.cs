namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/projecttaskassignmentinput/">ProjectTaskAssignmentInput</see> object.
    /// </summary>
    public class ProjectTaskAssignmentInput : PropertyChangeSet
    {
        private string? id;
        private string? assigneeId;
        private long? plannedEffort;
        private ProjectTaskStatus? status;
        private DateTime? waitingUntil;

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
        /// Identifier of the person who is selected as the assignee for the assignment.
        /// </summary>
        [JsonProperty("assigneeId")]
        public string? AssigneeId
        {
            get => assigneeId;
            set => assigneeId = Set("assigneeId", value);
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

        /// <summary>
        /// The status of the assignment.
        /// </summary>
        [JsonProperty("status")]
        public ProjectTaskStatus? Status
        {
            get => status;
            set => status = Set("status", value);
        }

        /// <summary>
        /// Used to specify the date and time at which the status of the assignment is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
        /// </summary>
        [JsonProperty("waitingUntil")]
        public DateTime? WaitingUntil
        {
            get => waitingUntil;
            set => waitingUntil = Set("waitingUntil", value);
        }
    }
}
