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
        [JsonProperty("notifyCurrentAssignee"), Sdk4meField(true)]
        public bool? NotifyCurrentAssignee { get; internal set; }

        /// <summary>
        /// Whether to notify the first line team coordinator of the service instance of the affected service level agreement.
        /// </summary>
        [JsonProperty("notifyFirstLineTeamCoordinator"), Sdk4meField(true)]
        public bool? NotifyFirstLineTeamCoordinator { get; internal set; }

        /// <summary>
        /// Whether to notify the first line team manager of the service instance of the affected service level agreement.
        /// </summary>
        [JsonProperty("notifyFirstLineTeamManager"), Sdk4meField(true)]
        public bool? NotifyFirstLineTeamManager { get; internal set; }

        /// <summary>
        /// Whether to notify the service owner of the service of the affected service level agreement.
        /// </summary>
        [JsonProperty("notifyServiceOwner"), Sdk4meField(true)]
        public bool? NotifyServiceOwner { get; internal set; }

        /// <summary>
        /// Whether to notify the support team coordinator of the service instance of the affected service level agreement.
        /// </summary>
        [JsonProperty("notifySupportTeamCoordinator"), Sdk4meField(true)]
        public bool? NotifySupportTeamCoordinator { get; internal set; }

        /// <summary>
        /// Whether to notify the support team manager of the service instance of the affected service level agreement.
        /// </summary>
        [JsonProperty("notifySupportTeamManager"), Sdk4meField(true)]
        public bool? NotifySupportTeamManager { get; internal set; }

        /// <summary>
        /// The percentage of the resolution target duration when a notification should be generated.
        /// </summary>
        [JsonProperty("thresholdPercentage"), Sdk4meField(true)]
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
