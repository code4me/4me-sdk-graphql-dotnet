namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/serviceinstance/">ServiceInstance</see> object.
    /// </summary>
    public class ServiceInstance : Node, IHasTranslations
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        [JsonProperty("childServiceInstances")]
        internal NodeCollection<ServiceInstance>? ChildServiceInstancesCollection { get; set; }

        /// <summary>
        /// Children of the service instance.
        /// </summary>
        public DataList<ServiceInstance>? ChildServiceInstances
        {
            get => ChildServiceInstancesCollection?.Data;
        }

        [JsonProperty("configurationItems")]
        internal NodeCollection<ConfigurationItem>? ConfigurationItemsCollection { get; set; }

        /// <summary>
        /// Configuration items of the service instance.
        /// </summary>
        public DataList<ConfigurationItem>? ConfigurationItems
        {
            get => ConfigurationItemsCollection?.Data;
        }

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
        /// Used to select the team that will automatically be selected in the Team field of requests to which the service instance is linked after they have been submitted using Self Service or when they are generated using the Requests API, Mail API or Events API.
        /// </summary>
        [JsonProperty("firstLineTeam")]
        public Team? FirstLineTeam { get; internal set; }

        /// <summary>
        /// The maintenance window defines the periods in which workflow tasks with an impact related to this service instance may be implemented.
        /// </summary>
        [JsonProperty("maintenanceWindow")]
        public Calendar? MaintenanceWindow { get; internal set; }

        /// <summary>
        /// The name of the service instance.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        [JsonProperty("parentServiceInstances")]
        internal NodeCollection<ServiceInstance>? ParentServiceInstancesCollection { get; set; }

        /// <summary>
        /// Parents of the service instance.
        /// </summary>
        public DataList<ServiceInstance>? ParentServiceInstances
        {
            get => ParentServiceInstancesCollection?.Data;
        }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

        /// <summary>
        /// Any additional information about the service instance that might prove useful.
        /// </summary>
        [JsonProperty("remarks")]
        public string? Remarks { get; internal set; }

        [JsonProperty("remarksAttachments")]
        internal NodeCollection<Attachment>? RemarksAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public DataList<Attachment>? RemarksAttachments
        {
            get => RemarksAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The service which functionality the service instance provides.
        /// </summary>
        [JsonProperty("service"), Sdk4meField(true)]
        public Service? Service { get; internal set; }

        [JsonProperty("serviceLevelAgreements")]
        internal NodeCollection<ServiceLevelAgreement>? ServiceLevelAgreementsCollection { get; set; }

        /// <summary>
        /// Service level agreements of the service instance.
        /// </summary>
        public DataList<ServiceLevelAgreement>? ServiceLevelAgreements
        {
            get => ServiceLevelAgreementsCollection?.Data;
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
        /// The current status of the service instance.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public ServiceInstanceStatus? Status { get; internal set; }

        /// <summary>
        /// The team that will, by default, be selected in the Team field of a request when the service instance is manually selected in the Service instance field of the request, or when the service instance is applied from the Service Hierarchy Browser.
        /// </summary>
        [JsonProperty("supportTeam"), Sdk4meField(true)]
        public Team? SupportTeam { get; internal set; }

        /// <summary>
        /// <br>The time zone that applies to the selected maintenance window.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone { get; internal set; }

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
            retval.AddRange(ChildServiceInstancesCollection?.GetQueryPageInfo("childServiceInstances", depth + 1));
            retval.AddRange(ConfigurationItemsCollection?.GetQueryPageInfo("configurationItems", depth + 1));
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(ParentServiceInstancesCollection?.GetQueryPageInfo("parentServiceInstances", depth + 1));
            retval.AddRange(RemarksAttachmentsCollection?.GetQueryPageInfo("remarksAttachments", depth + 1));
            retval.AddRange(ServiceLevelAgreementsCollection?.GetQueryPageInfo("serviceLevelAgreements", depth + 1));
            retval.AddRange(TranslationsCollection?.GetQueryPageInfo("translations", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            ChildServiceInstances?.AddRange((data as ServiceInstance)?.ChildServiceInstances);
            ConfigurationItems?.AddRange((data as ServiceInstance)?.ConfigurationItems);
            CustomFieldsAttachments?.AddRange((data as ServiceInstance)?.CustomFieldsAttachments);
            ParentServiceInstances?.AddRange((data as ServiceInstance)?.ParentServiceInstances);
            RemarksAttachments?.AddRange((data as ServiceInstance)?.RemarksAttachments);
            ServiceLevelAgreements?.AddRange((data as ServiceInstance)?.ServiceLevelAgreements);
            Translations?.AddRange((data as ServiceInstance)?.Translations);
        }
    }
}
