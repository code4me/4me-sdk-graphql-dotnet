using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/taskapproval/">TaskApproval</see> object.
    /// </summary>
    public class TaskApproval : Node
    {
        /// <summary>
        /// The person who is selected as the approver for the approval.
        /// </summary>
        [JsonProperty("approver"), Sdk4meField(true)]
        public Person? Approver { get; internal set; }

        /// <summary>
        /// The summary PDF file that was generated for the approver when the approval was last set to the status <c>assigned</c>.
        /// </summary>
        [JsonProperty("attachment")]
        public Attachment? Attachment { get; internal set; }

        /// <summary>
        /// The date and time at which the approval was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The number of minutes the approver is expected to spend working on the task.
        /// </summary>
        [JsonProperty("plannedEffort"), Sdk4meField(true)]
        public long? PlannedEffort { get; internal set; }

        /// <summary>
        /// The status of the approval.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public TaskStatus? Status { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the approval. If the approval has had no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
