namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/service/">Service</see> object.
    /// </summary>
    public class Service : Node, IHasTranslations
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The person who is responsible for ensuring that the availability targets specified in the active SLAs for the service are met.
        /// </summary>
        [JsonProperty("availabilityManager")]
        public Person? AvailabilityManager { get; internal set; }

        /// <summary>
        /// The person who is responsible for ensuring that the service is not affected by incidents that are caused by capacity shortages.
        /// </summary>
        [JsonProperty("capacityManager")]
        public Person? CapacityManager { get; internal set; }

        /// <summary>
        /// The person who is responsible for coordinating the changes of the service.
        /// </summary>
        [JsonProperty("changeManager")]
        public Person? ChangeManager { get; internal set; }

        /// <summary>
        /// The person who is responsible for creating and maintaining the continuity plans for the service's instances that have an active SLA with a continuity target.
        /// </summary>
        [JsonProperty("continuityManager")]
        public Person? ContinuityManager { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        [JsonProperty("customFields")]
        public CustomFieldCollection? CustomFields { get; internal set; }

        [JsonProperty("customFieldsAttachments")]
        internal NodeCollection<Attachment>? CustomFieldsAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public DataList<Attachment>? CustomFieldsAttachments
        {
            get => CustomFieldsAttachmentsCollection?.Data;
        }

        /// <summary>
        /// A high-level description of the service's core functionality.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; internal set; }

        [JsonProperty("descriptionAttachments")]
        internal NodeCollection<Attachment>? DescriptionAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        public DataList<Attachment>? DescriptionAttachments
        {
            get => DescriptionAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Whether the service may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The team that will, by default, be selected in the First line team field of a new service instance when it is being registered for the service.
        /// </summary>
        [JsonProperty("firstLineTeam")]
        public Team? FirstLineTeam { get; internal set; }

        /// <summary>
        /// A comma-separated list of words that can be used to find the service via search.
        /// </summary>
        [JsonProperty("keywords")]
        public string? Keywords { get; internal set; }

        /// <summary>
        /// The person who is responsible for the quality of the knowledge articles for the service.
        /// </summary>
        [JsonProperty("knowledgeManager")]
        public Person? KnowledgeManager { get; internal set; }

        /// <summary>
        /// The name of the service. The service name may be followed by the name of its core application placed between brackets.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

        /// <summary>
        /// The person who is responsible for coordinating the problems that directly affect the service.
        /// </summary>
        [JsonProperty("problemManager")]
        public Person? ProblemManager { get; internal set; }

        /// <summary>
        /// The person who is responsible for coordinating the releases of the service.
        /// </summary>
        [JsonProperty("releaseManager")]
        public Person? ReleaseManager { get; internal set; }

        [JsonProperty("serviceInstances")]
        internal NodeCollection<ServiceInstance>? ServiceInstancesCollection { get; set; }

        /// <summary>
        /// Service instances related to this service.
        /// </summary>
        public DataList<ServiceInstance>? ServiceInstances
        {
            get => ServiceInstancesCollection?.Data;
        }

        [JsonProperty("serviceLevelAgreements")]
        internal NodeCollection<ServiceLevelAgreement>? ServiceLevelAgreementsCollection { get; set; }

        /// <summary>
        /// Service level agreements related to this service through the service offering.
        /// </summary>
        public DataList<ServiceLevelAgreement>? ServiceLevelAgreements
        {
            get => ServiceLevelAgreementsCollection?.Data;
        }

        [JsonProperty("serviceOfferings")]
        internal NodeCollection<ServiceOffering>? ServiceOfferingsCollection { get; set; }

        /// <summary>
        /// Service offerings related to this service.
        /// </summary>
        public DataList<ServiceOffering>? ServiceOfferings
        {
            get => ServiceOfferingsCollection?.Data;
        }

        /// <summary>
        /// The person who is responsible for ensuring that the service level targets specified in the SLAs for the service are met.
        /// </summary>
        [JsonProperty("serviceOwner")]
        public Person? ServiceOwner { get; internal set; }

        /// <summary>
        /// The organization that provides the service.
        /// </summary>
        [JsonProperty("serviceProvider"), Sdk4meField(true)]
        public Organization? ServiceProvider { get; internal set; }

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
        /// The team  that will, by default, be selected in the Support team field of a service instance when one is registered for the service. Similarly, this team will be selected in the Team field of a problem when the service is related to it.
        /// </summary>
        [JsonProperty("supportTeam"), Sdk4meField(true)]
        public Team? SupportTeam { get; internal set; }

        /// <summary>
        /// Survey used to measure customer rating of this service.
        /// </summary>
        [JsonProperty("survey")]
        public Survey? Survey { get; internal set; }

        [JsonProperty("translations")]
        internal NodeCollection<Translation>? TranslationsCollection { get; set; }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public DataList<Translation>? Translations
        {
            get => TranslationsCollection?.Data;
        }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(DescriptionAttachmentsCollection?.GetQueryPageInfo("descriptionAttachments", depth + 1));
            retval.AddRange(ServiceInstancesCollection?.GetQueryPageInfo("serviceInstances", depth + 1));
            retval.AddRange(ServiceLevelAgreementsCollection?.GetQueryPageInfo("serviceLevelAgreements", depth + 1));
            retval.AddRange(ServiceOfferingsCollection?.GetQueryPageInfo("serviceOfferings", depth + 1));
            retval.AddRange(TranslationsCollection?.GetQueryPageInfo("translations", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            CustomFieldsAttachments?.AddRange((data as Service)?.CustomFieldsAttachments);
            DescriptionAttachments?.AddRange((data as Service)?.DescriptionAttachments);
            ServiceInstances?.AddRange((data as Service)?.ServiceInstances);
            ServiceLevelAgreements?.AddRange((data as Service)?.ServiceLevelAgreements);
            ServiceOfferings?.AddRange((data as Service)?.ServiceOfferings);
            Translations?.AddRange((data as Service)?.Translations);
        }
    }
}
