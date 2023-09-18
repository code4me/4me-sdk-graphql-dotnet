namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/broadcastcreateinput/">BroadcastCreateInput</see> object.
    /// </summary>
    public class BroadcastCreateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private bool? disabled;
        private DateTime? startAt;
        private DateTime? endAt;
        private string? timeZone;
        private BroadcastVisibility? visibility;
        private List<string>? customerIds;
        private List<string>? serviceInstanceIds;
        private List<string>? teamIds;
        private string? clientMutationId;
        private string? message;
        private BroadcastMessageType? messageType;

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// Whether the message should not be broadcasted.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// The start date and time of the broadcast. (If the broadcast should start at midnight at the start of a day, specify 00:00.)
        /// </summary>
        [JsonProperty("startAt")]
        public DateTime? StartAt
        {
            get => startAt;
            set => startAt = Set("startAt", value);
        }

        /// <summary>
        /// The end date and time of the broadcast. This field is left empty when the message is to be broadcasted until the Disabled box is checked. (If the broadcast should end at midnight at the end of a day, specify 12:00am or 24:00.)
        /// </summary>
        [JsonProperty("endAt")]
        public DateTime? EndAt
        {
            get => endAt;
            set => endAt = Set("endAt", value);
        }

        /// <summary>
        /// <br>The time zone that applies to the dates and times specified in the Start and End fields.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone
        {
            get => timeZone;
            set => timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// Defines the target audience of the broadcast.
        /// </summary>
        [JsonProperty("visibility")]
        public BroadcastVisibility? Visibility
        {
            get => visibility;
            set => visibility = Set("visibility", value);
        }

        /// <summary>
        /// The customer organizations when the broadcast is to be displayed for the specialists of the account in requests that were received from the selected organizations. This is available only when the "Specialists in requests from the following customers" visibility option is selected.
        /// </summary>
        [JsonProperty("customerIds")]
        public List<string>? CustomerIds
        {
            get => customerIds;
            set => customerIds = Set("customerIds", value);
        }

        /// <summary>
        /// The service instances for which the people, who are covered for them by an active SLA, need to see the broadcast. This is available only when the "People covered for the following service instance(s)" visibility option is selected.
        /// </summary>
        [JsonProperty("serviceInstanceIds")]
        public List<string>? ServiceInstanceIds
        {
            get => serviceInstanceIds;
            set => serviceInstanceIds = Set("serviceInstanceIds", value);
        }

        /// <summary>
        /// The teams which members need to see the broadcast. This is available only when the "Members of the following team(s)" visibility option is selected.
        /// </summary>
        [JsonProperty("teamIds")]
        public List<string>? TeamIds
        {
            get => teamIds;
            set => teamIds = Set("teamIds", value);
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// Message that is to be broadcasted in the language of the account.
        /// </summary>
        [JsonProperty("message")]
        public string? Message
        {
            get => message;
            set => message = Set("message", value);
        }

        /// <summary>
        /// The appropriate icon for the message. The selected icon is displayed alongside the message when the broadcast is presented.
        /// </summary>
        [JsonProperty("messageType")]
        public BroadcastMessageType? MessageType
        {
            get => messageType;
            set => messageType = Set("messageType", value);
        }
    }
}
