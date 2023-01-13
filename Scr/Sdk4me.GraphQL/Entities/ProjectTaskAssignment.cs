namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/projecttaskassignment/">ProjectTaskAssignment</see> object.
    /// </summary>
    public class ProjectTaskAssignment : Node
    {
        /// <summary>
        /// The person who is selected as the assignee for the assignment.
        /// </summary>
        [JsonProperty("assignee"), Sdk4meField(true)]
        public Person? Assignee { get; internal set; }

        /// <summary>
        /// **link to Project Summary** - The hyperlink to the Project Summary PDF file that was generated for the assignee when the assignment was last set to the status `assigned` (for project tasks of the category `approval` only).
        /// </summary>
        [JsonProperty("attachment")]
        public string? Attachment { get; internal set; }

        /// <summary>
        /// The date and time at which the assignment was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The number of minutes the assignee is expected to spend working on the project task to which the assignment belongs.
        /// </summary>
        [JsonProperty("plannedEffort"), Sdk4meField(true)]
        public long? PlannedEffort { get; internal set; }

        /// <summary>
        /// The status of the assignment.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public ProjectTaskStatus? Status { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the assignment. If the assignment has had no updates it contains the `createdAt` value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Used to specify the date and time at which the status of the assignment is to be updated from `waiting_for` to `assigned`. This field is available only when the Status field is set to `waiting_for`.
        /// </summary>
        [JsonProperty("waitingUntil")]
        public DateTime? WaitingUntil { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
