namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/standardservicerequestinput/">StandardServiceRequestInput</see> object.
    /// </summary>
    public class StandardServiceRequestInput : PropertyChangeSet
    {
        private string? id;
        private string? requestTemplateId;
        private long? responseTarget;
        private long? resolutionTarget;
        private string? supportHoursId;
        private string? slaNotificationSchemeId;
        private ServiceOfferingChargeType? chargeType;
        private decimal? rate;
        private string? rateCurrency;

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
        /// Identifier of the request template related to the service offering. Only the request templates that are linked to the same service as the service offering can be selected.
        /// </summary>
        [JsonProperty("requestTemplateId")]
        public string? RequestTemplateId
        {
            get => requestTemplateId;
            set => requestTemplateId = Set("requestTemplateId", value);
        }

        /// <summary>
        /// Number of minutes within which a response needs to have been provided for a request to which the request template has been applied and which requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTarget")]
        public long? ResponseTarget
        {
            get => responseTarget;
            set => responseTarget = Set("responseTarget", value);
        }

        /// <summary>
        /// Number of minutes within which a request needs to have been completed when the request template has been applied to the request and the requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTarget")]
        public long? ResolutionTarget
        {
            get => resolutionTarget;
            set => resolutionTarget = Set("resolutionTarget", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours for a request to which the request template has been applied and which requester is covered by an SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHoursId")]
        public string? SupportHoursId
        {
            get => supportHoursId;
            set => supportHoursId = Set("supportHoursId", value);
        }

        /// <summary>
        /// Identifier of the SLA notification scheme for a request when it affects an active SLA that is based on the service offering. Only enabled SLA notification schemes that are linked to the same account as the service offering can be selected.
        /// </summary>
        [JsonProperty("slaNotificationSchemeId")]
        public string? SlaNotificationSchemeId
        {
            get => slaNotificationSchemeId;
            set => slaNotificationSchemeId = Set("slaNotificationSchemeId", value);
        }

        /// <summary>
        /// Defines how a standard service request must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [JsonProperty("chargeType")]
        public ServiceOfferingChargeType? ChargeType
        {
            get => chargeType;
            set => chargeType = Set("chargeType", value);
        }

        /// <summary>
        /// Defines the fixed price rate for a standard service request.
        /// </summary>
        [JsonProperty("rate")]
        public decimal? Rate
        {
            get => rate;
            set => rate = Set("rate", value);
        }

        /// <summary>
        /// <br>Defines the currency for the fixed price rate of a standard service request.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("rateCurrency")]
        public string? RateCurrency
        {
            get => rateCurrency;
            set => rateCurrency = Set("rateCurrency", value);
        }
    }
}
