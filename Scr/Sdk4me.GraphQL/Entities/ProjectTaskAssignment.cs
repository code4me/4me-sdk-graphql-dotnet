using Newtonsoft.Json;
using System;
using System.Collections.Generic;

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
        /// <strong>link to Project Summary</strong> - The hyperlink to the Project Summary PDF file that was generated for the assignee when the assignment was last set to the status <c>assigned</c> (for project tasks of the category <c>approval</c> only).
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
        /// The date and time of the last update of the assignment. If the assignment has had no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Used to specify the date and time at which the status of the assignment is to be updated from <c>waiting_for</c> to <c>assigned</c>. This field is available only when the Status field is set to <c>waiting_for</c>.
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
