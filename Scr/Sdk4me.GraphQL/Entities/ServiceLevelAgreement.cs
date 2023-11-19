namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/servicelevelagreement/">ServiceLevelAgreement</see> object.
    /// </summary>
    public class ServiceLevelAgreement : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider. This contains the activityIDs related to request categories.
        /// </summary>
        [JsonProperty("activityID")]
        public ActivityID? ActivityID { get; internal set; }

        /// <summary>
        /// The Agreement ID is the unique identifier by which all the activities that are performed through the coverage of the SLA are known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("agreementID")]
        public string? AgreementID { get; internal set; }

        /// <summary>
        /// Used to specify how people who are to be covered by the service level agreement are to be selected.
        /// </summary>
        [JsonProperty("coverage")]
        public SlaCoverage? Coverage { get; internal set; }

        [JsonProperty("coverageGroups")]
        internal NodeCollection<SlaCoverageGroup>? CoverageGroupsCollection { get; set; }

        /// <summary>
        /// Coverage groups of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>coverage_groups</c>.
        /// </summary>
        public DataList<SlaCoverageGroup>? CoverageGroups
        {
            get => CoverageGroupsCollection?.Data;
        }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The organization that pays for the agreement.
        /// </summary>
        [JsonProperty("customer")]
        public Organization? Customer { get; internal set; }

        /// <summary>
        /// The customer account this record belongs to.
        /// </summary>
        [JsonProperty("customerAccount")]
        public Account? CustomerAccount { get; internal set; }

        [JsonProperty("customerRepresentatives")]
        internal NodeCollection<Person>? CustomerRepresentativesCollection { get; set; }

        /// <summary>
        /// The people who represent the customer organization for the service level agreement.
        /// </summary>
        public DataList<Person>? CustomerRepresentatives
        {
            get => CustomerRepresentativesCollection?.Data;
        }

        [JsonProperty("effortClassRateIDs")]
        internal NodeCollection<EffortClassRateID>? EffortClassRateIDsCollection { get; set; }

        /// <summary>
        /// The Rate IDs are the unique identifiers by which an effort class that is linked to a time entry when an activity was performed through the coverage of the SLA is known in the billing system of the service provider.
        /// </summary>
        public DataList<EffortClassRateID>? EffortClassRateIDs
        {
            get => EffortClassRateIDsCollection?.Data;
        }

        /// <summary>
        /// The date through which the agreement will be active. The agreement expires at the end of this day if it is not renewed before then. When the agreement has expired, its status will automatically be set to <c>expired</c>.
        /// </summary>
        [JsonProperty("expiryDate")]
        public DateOnly? ExpiryDate { get; internal set; }

        [JsonProperty("invoices")]
        internal NodeCollection<Invoice>? InvoicesCollection { get; set; }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        public DataList<Invoice>? Invoices
        {
            get => InvoicesCollection?.Data;
        }

        /// <summary>
        /// The name of the service level agreement.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The last day on which the service provider organization can still be contacted to terminate the agreement to ensure that it expires on the intended expiry date. The notice date field is left empty, and the expiry date field is filled out, when the agreement is to expire on a specific date and no notice needs to be given to terminate it.
        /// </summary>
        [JsonProperty("noticeDate")]
        public DateOnly? NoticeDate { get; internal set; }

        [JsonProperty("organizations")]
        internal NodeCollection<Organization>? OrganizationsCollection { get; set; }

        /// <summary>
        /// Organizations of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>organizations_and_descendants</c>, <c>organizations</c> or <c>organizations_and_sites</c>.
        /// </summary>
        public DataList<Organization>? Organizations
        {
            get => OrganizationsCollection?.Data;
        }

        [JsonProperty("people")]
        internal NodeCollection<Person>? PeopleCollection { get; set; }

        /// <summary>
        /// People of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>people</c>.
        /// </summary>
        public DataList<Person>? People
        {
            get => PeopleCollection?.Data;
        }

        /// <summary>
        /// Any additional information about the service level agreement that might prove useful.
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
        /// The service instance that will be used to provide the service to the customer of the service level agreement. Only service instances that are linked to the same service as the selected service offering can be selected.
        /// </summary>
        [JsonProperty("serviceInstance")]
        public ServiceInstance? ServiceInstance { get; internal set; }

        [JsonProperty("serviceInstances")]
        internal NodeCollection<ParentServiceInstance>? ServiceInstancesCollection { get; set; }

        /// <summary>
        /// The service instances that consume the service instance for which the service level agreement is registered. Only available for service level agreements where the <c>coverage</c> field is set to <c>service_instances</c>.
        /// </summary>
        public DataList<ParentServiceInstance>? ServiceInstances
        {
            get => ServiceInstancesCollection?.Data;
        }

        /// <summary>
        /// The person of the service provider organization who acts as the service level manager for the customer of the service level agreement.
        /// </summary>
        [JsonProperty("serviceLevelManager")]
        public Person? ServiceLevelManager { get; internal set; }

        /// <summary>
        /// Service offering that specifies the conditions that apply to the service level agreement.
        /// </summary>
        [JsonProperty("serviceOffering"), Sdk4meField(true)]
        public ServiceOffering? ServiceOffering { get; internal set; }

        [JsonProperty("sites")]
        internal NodeCollection<Site>? SitesCollection { get; set; }

        /// <summary>
        /// Sites of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>sites</c> or <c>organizations_and_sites</c>.
        /// </summary>
        public DataList<Site>? Sites
        {
            get => SitesCollection?.Data;
        }

        [JsonProperty("skillPools")]
        internal NodeCollection<SkillPool>? SkillPoolsCollection { get; set; }

        /// <summary>
        /// Skill pools of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>skill_pools</c>.
        /// </summary>
        public DataList<SkillPool>? SkillPools
        {
            get => SkillPoolsCollection?.Data;
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

        [JsonProperty("standardServiceRequestActivityIDs")]
        internal NodeCollection<StandardServiceRequestActivityID>? StandardServiceRequestActivityIDsCollection { get; set; }

        /// <summary>
        /// Represents the activityIDs for standard service requests. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        public DataList<StandardServiceRequestActivityID>? StandardServiceRequestActivityIDs
        {
            get => StandardServiceRequestActivityIDsCollection?.Data;
        }

        /// <summary>
        /// The first day during which the agreement is active.
        /// </summary>
        [JsonProperty("startDate")]
        public DateOnly? StartDate { get; internal set; }

        /// <summary>
        /// The current status of the agreement.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public AgreementStatus? Status { get; internal set; }

        /// <summary>
        /// The support domain account that offers the support to users covered by this the service level agreement.
        /// </summary>
        [JsonProperty("supportDomain")]
        public Account? SupportDomain { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Whether knowledge articles from the service provider should be exposed to the people covered by the service instances related to the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>service_instances</c>.
        /// </summary>
        [JsonProperty("useKnowledgeFromServiceProvider")]
        public bool? UseKnowledgeFromServiceProvider { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(CoverageGroupsCollection?.GetQueryPageInfo("coverageGroups", depth + 1));
            retval.AddRange(CustomerRepresentativesCollection?.GetQueryPageInfo("customerRepresentatives", depth + 1));
            retval.AddRange(EffortClassRateIDsCollection?.GetQueryPageInfo("effortClassRateIDs", depth + 1));
            retval.AddRange(InvoicesCollection?.GetQueryPageInfo("invoices", depth + 1));
            retval.AddRange(OrganizationsCollection?.GetQueryPageInfo("organizations", depth + 1));
            retval.AddRange(PeopleCollection?.GetQueryPageInfo("people", depth + 1));
            retval.AddRange(RemarksAttachmentsCollection?.GetQueryPageInfo("remarksAttachments", depth + 1));
            retval.AddRange(ServiceInstancesCollection?.GetQueryPageInfo("serviceInstances", depth + 1));
            retval.AddRange(SitesCollection?.GetQueryPageInfo("sites", depth + 1));
            retval.AddRange(SkillPoolsCollection?.GetQueryPageInfo("skillPools", depth + 1));
            retval.AddRange(StandardServiceRequestActivityIDsCollection?.GetQueryPageInfo("standardServiceRequestActivityIDs", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            CoverageGroups?.AddRange((data as ServiceLevelAgreement)?.CoverageGroups);
            CustomerRepresentatives?.AddRange((data as ServiceLevelAgreement)?.CustomerRepresentatives);
            EffortClassRateIDs?.AddRange((data as ServiceLevelAgreement)?.EffortClassRateIDs);
            Invoices?.AddRange((data as ServiceLevelAgreement)?.Invoices);
            Organizations?.AddRange((data as ServiceLevelAgreement)?.Organizations);
            People?.AddRange((data as ServiceLevelAgreement)?.People);
            RemarksAttachments?.AddRange((data as ServiceLevelAgreement)?.RemarksAttachments);
            ServiceInstances?.AddRange((data as ServiceLevelAgreement)?.ServiceInstances);
            Sites?.AddRange((data as ServiceLevelAgreement)?.Sites);
            SkillPools?.AddRange((data as ServiceLevelAgreement)?.SkillPools);
            StandardServiceRequestActivityIDs?.AddRange((data as ServiceLevelAgreement)?.StandardServiceRequestActivityIDs);
        }
    }
}
