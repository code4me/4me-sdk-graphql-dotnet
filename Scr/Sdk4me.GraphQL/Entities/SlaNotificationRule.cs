using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/slanotificationrule/">SlaNotificationRule</see> object.
    /// </summary>
    [Sdk4meEntity(ignoreIdentifier: true)]
    public class SlaNotificationRule : Node
    {
        /// <summary>
        /// The display debugger value.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string? DebuggerValue
        {
            get => ToString();
        }

        /// <summary>
        /// The unique identifier used by <see cref="DataList{T}"/>.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal override string UniqueIdentifier
        {
            get => GetHashCode().ToString();
        }

        /// <summary>
        /// Whether to notify the current assignee of the request.
        /// </summary>
        [JsonProperty("notifyCurrentAssignee"), Sdk4meField(IsDefaultQueryProperty = true)]
        public bool? NotifyCurrentAssignee { get; internal set; }

        /// <summary>
        /// Whether to notify the first line team coordinator of the service instance of the affected SLA.
        /// </summary>
        [JsonProperty("notifyFirstLineTeamCoordinator"), Sdk4meField(IsDefaultQueryProperty = true)]
        public bool? NotifyFirstLineTeamCoordinator { get; internal set; }

        /// <summary>
        /// Whether to notify the first line team manager of the service instance of the affected SLA.
        /// </summary>
        [JsonProperty("notifyFirstLineTeamManager"), Sdk4meField(IsDefaultQueryProperty = true)]
        public bool? NotifyFirstLineTeamManager { get; internal set; }

        /// <summary>
        /// Whether to notify the service owner of the service of the affected SLA.
        /// </summary>
        [JsonProperty("notifyServiceOwner"), Sdk4meField(IsDefaultQueryProperty = true)]
        public bool? NotifyServiceOwner { get; internal set; }

        /// <summary>
        /// Whether to notify the support team coordinator of the service instance of the affected SLA.
        /// </summary>
        [JsonProperty("notifySupportTeamCoordinator"), Sdk4meField(IsDefaultQueryProperty = true)]
        public bool? NotifySupportTeamCoordinator { get; internal set; }

        /// <summary>
        /// Whether to notify the support team manager of the service instance of the affected SLA.
        /// </summary>
        [JsonProperty("notifySupportTeamManager"), Sdk4meField(IsDefaultQueryProperty = true)]
        public bool? NotifySupportTeamManager { get; internal set; }

        /// <summary>
        /// The percentage of the target duration when a notification should be generated.
        /// </summary>
        [JsonProperty("thresholdPercentage"), Sdk4meField(IsDefaultQueryProperty = true)]
        public long? ThresholdPercentage { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
