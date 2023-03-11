namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/standardservicerequest/">StandardServiceRequest</see> object.
    /// </summary>
    public class StandardServiceRequest : Node
    {
        /// <summary>
        /// The date and time at which the standard service request was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The request template related to the service offering. Only the request templates that are linked to the same service as the service offering can be selected.
        /// </summary>
        [JsonProperty("requestTemplate"), Sdk4meField(true)]
        public RequestTemplate? RequestTemplate { get; internal set; }

        /// <summary>
        /// Number of minutes within which a request needs to have been completed when the request template has been applied to the request and the requester is covered by an service level agreement that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTarget")]
        public long? ResolutionTarget { get; internal set; }

        /// <summary>
        /// Number of business days within which a request needs to have been completed when the request template has been applied to the request and the requester is covered by an service level agreement that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetInDays")]
        public long? ResolutionTargetInDays { get; internal set; }

        /// <summary>
        /// Number of minutes within which a response needs to have been provided for a request to which the request template has been applied and which requester is covered by an service level agreement that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTarget")]
        public long? ResponseTarget { get; internal set; }

        /// <summary>
        /// Number of business days within which a response needs to have been provided for a request to which the request template has been applied and which requester is covered by an service level agreement that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetInDays")]
        public long? ResponseTargetInDays { get; internal set; }

        /// <summary>
        /// Service offering the standard service request belongs to.
        /// </summary>
        [JsonProperty("serviceOffering"), Sdk4meField(true)]
        public ServiceOffering? ServiceOffering { get; internal set; }

        /// <summary>
        /// The service level agreement notification scheme for a request when it affects an active service level agreement that is based on the service offering. Only enabled service level agreement notification schemes that are linked to the same account as the service offering can be selected.
        /// </summary>
        [JsonProperty("slaNotificationScheme")]
        public SlaNotificationScheme? SlaNotificationScheme { get; internal set; }

        /// <summary>
        /// The calendar that defines the support hours for a request to which the request template has been applied and which requester is covered by an service level agreement that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHours")]
        public Calendar? SupportHours { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the standard service request. If the standard service request has no updates it contains the `createdAt` value.
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
