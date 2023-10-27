namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/serviceoffering/">ServiceOffering</see> object.
    /// </summary>
    public class ServiceOffering : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The duration, expressed as percentage of the total number of service hours, during which the service is to be available to customers with an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("availability")]
        public decimal? Availability { get; internal set; }

        /// <summary>
        /// The amount that the service provider will charge the customer for the delivery of the service per charge driver, per charge term.
        /// </summary>
        [JsonProperty("charges")]
        public string? Charges { get; internal set; }

        [JsonProperty("chargesAttachments")]
        internal NodeCollection<Attachment>? ChargesAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Charges field.
        /// </summary>
        public DataList<Attachment>? ChargesAttachments
        {
            get => ChargesAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Defines how a Case must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [JsonProperty("chargeTypeCase")]
        public ServiceOfferingChargeType? ChargeTypeCase { get; internal set; }

        /// <summary>
        /// Defines how a high incident must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [JsonProperty("chargeTypeHigh")]
        public ServiceOfferingChargeType? ChargeTypeHigh { get; internal set; }

        /// <summary>
        /// Defines how a low incident must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [JsonProperty("chargeTypeLow")]
        public ServiceOfferingChargeType? ChargeTypeLow { get; internal set; }

        /// <summary>
        /// Defines how a medium incident must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [JsonProperty("chargeTypeMedium")]
        public ServiceOfferingChargeType? ChargeTypeMedium { get; internal set; }

        /// <summary>
        /// Defines how a RFC must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [JsonProperty("chargeTypeRfc")]
        public ServiceOfferingChargeType? ChargeTypeRfc { get; internal set; }

        /// <summary>
        /// Defines how a RFI must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [JsonProperty("chargeTypeRfi")]
        public ServiceOfferingChargeType? ChargeTypeRfi { get; internal set; }

        /// <summary>
        /// Defines how a top incident must be charged: as a Fixed Price or in Time and Materials.
        /// </summary>
        [JsonProperty("chargeTypeTop")]
        public ServiceOfferingChargeType? ChargeTypeTop { get; internal set; }

        /// <summary>
        /// The continuity measures for the service offering.
        /// </summary>
        [JsonProperty("continuity")]
        public string? Continuity { get; internal set; }

        [JsonProperty("continuityAttachments")]
        internal NodeCollection<Attachment>? ContinuityAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Continuity field.
        /// </summary>
        public DataList<Attachment>? ContinuityAttachments
        {
            get => ContinuityAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The effort class that is selected by default, when someone registers time on a request with an active affected SLA based on the service offering.
        /// </summary>
        [JsonProperty("defaultEffortClass")]
        public EffortClass? DefaultEffortClass { get; internal set; }

        [JsonProperty("effortClasses")]
        internal NodeCollection<EffortClass>? EffortClassesCollection { get; set; }

        /// <summary>
        /// Effort classes of the service offering.
        /// </summary>
        public DataList<EffortClass>? EffortClasses
        {
            get => EffortClassesCollection?.Data;
        }

        [JsonProperty("effortClassRates")]
        internal NodeCollection<EffortClassRate>? EffortClassRatesCollection { get; set; }

        /// <summary>
        /// Effort class rates of the service offering.
        /// </summary>
        public DataList<EffortClassRate>? EffortClassRates
        {
            get => EffortClassRatesCollection?.Data;
        }

        /// <summary>
        /// The limitations that apply to the service level agreements that are based on the service offering.
        /// </summary>
        [JsonProperty("limitations")]
        public string? Limitations { get; internal set; }

        [JsonProperty("limitationsAttachments")]
        internal NodeCollection<Attachment>? LimitationsAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Limitations field.
        /// </summary>
        public DataList<Attachment>? LimitationsAttachments
        {
            get => LimitationsAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The name of the service offering.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// Used to specify what the penalties will be for the service provider organization if a service level target has been breached.
        /// </summary>
        [JsonProperty("penalties")]
        public string? Penalties { get; internal set; }

        [JsonProperty("penaltiesAttachments")]
        internal NodeCollection<Attachment>? PenaltiesAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Penalties field.
        /// </summary>
        public DataList<Attachment>? PenaltiesAttachments
        {
            get => PenaltiesAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Used to describe the transaction(s) and the maximum time these transaction(s) can take to complete.
        /// </summary>
        [JsonProperty("performance")]
        public string? Performance { get; internal set; }

        [JsonProperty("performanceAttachments")]
        internal NodeCollection<Attachment>? PerformanceAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Performance field.
        /// </summary>
        public DataList<Attachment>? PerformanceAttachments
        {
            get => PerformanceAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Used to specify which requirements need to be met by the customer in order for the customer to be able to benefit from the service. The service provider cannot be held accountable for breaches of the service level targets caused by a failure of the customer to meet one or more of these prerequisites.
        /// </summary>
        [JsonProperty("prerequisites")]
        public string? Prerequisites { get; internal set; }

        [JsonProperty("prerequisitesAttachments")]
        internal NodeCollection<Attachment>? PrerequisitesAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Prerequisites field.
        /// </summary>
        public DataList<Attachment>? PrerequisitesAttachments
        {
            get => PrerequisitesAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Defines the fixed price rate for a Case.
        /// </summary>
        [JsonProperty("rateCase")]
        public decimal? RateCase { get; internal set; }

        /// <summary>
        /// <br>Defines the currency for the fixed price rate of a Case.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("rateCaseCurrency")]
        public string? RateCaseCurrency { get; internal set; }

        /// <summary>
        /// Defines the fixed price rate for a high incident.
        /// </summary>
        [JsonProperty("rateHigh")]
        public decimal? RateHigh { get; internal set; }

        /// <summary>
        /// <br>Defines the currency for the fixed price rate of a high incident.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("rateHighCurrency")]
        public string? RateHighCurrency { get; internal set; }

        /// <summary>
        /// Defines the fixed price rate for a low incident.
        /// </summary>
        [JsonProperty("rateLow")]
        public decimal? RateLow { get; internal set; }

        /// <summary>
        /// <br>Defines the currency for the fixed price rate of a low incident.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("rateLowCurrency")]
        public string? RateLowCurrency { get; internal set; }

        /// <summary>
        /// Defines the fixed price rate for a medium incident.
        /// </summary>
        [JsonProperty("rateMedium")]
        public decimal? RateMedium { get; internal set; }

        /// <summary>
        /// <br>Defines the currency for the fixed price rate of a medium incident.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("rateMediumCurrency")]
        public string? RateMediumCurrency { get; internal set; }

        /// <summary>
        /// Defines the fixed price rate for a RFC.
        /// </summary>
        [JsonProperty("rateRfc")]
        public decimal? RateRfc { get; internal set; }

        /// <summary>
        /// <br>Defines the currency for the fixed price rate of a RFC.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("rateRfcCurrency")]
        public string? RateRfcCurrency { get; internal set; }

        /// <summary>
        /// Defines the fixed price rate for a RFI.
        /// </summary>
        [JsonProperty("rateRfi")]
        public decimal? RateRfi { get; internal set; }

        /// <summary>
        /// <br>Defines the currency for the fixed price rate of a RFI.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("rateRfiCurrency")]
        public string? RateRfiCurrency { get; internal set; }

        /// <summary>
        /// Defines the fixed price rate for a top incident.
        /// </summary>
        [JsonProperty("rateTop")]
        public decimal? RateTop { get; internal set; }

        /// <summary>
        /// <br>Defines the currency for the fixed price rate of a top incident.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("rateTopCurrency")]
        public string? RateTopCurrency { get; internal set; }

        /// <summary>
        /// The Recovery Point Objective (RPO) is the maximum targeted duration in minutes in which data (transactions) might be lost from an IT service due to a major incident.
        /// </summary>
        [JsonProperty("recoveryPointObjective")]
        public long? RecoveryPointObjective { get; internal set; }

        /// <summary>
        /// The Recovery Time Objective (RTO) is the maximum targeted duration in minutes in which a business process must be restored after a disaster (or disruption) in order to avoid unacceptable consequences associated with a break in business continuity.
        /// </summary>
        [JsonProperty("recoveryTimeObjective")]
        public long? RecoveryTimeObjective { get; internal set; }

        /// <summary>
        /// Used to specify the maximum number of times per month that the service may become unavailable to customers with an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("reliability")]
        public string? Reliability { get; internal set; }

        /// <summary>
        /// Used to specify how often the representative of a customer of an active SLA that is based on the service offering will receive a report comparing the service level targets specified in the service offering with the actual level of service provided.
        /// </summary>
        [JsonProperty("reportFrequency")]
        public ServiceOfferingReportFrequency? ReportFrequency { get; internal set; }

        /// <summary>
        /// The minimum percentage of incidents that is to be resolved before their resolution target.
        /// </summary>
        [JsonProperty("resolutionsWithinTarget")]
        public long? ResolutionsWithinTarget { get; internal set; }

        /// <summary>
        /// The number of minutes within which a request with the category "Case" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetCase")]
        public long? ResolutionTargetCase { get; internal set; }

        /// <summary>
        /// The number of business days within which a request with the category "Case" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetCaseInDays")]
        public long? ResolutionTargetCaseInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a request with the impact value "High - Service Degraded for Several Users" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetHigh")]
        public long? ResolutionTargetHigh { get; internal set; }

        /// <summary>
        /// The number of business days within which a request with the impact value "High - Service Degraded for Several Users" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetHighInDays")]
        public long? ResolutionTargetHighInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a request with the impact value "Low - Service Degraded for One User" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetLow")]
        public long? ResolutionTargetLow { get; internal set; }

        /// <summary>
        /// The number of business days within which a request with the impact value "Low - Service Degraded for One User" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetLowInDays")]
        public long? ResolutionTargetLowInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a request with the impact value "Medium - Service Down for One User" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetMedium")]
        public long? ResolutionTargetMedium { get; internal set; }

        /// <summary>
        /// The number of business days within which a request with the impact value "Medium - Service Down for One User" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetMediumInDays")]
        public long? ResolutionTargetMediumInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a request with the category "RFC - Request for Change" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetRfc")]
        public long? ResolutionTargetRfc { get; internal set; }

        /// <summary>
        /// The number of business days within which a request with the category "RFC - Request for Change" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetRfcInDays")]
        public long? ResolutionTargetRfcInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a request with the category "RFI - Request for Information" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetRfi")]
        public long? ResolutionTargetRfi { get; internal set; }

        /// <summary>
        /// The number of business days within which a request with the category "RFI - Request for Information" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetRfiInDays")]
        public long? ResolutionTargetRfiInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a request with the impact value "Top - Service Down for Several Users" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetTop")]
        public long? ResolutionTargetTop { get; internal set; }

        /// <summary>
        /// The number of business days within which a request with the impact value "Top - Service Down for Several Users" is to be resolved when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("resolutionTargetTopInDays")]
        public long? ResolutionTargetTopInDays { get; internal set; }

        /// <summary>
        /// The minimum percentage of incidents that is to be responded to before their response target.
        /// </summary>
        [JsonProperty("responsesWithinTarget")]
        public long? ResponsesWithinTarget { get; internal set; }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the category "Case" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetCase")]
        public long? ResponseTargetCase { get; internal set; }

        /// <summary>
        /// The number of business days within which a response needs to have been provided for a request with the category "Case" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetCaseInDays")]
        public long? ResponseTargetCaseInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetHigh")]
        public long? ResponseTargetHigh { get; internal set; }

        /// <summary>
        /// The number of business days within which a response needs to have been provided for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetHighInDays")]
        public long? ResponseTargetHighInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetLow")]
        public long? ResponseTargetLow { get; internal set; }

        /// <summary>
        /// The number of business days within which a response needs to have been provided for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetLowInDays")]
        public long? ResponseTargetLowInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetMedium")]
        public long? ResponseTargetMedium { get; internal set; }

        /// <summary>
        /// The number of business days within which a response needs to have been provided for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetMediumInDays")]
        public long? ResponseTargetMediumInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the category "RFC - Request for Change" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetRfc")]
        public long? ResponseTargetRfc { get; internal set; }

        /// <summary>
        /// The number of business days within which a response needs to have been provided for a request with the category "RFC - Request for Change" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetRfcInDays")]
        public long? ResponseTargetRfcInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the category "RFI - Request for Information" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetRfi")]
        public long? ResponseTargetRfi { get; internal set; }

        /// <summary>
        /// The number of business days within which a response needs to have been provided for a request with the category "RFI - Request for Information" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetRfiInDays")]
        public long? ResponseTargetRfiInDays { get; internal set; }

        /// <summary>
        /// The number of minutes within which a response needs to have been provided for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetTop")]
        public long? ResponseTargetTop { get; internal set; }

        /// <summary>
        /// The number of business days within which a response needs to have been provided for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("responseTargetTopInDays")]
        public long? ResponseTargetTopInDays { get; internal set; }

        /// <summary>
        /// How often an active SLA that is based on the service offering will be reviewed with the representative of its customer.
        /// </summary>
        [JsonProperty("reviewFrequency")]
        public ServiceOfferingReviewFrequency? ReviewFrequency { get; internal set; }

        /// <summary>
        /// The service for which the service offering is being prepared.
        /// </summary>
        [JsonProperty("service"), Sdk4meField(true)]
        public Service? Service { get; internal set; }

        /// <summary>
        /// Calendar that defines the hours during which the service is supposed to be available.
        /// </summary>
        [JsonProperty("serviceHours")]
        public Calendar? ServiceHours { get; internal set; }

        [JsonProperty("serviceLevelAgreements")]
        internal NodeCollection<ServiceLevelAgreement>? ServiceLevelAgreementsCollection { get; set; }

        /// <summary>
        /// Service level agreements of the service offering.
        /// </summary>
        public DataList<ServiceLevelAgreement>? ServiceLevelAgreements
        {
            get => ServiceLevelAgreementsCollection?.Data;
        }

        [JsonProperty("shopArticles")]
        internal NodeCollection<ShopArticle>? ShopArticlesCollection { get; set; }

        /// <summary>
        /// Shop articles related to the service offering.
        /// </summary>
        public DataList<ShopArticle>? ShopArticles
        {
            get => ShopArticlesCollection?.Data;
        }

        /// <summary>
        /// The SLA notification scheme for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("slaNotificationSchemeHigh")]
        public SlaNotificationScheme? SlaNotificationSchemeHigh { get; internal set; }

        /// <summary>
        /// The SLA notification scheme for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("slaNotificationSchemeLow")]
        public SlaNotificationScheme? SlaNotificationSchemeLow { get; internal set; }

        /// <summary>
        /// The SLA notification scheme for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("slaNotificationSchemeMedium")]
        public SlaNotificationScheme? SlaNotificationSchemeMedium { get; internal set; }

        /// <summary>
        /// The SLA notification scheme for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("slaNotificationSchemeTop")]
        public SlaNotificationScheme? SlaNotificationSchemeTop { get; internal set; }

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

        [JsonProperty("standardServiceRequests")]
        internal NodeCollection<StandardServiceRequest>? StandardServiceRequestsCollection { get; set; }

        /// <summary>
        /// Standard service requests of the service offering.
        /// </summary>
        public DataList<StandardServiceRequest>? StandardServiceRequests
        {
            get => StandardServiceRequestsCollection?.Data;
        }

        /// <summary>
        /// The current status of the service offering.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public ServiceOfferingStatus? Status { get; internal set; }

        /// <summary>
        /// A high-level description of the differentiators between this service offering and other service offerings that have already been, or could be, prepared for the same service.
        /// </summary>
        [JsonProperty("summary")]
        public string? Summary { get; internal set; }

        [JsonProperty("summaryAttachments")]
        internal NodeCollection<Attachment>? SummaryAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Summary field.
        /// </summary>
        public DataList<Attachment>? SummaryAttachments
        {
            get => SummaryAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The calendar that defines the support hours for a request with the category "Case" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHoursCase")]
        public Calendar? SupportHoursCase { get; internal set; }

        /// <summary>
        /// The calendar that defines the support hours for a request with the impact "High - Service Degraded for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHoursHigh")]
        public Calendar? SupportHoursHigh { get; internal set; }

        /// <summary>
        /// The calendar that defines the support hours for a request with the impact "Low - Service Degraded for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHoursLow")]
        public Calendar? SupportHoursLow { get; internal set; }

        /// <summary>
        /// The calendar that defines the support hours for a request with the impact "Medium - Service Down for One User" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHoursMedium")]
        public Calendar? SupportHoursMedium { get; internal set; }

        /// <summary>
        /// The calendar that defines the support hours for a request with the category "RFC - Request for Change" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHoursRfc")]
        public Calendar? SupportHoursRfc { get; internal set; }

        /// <summary>
        /// The calendar that defines the support hours for a request with the category "RFI - Request for Information" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHoursRfi")]
        public Calendar? SupportHoursRfi { get; internal set; }

        /// <summary>
        /// The calendar that defines the support hours for a request with the impact "Top - Service Down for Several Users" when it affects an active SLA that is based on the service offering.
        /// </summary>
        [JsonProperty("supportHoursTop")]
        public Calendar? SupportHoursTop { get; internal set; }

        /// <summary>
        /// Used to describe the length of notice required for changing or terminating the service level agreement.
        /// </summary>
        [JsonProperty("termination")]
        public string? Termination { get; internal set; }

        [JsonProperty("terminationAttachments")]
        internal NodeCollection<Attachment>? TerminationAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Termination field.
        /// </summary>
        public DataList<Attachment>? TerminationAttachments
        {
            get => TerminationAttachmentsCollection?.Data;
        }

        /// <summary>
        /// <br>The time zone that applies to the selected service hours.</br>
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
        /// The waiting for customer follow-up for a request when it remains in status waiting for customer and has an active SLA that is based on this service offering. Only enabled waiting for customer follow-ups that are linked to the same account as the service offering can be selected.
        /// </summary>
        [JsonProperty("waitingForCustomerFollowUp")]
        public WaitingForCustomerFollowUp? WaitingForCustomerFollowUp { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(ChargesAttachmentsCollection?.GetQueryPageInfo("chargesAttachments", depth + 1));
            retval.AddRange(ContinuityAttachmentsCollection?.GetQueryPageInfo("continuityAttachments", depth + 1));
            retval.AddRange(EffortClassesCollection?.GetQueryPageInfo("effortClasses", depth + 1));
            retval.AddRange(EffortClassRatesCollection?.GetQueryPageInfo("effortClassRates", depth + 1));
            retval.AddRange(LimitationsAttachmentsCollection?.GetQueryPageInfo("limitationsAttachments", depth + 1));
            retval.AddRange(PenaltiesAttachmentsCollection?.GetQueryPageInfo("penaltiesAttachments", depth + 1));
            retval.AddRange(PerformanceAttachmentsCollection?.GetQueryPageInfo("performanceAttachments", depth + 1));
            retval.AddRange(PrerequisitesAttachmentsCollection?.GetQueryPageInfo("prerequisitesAttachments", depth + 1));
            retval.AddRange(ServiceLevelAgreementsCollection?.GetQueryPageInfo("serviceLevelAgreements", depth + 1));
            retval.AddRange(ShopArticlesCollection?.GetQueryPageInfo("shopArticles", depth + 1));
            retval.AddRange(StandardServiceRequestsCollection?.GetQueryPageInfo("standardServiceRequests", depth + 1));
            retval.AddRange(SummaryAttachmentsCollection?.GetQueryPageInfo("summaryAttachments", depth + 1));
            retval.AddRange(TerminationAttachmentsCollection?.GetQueryPageInfo("terminationAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            ChargesAttachments?.AddRange((data as ServiceOffering)?.ChargesAttachments);
            ContinuityAttachments?.AddRange((data as ServiceOffering)?.ContinuityAttachments);
            EffortClasses?.AddRange((data as ServiceOffering)?.EffortClasses);
            EffortClassRates?.AddRange((data as ServiceOffering)?.EffortClassRates);
            LimitationsAttachments?.AddRange((data as ServiceOffering)?.LimitationsAttachments);
            PenaltiesAttachments?.AddRange((data as ServiceOffering)?.PenaltiesAttachments);
            PerformanceAttachments?.AddRange((data as ServiceOffering)?.PerformanceAttachments);
            PrerequisitesAttachments?.AddRange((data as ServiceOffering)?.PrerequisitesAttachments);
            ServiceLevelAgreements?.AddRange((data as ServiceOffering)?.ServiceLevelAgreements);
            ShopArticles?.AddRange((data as ServiceOffering)?.ShopArticles);
            StandardServiceRequests?.AddRange((data as ServiceOffering)?.StandardServiceRequests);
            SummaryAttachments?.AddRange((data as ServiceOffering)?.SummaryAttachments);
            TerminationAttachments?.AddRange((data as ServiceOffering)?.TerminationAttachments);
        }
    }
}
