namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/tasktemplateapprovalinput/">TaskTemplateApprovalInput</see> object.
    /// </summary>
    public class TaskTemplateApprovalInput : PropertyChangeSet
    {
        private string? id;
        private string? approverId;
        private long? plannedEffort;

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
        /// Identifier of the person who is selected as the approver for the approval.
        /// </summary>
        [JsonProperty("approverId")]
        public string? ApproverId
        {
            get => approverId;
            set => approverId = Set("approverId", value);
        }

        /// <summary>
        /// The number of minutes the approver is expected to spend working on the task.
        /// </summary>
        [JsonProperty("plannedEffort")]
        public long? PlannedEffort
        {
            get => plannedEffort;
            set => plannedEffort = Set("plannedEffort", value);
        }
    }
}
