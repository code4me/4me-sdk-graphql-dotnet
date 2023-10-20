namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/serviceofferingupdateinput/">ServiceOfferingUpdateInput</see> object.
    /// </summary>
    public class ServiceOfferingUpdateInput : PropertyChangeSet
    {
        private decimal? availability;
        private string? charges;
        private ServiceOfferingChargeType? chargeTypeHigh;
        private ServiceOfferingChargeType? chargeTypeLow;
        private ServiceOfferingChargeType? chargeTypeMedium;
        private ServiceOfferingChargeType? chargeTypeRfc;
        private ServiceOfferingChargeType? chargeTypeRfi;
        private ServiceOfferingChargeType? chargeTypeTop;
        private string? clientMutationId;
        private string? continuity;
        private string? defaultEffortClassId;
        private List<string>? effortClassIds;
        private List<string>? effortClassRatesToDelete;
        private string? id;
        private string? limitations;
        private string? name;
        private List<EffortClassRateInput>? newEffortClassRates;
        private List<StandardServiceRequestInput>? newStandardServiceRequests;
        private string? penalties;
        private string? performance;
        private string? prerequisites;
        private decimal? rateHigh;
        private string? rateHighCurrency;
        private decimal? rateLow;
        private string? rateLowCurrency;
        private decimal? rateMedium;
        private string? rateMediumCurrency;
        private decimal? rateRfc;
        private string? rateRfcCurrency;
        private decimal? rateRfi;
        private string? rateRfiCurrency;
        private decimal? rateTop;
        private string? rateTopCurrency;
        private long? recoveryPointObjective;
        private long? recoveryTimeObjective;
        private string? reliability;
        private ServiceOfferingReportFrequency? reportFrequency;
        private long? resolutionsWithinTarget;
        private long? resolutionTargetHigh;
        private long? resolutionTargetLow;
        private long? resolutionTargetMedium;
        private long? resolutionTargetRfc;
        private long? resolutionTargetRfi;
        private long? resolutionTargetTop;
        private long? responsesWithinTarget;
        private long? responseTargetHigh;
        private long? responseTargetLow;
        private long? responseTargetMedium;
        private long? responseTargetRfc;
        private long? responseTargetRfi;
        private long? responseTargetTop;
        private ServiceOfferingReviewFrequency? reviewFrequency;
        private string? serviceHoursId;
        private string? serviceId;
        private string? source;
        private string? sourceID;
        private List<string>? standardServiceRequestsToDelete;
        private ServiceOfferingStatus? status;
        private string? summary;
        private string? supportHoursHighId;
        private string? supportHoursLowId;
        private string? supportHoursMediumId;
        private string? supportHoursRfcId;
        private string? supportHoursRfiId;
        private string? supportHoursTopId;
        private string? termination;
        private string? timeZone;

        /// <summary>
        /// The duration, expressed as percentage of the total number of service hours, during which the service is to be available to customers with an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("availability")]
        public decimal? Availability
        {
            get => availability;
            set => availability = Set("availability", value);
        }

        /// <summary>
        /// The amount that the service provider will charge the customer for the delivery of the service per charge driver, per charge term.
        /// </summary>
        [JsonProperty("charges")]
        public string? Charges
        {
            get => charges;
            set => charges = Set("charges", value);
        }

        /// <summary>
        /// Defines how a high incident must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [JsonProperty("chargeTypeHigh")]
        public ServiceOfferingChargeType? ChargeTypeHigh
        {
            get => chargeTypeHigh;
            set => chargeTypeHigh = Set("chargeTypeHigh", value);
        }

        /// <summary>
        /// Defines how a low incident must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [JsonProperty("chargeTypeLow")]
        public ServiceOfferingChargeType? ChargeTypeLow
        {
            get => chargeTypeLow;
            set => chargeTypeLow = Set("chargeTypeLow", value);
        }

        /// <summary>
        /// Defines how a medium incident must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [JsonProperty("chargeTypeMedium")]
        public ServiceOfferingChargeType? ChargeTypeMedium
        {
            get => chargeTypeMedium;
            set => chargeTypeMedium = Set("chargeTypeMedium", value);
        }

        /// <summary>
        /// Defines how a RFC must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [JsonProperty("chargeTypeRfc")]
        public ServiceOfferingChargeType? ChargeTypeRfc
        {
            get => chargeTypeRfc;
            set => chargeTypeRfc = Set("chargeTypeRfc", value);
        }

        /// <summary>
        /// Defines how a RFI must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [JsonProperty("chargeTypeRfi")]
        public ServiceOfferingChargeType? ChargeTypeRfi
        {
            get => chargeTypeRfi;
            set => chargeTypeRfi = Set("chargeTypeRfi", value);
        }

        /// <summary>
        /// Defines how a top incident must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [JsonProperty("chargeTypeTop")]
        public ServiceOfferingChargeType? ChargeTypeTop
        {
            get => chargeTypeTop;
            set => chargeTypeTop = Set("chargeTypeTop", value);
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
        /// The continuity measures for the service offering.
        /// </summary>
        [JsonProperty("continuity")]
        public string? Continuity
        {
            get => continuity;
            set => continuity = Set("continuity", value);
        }

        /// <summary>
        /// Identifier of the effort class that is selected by default, when someone registers time on a request with an affected SLA linked to this service offering.
        /// </summary>
        [JsonProperty("defaultEffortClassId")]
        public string? DefaultEffortClassId
        {
            get => defaultEffortClassId;
            set => defaultEffortClassId = Set("defaultEffortClassId", value);
        }

        /// <summary>
        /// Identifiers of effort classes of the service offering.
        /// </summary>
        [JsonProperty("effortClassIds")]
        public List<string>? EffortClassIds
        {
            get => effortClassIds;
            set => effortClassIds = Set("effortClassIds", value);
        }

        /// <summary>
        /// Identifiers of effort class rates to remove from the service offering.
        /// </summary>
        [JsonProperty("effortClassRatesToDelete")]
        public List<string>? EffortClassRatesToDelete
        {
            get => effortClassRatesToDelete;
            set => effortClassRatesToDelete = Set("effortClassRatesToDelete", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// The limitations that apply to the service level agreements that are based on the service offering.
        /// </summary>
        [JsonProperty("limitations")]
        public string? Limitations
        {
            get => limitations;
            set => limitations = Set("limitations", value);
        }

        /// <summary>
        /// The name of the service offering.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// Effort class rates of the service offering.
        /// </summary>
        [JsonProperty("newEffortClassRates")]
        public List<EffortClassRateInput>? NewEffortClassRates
        {
            get => newEffortClassRates;
            set => newEffortClassRates = Set("newEffortClassRates", value);
        }

        /// <summary>
        /// Standard service requests of the service offering.
        /// </summary>
        [JsonProperty("newStandardServiceRequests")]
        public List<StandardServiceRequestInput>? NewStandardServiceRequests
        {
            get => newStandardServiceRequests;
            set => newStandardServiceRequests = Set("newStandardServiceRequests", value);
        }

        /// <summary>
        /// Used to specify what the penalties will be for the service provider organization if a service level target has been breached.
        /// </summary>
        [JsonProperty("penalties")]
        public string? Penalties
        {
            get => penalties;
            set => penalties = Set("penalties", value);
        }

        /// <summary>
        /// Used to describe the transaction(s) and the maximum time these transaction(s) can take to complete.
        /// </summary>
        [JsonProperty("performance")]
        public string? Performance
        {
            get => performance;
            set => performance = Set("performance", value);
        }

        /// <summary>
        /// Used to specify which requirements need to be met by the customer in order for the customer to be able to benefit from the service. The service provider cannot be held accountable for breaches of the service level targets caused by a failure of the customer to meet one or more of these prerequisites.
        /// </summary>
        [JsonProperty("prerequisites")]
        public string? Prerequisites
        {
            get => prerequisites;
            set => prerequisites = Set("prerequisites", value);
        }

        /// <summary>
        /// Defines the fixed price rate for a high incident.
        /// </summary>
        [JsonProperty("rateHigh")]
        public decimal? RateHigh
        {
            get => rateHigh;
            set => rateHigh = Set("rateHigh", value);
        }

        /// <summary>
        /// <br>Defines the currency for the fixed price rate of a high incident.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("rateHighCurrency")]
        public string? RateHighCurrency
        {
            get => rateHighCurrency;
            set => rateHighCurrency = Set("rateHighCurrency", value);
        }

        /// <summary>
        /// Defines the fixed price rate for a low incident.
        /// </summary>
        [JsonProperty("rateLow")]
        public decimal? RateLow
        {
            get => rateLow;
            set => rateLow = Set("rateLow", value);
        }

        /// <summary>
        /// <br>Defines the currency for the fixed price rate of a low incident.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("rateLowCurrency")]
        public string? RateLowCurrency
        {
            get => rateLowCurrency;
            set => rateLowCurrency = Set("rateLowCurrency", value);
        }

        /// <summary>
        /// Defines the fixed price rate for a medium incident.
        /// </summary>
        [JsonProperty("rateMedium")]
        public decimal? RateMedium
        {
            get => rateMedium;
            set => rateMedium = Set("rateMedium", value);
        }

        /// <summary>
        /// <br>Defines the currency for the fixed price rate of a medium incident.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("rateMediumCurrency")]
        public string? RateMediumCurrency
        {
            get => rateMediumCurrency;
            set => rateMediumCurrency = Set("rateMediumCurrency", value);
        }

        /// <summary>
        /// Defines the fixed price rate for a RFC.
        /// </summary>
        [JsonProperty("rateRfc")]
        public decimal? RateRfc
        {
            get => rateRfc;
            set => rateRfc = Set("rateRfc", value);
        }

        /// <summary>
        /// <br>Defines the currency for the fixed price rate of a RFC.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("rateRfcCurrency")]
        public string? RateRfcCurrency
        {
            get => rateRfcCurrency;
            set => rateRfcCurrency = Set("rateRfcCurrency", value);
        }

        /// <summary>
        /// Defines the fixed price rate for a RFI.
        /// </summary>
        [JsonProperty("rateRfi")]
        public decimal? RateRfi
        {
            get => rateRfi;
            set => rateRfi = Set("rateRfi", value);
        }

        /// <summary>
        /// <br>Defines the currency for the fixed price rate of a RFI.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("rateRfiCurrency")]
        public string? RateRfiCurrency
        {
            get => rateRfiCurrency;
            set => rateRfiCurrency = Set("rateRfiCurrency", value);
        }

        /// <summary>
        /// Defines the fixed price rate for a top incident.
        /// </summary>
        [JsonProperty("rateTop")]
        public decimal? RateTop
        {
            get => rateTop;
            set => rateTop = Set("rateTop", value);
        }

        /// <summary>
        /// <br>Defines the currency for the fixed price rate of a top incident.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("rateTopCurrency")]
        public string? RateTopCurrency
        {
            get => rateTopCurrency;
            set => rateTopCurrency = Set("rateTopCurrency", value);
        }

        /// <summary>
        /// The Recovery Point Objective (RPO) is the maximum targeted duration in minutes in which data (transactions) might be lost from an IT service due to a major incident.
        /// </summary>
        [JsonProperty("recoveryPointObjective")]
        public long? RecoveryPointObjective
        {
            get => recoveryPointObjective;
            set => recoveryPointObjective = Set("recoveryPointObjective", value);
        }

        /// <summary>
        /// The Recovery Time Objective (RTO) is the maximum targeted duration in minutes in which a business process must be restored after a disaster (or disruption) in order to avoid unacceptable consequences associated with a break in business continuity.
        /// </summary>
        [JsonProperty("recoveryTimeObjective")]
        public long? RecoveryTimeObjective
        {
            get => recoveryTimeObjective;
            set => recoveryTimeObjective = Set("recoveryTimeObjective", value);
        }

        /// <summary>
        /// Used to specify the maximum number of times per month that the service may become unavailable to customers with an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("reliability")]
        public string? Reliability
        {
            get => reliability;
            set => reliability = Set("reliability", value);
        }

        /// <summary>
        /// Used to specify how often the representative of a customer of an active SLA that is based on the service offering will receive a report comparing the service level targets specified in the service offering with the actual level of service provided.
        /// </summary>
        [JsonProperty("reportFrequency")]
        public ServiceOfferingReportFrequency? ReportFrequency
        {
            get => reportFrequency;
            set => reportFrequency = Set("reportFrequency", value);
        }

        /// <summary>
        /// The minimum percentage of incidents that is to be resolved before their resolution target.
        /// </summary>
        [JsonProperty("resolutionsWithinTarget")]
        public long? ResolutionsWithinTarget
        {
            get => resolutionsWithinTarget;
            set => resolutionsWithinTarget = Set("resolutionsWithinTarget", value);
        }

        /// <summary>
        /// The number of minutes within which a request with the impact value "High - Service Degraded for Several Users" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetHigh")]
        public long? ResolutionTargetHigh
        {
            get => resolutionTargetHigh;
            set => resolutionTargetHigh = Set("resolutionTargetHigh", value);
        }

        /// <summary>
        /// The number of minutes within which a request with the impact value "Low - Service Degraded for One User" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetLow")]
        public long? ResolutionTargetLow
        {
            get => resolutionTargetLow;
            set => resolutionTargetLow = Set("resolutionTargetLow", value);
        }

        /// <summary>
        /// The number of minutes within which a request with the impact value "Medium - Service Down for One User" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetMedium")]
        public long? ResolutionTargetMedium
        {
            get => resolutionTargetMedium;
            set => resolutionTargetMedium = Set("resolutionTargetMedium", value);
        }

        /// <summary>
        /// The number of minutes within which a request with the category "RFC - Request for Change" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetRfc")]
        public long? ResolutionTargetRfc
        {
            get => resolutionTargetRfc;
            set => resolutionTargetRfc = Set("resolutionTargetRfc", value);
        }

        /// <summary>
        /// The number of minutes within which a request with the category "RFI - Request for Information" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetRfi")]
        public long? ResolutionTargetRfi
        {
            get => resolutionTargetRfi;
            set => resolutionTargetRfi = Set("resolutionTargetRfi", value);
        }

        /// <summary>
        /// The number of minutes within which a request with the impact value "Top - Service Down for Several Users" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetTop")]
        public long? ResolutionTargetTop
        {
            get => resolutionTargetTop;
            set => resolutionTargetTop = Set("resolutionTargetTop", value);
        }

        /// <summary>
        /// The minimum percentage of incidents that is to be responded to before their response target.
        /// </summary>
        [JsonProperty("responsesWithinTarget")]
        public long? ResponsesWithinTarget
        {
            get => responsesWithinTarget;
            set => responsesWithinTarget = Set("responsesWithinTarget", value);
        }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetHigh")]
        public long? ResponseTargetHigh
        {
            get => responseTargetHigh;
            set => responseTargetHigh = Set("responseTargetHigh", value);
        }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetLow")]
        public long? ResponseTargetLow
        {
            get => responseTargetLow;
            set => responseTargetLow = Set("responseTargetLow", value);
        }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetMedium")]
        public long? ResponseTargetMedium
        {
            get => responseTargetMedium;
            set => responseTargetMedium = Set("responseTargetMedium", value);
        }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the category "RFC - Request for Change" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetRfc")]
        public long? ResponseTargetRfc
        {
            get => responseTargetRfc;
            set => responseTargetRfc = Set("responseTargetRfc", value);
        }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the category "RFI - Request for Information" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetRfi")]
        public long? ResponseTargetRfi
        {
            get => responseTargetRfi;
            set => responseTargetRfi = Set("responseTargetRfi", value);
        }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetTop")]
        public long? ResponseTargetTop
        {
            get => responseTargetTop;
            set => responseTargetTop = Set("responseTargetTop", value);
        }

        /// <summary>
        /// How often an active SLA that is based on the service offering will be reviewed with the representative of its customer.
        /// </summary>
        [JsonProperty("reviewFrequency")]
        public ServiceOfferingReviewFrequency? ReviewFrequency
        {
            get => reviewFrequency;
            set => reviewFrequency = Set("reviewFrequency", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the hours during which the service is supposed to be available.
        /// </summary>
        [JsonProperty("serviceHoursId")]
        public string? ServiceHoursId
        {
            get => serviceHoursId;
            set => serviceHoursId = Set("serviceHoursId", value);
        }

        /// <summary>
        /// Identifier of the service for which the service offering is being prepared.
        /// </summary>
        [JsonProperty("serviceId")]
        public string? ServiceId
        {
            get => serviceId;
            set => serviceId = Set("serviceId", value);
        }

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
        /// Identifiers of standard service requests to remove from the service offering.
        /// </summary>
        [JsonProperty("standardServiceRequestsToDelete")]
        public List<string>? StandardServiceRequestsToDelete
        {
            get => standardServiceRequestsToDelete;
            set => standardServiceRequestsToDelete = Set("standardServiceRequestsToDelete", value);
        }

        /// <summary>
        /// The current status of the service offering.
        /// </summary>
        [JsonProperty("status")]
        public ServiceOfferingStatus? Status
        {
            get => status;
            set => status = Set("status", value);
        }

        /// <summary>
        /// A high-level description of the differentiators between this service offering and other service offerings that have already been, or could be, prepared for the same service.
        /// </summary>
        [JsonProperty("summary")]
        public string? Summary
        {
            get => summary;
            set => summary = Set("summary", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHoursHighId")]
        public string? SupportHoursHighId
        {
            get => supportHoursHighId;
            set => supportHoursHighId = Set("supportHoursHighId", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHoursLowId")]
        public string? SupportHoursLowId
        {
            get => supportHoursLowId;
            set => supportHoursLowId = Set("supportHoursLowId", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHoursMediumId")]
        public string? SupportHoursMediumId
        {
            get => supportHoursMediumId;
            set => supportHoursMediumId = Set("supportHoursMediumId", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours for a request with the category "RFC - Request for Change" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHoursRfcId")]
        public string? SupportHoursRfcId
        {
            get => supportHoursRfcId;
            set => supportHoursRfcId = Set("supportHoursRfcId", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours for a request with the category "RFI - Request for Information" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHoursRfiId")]
        public string? SupportHoursRfiId
        {
            get => supportHoursRfiId;
            set => supportHoursRfiId = Set("supportHoursRfiId", value);
        }

        /// <summary>
        /// Identifier of the calendar that defines the support hours for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHoursTopId")]
        public string? SupportHoursTopId
        {
            get => supportHoursTopId;
            set => supportHoursTopId = Set("supportHoursTopId", value);
        }

        /// <summary>
        /// Used to describe the length of notice required for changing or terminating the service level agreement.
        /// </summary>
        [JsonProperty("termination")]
        public string? Termination
        {
            get => termination;
            set => termination = Set("termination", value);
        }

        /// <summary>
        /// <br>The time zone that applies to the selected service hours.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone
        {
            get => timeZone;
            set => timeZone = Set("timeZone", value);
        }
    }
}
