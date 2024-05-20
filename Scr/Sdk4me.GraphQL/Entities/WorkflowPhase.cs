using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/workflowphase/">WorkflowPhase</see> object.
    /// </summary>
    public class WorkflowPhase : Node
    {
        /// <summary>
        /// The date and time at which the workflow phase was set to the status "Completed".
        /// </summary>
        [JsonProperty("completedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// The date and time at which the workflow phase was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The name of the workflow phase.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The position that the workflow phase takes when it is presented in the workflow's Gantt chart.
        /// </summary>
        [JsonProperty("position"), Sdk4meField(IsDefaultQueryProperty = true)]
        public long? Position { get; internal set; }

        /// <summary>
        /// Indicates the date and time at which the first workflow task of the phase was set to a status other than <c>registered</c> or <c>canceled</c>.
        /// </summary>
        [JsonProperty("startedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? StartedAt { get; internal set; }

        /// <summary>
        /// The current status of the workflow phase.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(IsDefaultQueryProperty = true)]
        public WorkflowPhaseStatus? Status { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the workflow phase. If the phase has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
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
