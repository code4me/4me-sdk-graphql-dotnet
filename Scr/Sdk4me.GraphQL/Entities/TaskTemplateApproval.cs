using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/tasktemplateapproval/">TaskTemplateApproval</see> object.
    /// </summary>
    public class TaskTemplateApproval : Node
    {
        /// <summary>
        /// The person who is selected as the approver for the task template approval.
        /// </summary>
        [JsonProperty("approver"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Person? Approver { get; internal set; }

        /// <summary>
        /// The number of minutes the approver is expected to spend working on a task that was created based on the task template to which the approval belongs.
        /// </summary>
        [JsonProperty("plannedEffort"), Sdk4meField(IsDefaultQueryProperty = true)]
        public long? PlannedEffort { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
