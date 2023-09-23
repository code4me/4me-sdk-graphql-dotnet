namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/broadcast/">Broadcast</see> object.
    /// </summary>
    public class Broadcast : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The body used in email broadcast.
        /// </summary>
        [JsonProperty("body")]
        public string? Body { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        [JsonProperty("customers")]
        internal NodeCollection<Organization>? CustomersCollection { get; set; }

        /// <summary>
        /// Used to select one or more customer organizations when the broadcast is to be displayed for the specialists of the account in requests that were received from the selected organizations. This field is available only when the "Specialists in requests from the following customers" visibility option is selected.
        /// </summary>
        public DataList<Organization>? Customers
        {
            get => CustomersCollection?.Data;
        }

        /// <summary>
        /// Whether the message should not be broadcasted.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The email template used for the email broadcast. This email template needs to be of the type Send Email from Broadcast.
        /// </summary>
        [JsonProperty("emailTemplate")]
        public EmailTemplate? EmailTemplate { get; internal set; }

        /// <summary>
        /// Used to select the end date and time of the broadcast. This field is left empty when the message is to be broadcasted until the Disabled box is checked. (If the broadcast should end at midnight at the end of a day, specify 12:00am or 24:00.)
        /// </summary>
        [JsonProperty("endAt"), Sdk4meField(true)]
        public DateTime? EndAt { get; internal set; }

        /// <summary>
        /// Used to select the appropriate icon for the message. The selected icon is displayed alongside the message when the broadcast is presented.
        /// </summary>
        [JsonProperty("messageType"), Sdk4meField(true)]
        public BroadcastMessageType? MessageType { get; internal set; }

        /// <summary>
        /// Grouped request to which customers can add request to indicate they are also affected.
        /// </summary>
        [JsonProperty("request")]
        public Request? Request { get; internal set; }

        [JsonProperty("serviceInstances")]
        internal NodeCollection<ServiceInstance>? ServiceInstancesCollection { get; set; }

        /// <summary>
        /// Used to select the service instances for which the people, who are covered for them by an active SLA, need to see the broadcast. This table field is available only when the "People covered for the following service instance(s)" visibility option is selected.
        /// </summary>
        public DataList<ServiceInstance>? ServiceInstances
        {
            get => ServiceInstancesCollection?.Data;
        }

        [JsonProperty("slas")]
        internal NodeCollection<ServiceLevelAgreement>? SlasCollection { get; set; }

        /// <summary>
        /// Used to select the service level agreements for which the customer representatives will receive the email broadcast. This is only available for broadcasts when the message type "email" is selected.
        /// </summary>
        public DataList<ServiceLevelAgreement>? Slas
        {
            get => SlasCollection?.Data;
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(true)]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// Used to specify the start date and time of the broadcast. (If the broadcast should start at midnight at the start of a day, specify 00:00.)
        /// </summary>
        [JsonProperty("startAt"), Sdk4meField(true)]
        public DateTime? StartAt { get; internal set; }

        /// <summary>
        /// The subject used in email broadcasts.
        /// </summary>
        [JsonProperty("subject")]
        public string? Subject { get; internal set; }

        [JsonProperty("teams")]
        internal NodeCollection<Team>? TeamsCollection { get; set; }

        /// <summary>
        /// Used to select the teams which members need to see the broadcast. This table field is available only when the "Members of the following team(s)" visibility option is selected.
        /// </summary>
        public DataList<Team>? Teams
        {
            get => TeamsCollection?.Data;
        }

        /// <summary>
        /// <br>Used to select the time zone that applies to the dates and times specified in the Start and End fields.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Used to define the target audience of the broadcast.
        /// </summary>
        [JsonProperty("visibility")]
        public BroadcastVisibility? Visibility { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(CustomersCollection?.GetQueryPageInfo("customers", depth + 1));
            retval.AddRange(ServiceInstancesCollection?.GetQueryPageInfo("serviceInstances", depth + 1));
            retval.AddRange(SlasCollection?.GetQueryPageInfo("slas", depth + 1));
            retval.AddRange(TeamsCollection?.GetQueryPageInfo("teams", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Customers?.AddRange((data as Broadcast)?.Customers);
            ServiceInstances?.AddRange((data as Broadcast)?.ServiceInstances);
            Slas?.AddRange((data as Broadcast)?.Slas);
            Teams?.AddRange((data as Broadcast)?.Teams);
        }
    }
}
