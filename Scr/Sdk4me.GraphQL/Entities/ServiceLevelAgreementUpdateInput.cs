using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/servicelevelagreementupdateinput/">ServiceLevelAgreementUpdateInput</see> object.
    /// </summary>
    public class ServiceLevelAgreementUpdateInput : PropertyChangeSet
    {
        private ActivityIDInput? activityID;
        private string? agreementID;
        private string? clientMutationId;
        private SlaCoverage? coverage;
        private string? customerId;
        private List<string>? customerRepresentativeIds;
        private List<string>? effortClassRateIDsToDelete;
#if NET6_0_OR_GREATER
        private DateOnly? expiryDate;
#else
        private DateTime? expiryDate;
#endif
        private string id;
        private string? name;
        private List<EffortClassRateIDInput>? newEffortClassRateIDs;
        private List<StandardServiceRequestActivityIDInput>? newStandardServiceRequestActivityIDs;
#if NET6_0_OR_GREATER
        private DateOnly? noticeDate;
#else
        private DateTime? noticeDate;
#endif
        private List<string>? organizationIds;
        private List<string>? personIds;
        private string? remarks;
        private List<AttachmentInput>? remarksAttachments;
        private string? serviceInstanceId;
        private string? serviceLevelManagerId;
        private string? serviceOfferingId;
        private List<string>? siteIds;
        private List<string>? skillPoolIds;
        private string? source;
        private string? sourceID;
        private List<string>? standardServiceRequestActivityIDsToDelete;
#if NET6_0_OR_GREATER
        private DateOnly? startDate;
#else
        private DateTime? startDate;
#endif
        private AgreementStatus? status;
        private bool? useKnowledgeFromServiceProvider;

        /// <summary>
        /// The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider. This contains the activityIDs related to request categories.
        /// </summary>
        [JsonProperty("activityID")]
        public ActivityIDInput? ActivityID
        {
            get => activityID;
            set => activityID = Set("activityID", value);
        }

        /// <summary>
        /// The Agreement ID is the unique identifier by which all the activities that are performed through the coverage of the SLA are known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("agreementID")]
        public string? AgreementID
        {
            get => agreementID;
            set => agreementID = Set("agreementID", value);
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
        /// Used to specify how people who are to be covered by the service level agreement are to be selected.
        /// </summary>
        [JsonProperty("coverage")]
        public SlaCoverage? Coverage
        {
            get => coverage;
            set => coverage = Set("coverage", value);
        }

        /// <summary>
        /// Identifier of the organization that pays for the service level agreement.
        /// </summary>
        [JsonProperty("customerId")]
        public string? CustomerId
        {
            get => customerId;
            set => customerId = Set("customerId", value);
        }

        /// <summary>
        /// Identifiers of the people who represents the customer organization for the service level agreement.
        /// </summary>
        [JsonProperty("customerRepresentativeIds")]
        public List<string>? CustomerRepresentativeIds
        {
            get => customerRepresentativeIds;
            set => customerRepresentativeIds = Set("customerRepresentativeIds", value);
        }

        /// <summary>
        /// Identifiers of effort class rateIDs to remove from the SLA.
        /// </summary>
        [JsonProperty("effortClassRateIDsToDelete")]
        public List<string>? EffortClassRateIDsToDelete
        {
            get => effortClassRateIDsToDelete;
            set => effortClassRateIDsToDelete = Set("effortClassRateIDsToDelete", value);
        }

        /// <summary>
        /// The date through which the service level agreement (SLA) will be active. The SLA expires at the end of this day if it is not renewed before then. When the SLA has expired, its status will automatically be set to "Expired".
        /// </summary>
        [JsonProperty("expiryDate")]
#if NET6_0_OR_GREATER
        public DateOnly? ExpiryDate
#else
        public DateTime? ExpiryDate
#endif
        {
            get => expiryDate;
            set => expiryDate = Set("expiryDate", value);
        }

        /// <summary>
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id"), Sdk4meField(IsRequiredForMutation = true)]
        public string ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// The name of the service level agreement.
        /// </summary>
        [JsonProperty("name")]
        public string? Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The Rate IDs are the unique identifiers by which an effort class that is linked to a time entry when an activity was performed through the coverage of the SLA is known in the billing system of the service provider.
        /// </summary>
        [JsonProperty("newEffortClassRateIDs")]
        public List<EffortClassRateIDInput>? NewEffortClassRateIDs
        {
            get => newEffortClassRateIDs;
            set => newEffortClassRateIDs = Set("newEffortClassRateIDs", value);
        }

        /// <summary>
        /// Represents the activityIDs for standard service requests. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider
        /// </summary>
        [JsonProperty("newStandardServiceRequestActivityIDs")]
        public List<StandardServiceRequestActivityIDInput>? NewStandardServiceRequestActivityIDs
        {
            get => newStandardServiceRequestActivityIDs;
            set => newStandardServiceRequestActivityIDs = Set("newStandardServiceRequestActivityIDs", value);
        }

        /// <summary>
        /// The last day on which the service provider organization can still be contacted to terminate the service level agreement (SLA) to ensure that it expires on the intended expiry date. The Notice date field is left empty, and the Expiry date field is filled out, when the SLA is to expire on a specific date and no notice needs to be given to terminate it.
        /// </summary>
        [JsonProperty("noticeDate")]
#if NET6_0_OR_GREATER
        public DateOnly? NoticeDate
#else
        public DateTime? NoticeDate
#endif
        {
            get => noticeDate;
            set => noticeDate = Set("noticeDate", value);
        }

        /// <summary>
        /// Identifiers of the organizations of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>organizations_and_descendants</c>, <c>organizations</c> or <c>organizations_and_sites</c>.
        /// </summary>
        [JsonProperty("organizationIds")]
        public List<string>? OrganizationIds
        {
            get => organizationIds;
            set => organizationIds = Set("organizationIds", value);
        }

        /// <summary>
        /// Identifiers of the people of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>people</c>.
        /// </summary>
        [JsonProperty("personIds")]
        public List<string>? PersonIds
        {
            get => personIds;
            set => personIds = Set("personIds", value);
        }

        /// <summary>
        /// Any additional information about the service level agreement that might prove useful.
        /// </summary>
        [JsonProperty("remarks")]
        public string? Remarks
        {
            get => remarks;
            set => remarks = Set("remarks", value);
        }

        /// <summary>
        /// The attachments used in the <c>remarks</c> field.
        /// </summary>
        [JsonProperty("remarksAttachments")]
        public List<AttachmentInput>? RemarksAttachments
        {
            get => remarksAttachments;
            set => remarksAttachments = Set("remarksAttachments", value);
        }

        /// <summary>
        /// Identifier of the service instance that will be used to provide the service to the customer of the service level agreement. Only service instances that are linked to the same service as the selected service offering can be selected.
        /// </summary>
        [JsonProperty("serviceInstanceId")]
        public string? ServiceInstanceId
        {
            get => serviceInstanceId;
            set => serviceInstanceId = Set("serviceInstanceId", value);
        }

        /// <summary>
        /// Identifier of the person of the service provider organization who acts as the service level manager for the customer of the service level agreement.
        /// </summary>
        [JsonProperty("serviceLevelManagerId")]
        public string? ServiceLevelManagerId
        {
            get => serviceLevelManagerId;
            set => serviceLevelManagerId = Set("serviceLevelManagerId", value);
        }

        /// <summary>
        /// Identifier of the service offering that specifies the conditions that apply to the service level agreement.
        /// </summary>
        [JsonProperty("serviceOfferingId")]
        public string? ServiceOfferingId
        {
            get => serviceOfferingId;
            set => serviceOfferingId = Set("serviceOfferingId", value);
        }

        /// <summary>
        /// Identifiers of the sites of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>sites</c> or <c>organizations_and_sites</c>.
        /// </summary>
        [JsonProperty("siteIds")]
        public List<string>? SiteIds
        {
            get => siteIds;
            set => siteIds = Set("siteIds", value);
        }

        /// <summary>
        /// Identifiers of the skill pools of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>skill_pools</c>.
        /// </summary>
        [JsonProperty("skillPoolIds")]
        public List<string>? SkillPoolIds
        {
            get => skillPoolIds;
            set => skillPoolIds = Set("skillPoolIds", value);
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
        /// Identifiers of effort class rateIDs to remove from the SLA.
        /// </summary>
        [JsonProperty("standardServiceRequestActivityIDsToDelete")]
        public List<string>? StandardServiceRequestActivityIDsToDelete
        {
            get => standardServiceRequestActivityIDsToDelete;
            set => standardServiceRequestActivityIDsToDelete = Set("standardServiceRequestActivityIDsToDelete", value);
        }

        /// <summary>
        /// The first day during which the service level agreement (SLA) is active.
        /// </summary>
        [JsonProperty("startDate")]
#if NET6_0_OR_GREATER
        public DateOnly? StartDate
#else
        public DateTime? StartDate
#endif
        {
            get => startDate;
            set => startDate = Set("startDate", value);
        }

        /// <summary>
        /// The current status of the service level agreement (SLA).
        /// </summary>
        [JsonProperty("status")]
        public AgreementStatus? Status
        {
            get => status;
            set => status = Set("status", value);
        }

        /// <summary>
        /// Whether knowledge articles from the service provider should be exposed to the people covered by the service instances related to the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>service_instances</c>.
        /// </summary>
        [JsonProperty("useKnowledgeFromServiceProvider")]
        public bool? UseKnowledgeFromServiceProvider
        {
            get => useKnowledgeFromServiceProvider;
            set => useKnowledgeFromServiceProvider = Set("useKnowledgeFromServiceProvider", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLevelAgreementUpdateInput"/> class without providing the required values.
        /// </summary>
        public ServiceLevelAgreementUpdateInput()
        {
            id = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLevelAgreementUpdateInput"/> class.
        /// </summary>
        /// <param name="id">The node ID of the record to update.</param>
        public ServiceLevelAgreementUpdateInput(string id)
        {
            this.id = Set("id", id);
        }
    }
}
