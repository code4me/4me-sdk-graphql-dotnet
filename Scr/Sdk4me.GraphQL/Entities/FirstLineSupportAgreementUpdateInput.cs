namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/firstlinesupportagreementupdateinput/">FirstLineSupportAgreementUpdateInput</see> object.
    /// </summary>
    public class FirstLineSupportAgreementUpdateInput : PropertyChangeSet
    {
        private string? source;
        private string? sourceID;
        private string? name;
        private AgreementStatus? status;
        private string? customerId;
        private string? customerRepresentativeId;
        private string? providerId;
        private string? serviceDeskTeamId;
        private DateOnly? startDate;
        private DateOnly? noticeDate;
        private DateOnly? expiryDate;
        private string? supportHoursId;
        private string? timeZone;
        private long? pickupTarget;
        private long? supportChatPickupTarget;
        private long? pickupsWithinTarget;
        private long? firstCallResolutions;
        private long? serviceDeskOnlyResolutions;
        private long? serviceDeskResolutions;
        private long? rejectedSolutions;
        private string? targetDetails;
        private string? charges;
        private string? remarks;
        private string? id;
        private string? clientMutationId;

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
        /// The name of the first line support agreement.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The current status of the first line support agreement (FLSA).
        /// </summary>
        [JsonProperty("status")]
        public AgreementStatus? Status
        {
            get => status;
            set => status = Set("status", value);
        }

        /// <summary>
        /// Identifier of the organization that pays for the first line support agreement.
        /// </summary>
        [JsonProperty("customerId")]
        public string? CustomerId
        {
            get => customerId;
            set => customerId = Set("customerId", value);
        }

        /// <summary>
        /// Identifier of the customer representative.
        /// </summary>
        [JsonProperty("customerRepresentativeId")]
        public string? CustomerRepresentativeId
        {
            get => customerRepresentativeId;
            set => customerRepresentativeId = Set("customerRepresentativeId", value);
        }

        /// <summary>
        /// Identifier of the organization that provides the first line support agreement.
        /// </summary>
        [JsonProperty("providerId")]
        public string? ProviderId
        {
            get => providerId;
            set => providerId = Set("providerId", value);
        }

        /// <summary>
        /// Identifier of the specific team within the first line support provider organization that provides first line support for the users covered by the first line support agreement.
        /// </summary>
        [JsonProperty("serviceDeskTeamId")]
        public string? ServiceDeskTeamId
        {
            get => serviceDeskTeamId;
            set => serviceDeskTeamId = Set("serviceDeskTeamId", value);
        }

        /// <summary>
        /// The first day during which the first line support agreement (FLSA) is active.
        /// </summary>
        [JsonProperty("startDate")]
        public DateOnly? StartDate
        {
            get => startDate;
            set => startDate = Set("startDate", value);
        }

        /// <summary>
        /// The last day on which the first line support provider organization can still be contacted to terminate the first line support agreement (FLSA) to ensure that it expires on the intended expiry date. The Notice date field is left empty, and the Expiry date field is filled out, when the FLSA is to expire on a specific date and no notice needs to be given to terminate it.
        /// </summary>
        [JsonProperty("noticeDate")]
        public DateOnly? NoticeDate
        {
            get => noticeDate;
            set => noticeDate = Set("noticeDate", value);
        }

        /// <summary>
        /// The date through which the first line support agreement (FLSA) will be active. The FLSA expires at the end of this day if it is not renewed before then. When the FLSA has expired, its status will automatically be set to "Expired".
        /// </summary>
        [JsonProperty("expiryDate")]
        public DateOnly? ExpiryDate
        {
            get => expiryDate;
            set => expiryDate = Set("expiryDate", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours during which the service desk team can be contacted for first line support.
        /// </summary>
        [JsonProperty("supportHoursId")]
        public string? SupportHoursId
        {
            get => supportHoursId;
            set => supportHoursId = Set("supportHoursId", value);
        }

        /// <summary>
        /// <br>The time zone that applies to the start, notice and expiry dates, and to the support hours.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see></br>.
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone
        {
            get => timeZone;
            set => timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// The number of minutes within which a new or existing request that has been assigned to the service desk team is assigned to a specific member within the service desk team, is assigned to another team, or is set to a status other than `assigned`.
        /// </summary>
        [JsonProperty("pickupTarget")]
        public long? PickupTarget
        {
            get => pickupTarget;
            set => pickupTarget = Set("pickupTarget", value);
        }

        /// <summary>
        /// The number of minutes within which a new or existing chat request that has been assigned to the service desk team is assigned to a specific member within the service desk team, is assigned to another team, or is set to a status other than `assigned`.
        /// </summary>
        [JsonProperty("supportChatPickupTarget")]
        public long? SupportChatPickupTarget
        {
            get => supportChatPickupTarget;
            set => supportChatPickupTarget = Set("supportChatPickupTarget", value);
        }

        /// <summary>
        /// The minimum percentage of requests that are to be picked up by the service desk team within the pickup target.
        /// </summary>
        [JsonProperty("pickupsWithinTarget")]
        public long? PickupsWithinTarget
        {
            get => pickupsWithinTarget;
            set => pickupsWithinTarget = Set("pickupsWithinTarget", value);
        }

        /// <summary>
        /// The minimum percentage of requests that are to be completed by the service desk team during their registration.
        /// </summary>
        [JsonProperty("firstCallResolutions")]
        public long? FirstCallResolutions
        {
            get => firstCallResolutions;
            set => firstCallResolutions = Set("firstCallResolutions", value);
        }

        /// <summary>
        /// The minimum percentage of requests that are to be completed by the service desk team without having been assigned to any other team within the account that is covered by the first line support agreement.
        /// </summary>
        [JsonProperty("serviceDeskOnlyResolutions")]
        public long? ServiceDeskOnlyResolutions
        {
            get => serviceDeskOnlyResolutions;
            set => serviceDeskOnlyResolutions = Set("serviceDeskOnlyResolutions", value);
        }

        /// <summary>
        /// The minimum percentage of requests that are to be completed by the service desk team.
        /// </summary>
        [JsonProperty("serviceDeskResolutions")]
        public long? ServiceDeskResolutions
        {
            get => serviceDeskResolutions;
            set => serviceDeskResolutions = Set("serviceDeskResolutions", value);
        }

        /// <summary>
        /// The maximum percentage of requests that were reopened (i.e. which status in the account that is covered by the first line support agreement was updated from `completed` to another status).
        /// </summary>
        [JsonProperty("rejectedSolutions")]
        public long? RejectedSolutions
        {
            get => rejectedSolutions;
            set => rejectedSolutions = Set("rejectedSolutions", value);
        }

        /// <summary>
        /// A description of all the targets of the first line support agreement.
        /// </summary>
        [JsonProperty("targetDetails")]
        public string? TargetDetails
        {
            get => targetDetails;
            set => targetDetails = Set("targetDetails", value);
        }

        /// <summary>
        /// The amounts that the customer will be charged for the first line support agreement. These can be recurring as well as one-off charges.
        /// </summary>
        [JsonProperty("charges")]
        public string? Charges
        {
            get => charges;
            set => charges = Set("charges", value);
        }

        /// <summary>
        /// Any additional information about the first line support agreement that might prove useful.
        /// </summary>
        [JsonProperty("remarks")]
        public string? Remarks
        {
            get => remarks;
            set => remarks = Set("remarks", value);
        }

        /// <summary>
        /// The node identifier of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
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
    }
}
