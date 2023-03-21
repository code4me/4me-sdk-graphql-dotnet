namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/slanotificationruleinput/">SlaNotificationRuleInput</see> object.
    /// </summary>
    public class SlaNotificationRuleInput : PropertyChangeSet
    {
        private string? id;
        private long? thresholdPercentage;
        private bool? notifyCurrentAssignee;
        private bool? notifyFirstLineTeamCoordinator;
        private bool? notifyFirstLineTeamManager;
        private bool? notifyServiceOwner;
        private bool? notifySupportTeamCoordinator;
        private bool? notifySupportTeamManager;

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
        /// The percentage of the resolution target duration when a notification should be generated.
        /// </summary>
        [JsonProperty("thresholdPercentage")]
        public long? ThresholdPercentage
        {
            get => thresholdPercentage;
            set => thresholdPercentage = Set("thresholdPercentage", value);
        }

        /// <summary>
        /// Whether to notify the current assignee of the request.
        /// </summary>
        [JsonProperty("notifyCurrentAssignee")]
        public bool? NotifyCurrentAssignee
        {
            get => notifyCurrentAssignee;
            set => notifyCurrentAssignee = Set("notifyCurrentAssignee", value);
        }

        /// <summary>
        /// Whether to notify the first line team coordinator of the service instance of the affected SLA.
        /// </summary>
        [JsonProperty("notifyFirstLineTeamCoordinator")]
        public bool? NotifyFirstLineTeamCoordinator
        {
            get => notifyFirstLineTeamCoordinator;
            set => notifyFirstLineTeamCoordinator = Set("notifyFirstLineTeamCoordinator", value);
        }

        /// <summary>
        /// Whether to notify the first line team manager of the service instance of the affected SLA.
        /// </summary>
        [JsonProperty("notifyFirstLineTeamManager")]
        public bool? NotifyFirstLineTeamManager
        {
            get => notifyFirstLineTeamManager;
            set => notifyFirstLineTeamManager = Set("notifyFirstLineTeamManager", value);
        }

        /// <summary>
        /// Whether to notify the service owner of the service of the affected SLA.
        /// </summary>
        [JsonProperty("notifyServiceOwner")]
        public bool? NotifyServiceOwner
        {
            get => notifyServiceOwner;
            set => notifyServiceOwner = Set("notifyServiceOwner", value);
        }

        /// <summary>
        /// Whether to notify the support team coordinator of the service instance of the affected SLA.
        /// </summary>
        [JsonProperty("notifySupportTeamCoordinator")]
        public bool? NotifySupportTeamCoordinator
        {
            get => notifySupportTeamCoordinator;
            set => notifySupportTeamCoordinator = Set("notifySupportTeamCoordinator", value);
        }

        /// <summary>
        /// Whether to notify the support team manager of the service instance of the affected SLA.
        /// </summary>
        [JsonProperty("notifySupportTeamManager")]
        public bool? NotifySupportTeamManager
        {
            get => notifySupportTeamManager;
            set => notifySupportTeamManager = Set("notifySupportTeamManager", value);
        }
    }
}
