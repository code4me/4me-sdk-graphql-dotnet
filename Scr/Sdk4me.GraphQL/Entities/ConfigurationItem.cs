using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/configurationitem/">ConfigurationItem</see> object.
    /// </summary>
    public class ConfigurationItem : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Alternate names the configuration item is also known by.
        /// </summary>
        [JsonProperty("alternateNames")]
        public List<string>? AlternateNames { get; internal set; }

        /// <summary>
        /// Number under which the configuration item has been registered in the financial application (e.g. SAP).
        /// </summary>
        [JsonProperty("assetID"), Sdk4meField(true)]
        public string? AssetID { get; internal set; }

        [JsonProperty("ciRelations")]
        internal NodeCollection<ConfigurationItemRelation>? CiRelationsCollection { get; set; }

        /// <summary>
        /// Relations to other configuration items.
        /// </summary>
        public DataList<ConfigurationItemRelation>? CiRelations
        {
            get => CiRelationsCollection?.Data;
        }

        [JsonProperty("contracts")]
        internal NodeCollection<Contract>? ContractsCollection { get; set; }

        /// <summary>
        /// All contracts of this configuration item.
        /// </summary>
        public DataList<Contract>? Contracts
        {
            get => ContractsCollection?.Data;
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
        /// The date at which the support for this configuration item ends.
        /// </summary>
        [JsonProperty("endOfSupportDate")]
#if NET6_0_OR_GREATER
        public DateOnly? EndOfSupportDate { get; internal set; }
#else
        public DateTime? EndOfSupportDate { get; internal set; }
#endif

        /// <summary>
        /// The internal organization which budget is used to pay for the configuration item. If the CI is leased or rented, the organization that pays the lease or rent is selected in this field. When creating a new CI and a value is not specified for this field, it is set to the financial owner of the CI's product.
        /// </summary>
        [JsonProperty("financialOwner")]
        public Organization? FinancialOwner { get; internal set; }

        /// <summary>
        /// The date on which the expense for the configuration item (CI) was incurred or, if the CI is depreciated over time, the date on which the depreciation was started. This is typically the invoice date.
        /// </summary>
        [JsonProperty("inUseSince")]
#if NET6_0_OR_GREATER
        public DateOnly? InUseSince { get; internal set; }
#else
        public DateTime? InUseSince { get; internal set; }
#endif

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
        /// The label that is attached to the configuration item (CI). A label is automatically generated using the same prefix of other CIs of the same product category, followed by the next available number as the suffix.
        /// </summary>
        [JsonProperty("label"), Sdk4meField(true)]
        public string? Label { get; internal set; }

        /// <summary>
        /// The date and time at which the configuration item was last seen.
        /// </summary>
        [JsonProperty("lastSeenAt")]
        public DateTime? LastSeenAt { get; internal set; }

        [JsonProperty("licensedSites")]
        internal NodeCollection<Site>? LicensedSitesCollection { get; set; }

        /// <summary>
        /// Sites at which the software that is covered by the license certificate may be used.
        /// </summary>
        public DataList<Site>? LicensedSites
        {
            get => LicensedSitesCollection?.Data;
        }

        /// <summary>
        /// The date through which the temporary software license certificate is valid. The license certificate expires at the end of this day.
        /// </summary>
        [JsonProperty("licenseExpiryDate")]
#if NET6_0_OR_GREATER
        public DateOnly? LicenseExpiryDate { get; internal set; }
#else
        public DateTime? LicenseExpiryDate { get; internal set; }
#endif

        /// <summary>
        /// The type of license that the license certificate covers.
        /// </summary>
        [JsonProperty("licenseType")]
        public CiLicenseType? LicenseType { get; internal set; }

        /// <summary>
        /// The name or number of the room in which the CI is located, if it concerns a hardware CI.
        /// </summary>
        [JsonProperty("location")]
        public string? Location { get; internal set; }

        /// <summary>
        /// The name of the configuration item (CI). When creating a new CI and a value is not specified for this field, it is set to the name of the CI's product.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The total number of processor cores that are installed in the server.
        /// </summary>
        [JsonProperty("nrOfCores")]
        public long? NrOfCores { get; internal set; }

        /// <summary>
        /// The number of licenses that the license certificate covers.
        /// </summary>
        [JsonProperty("nrOfLicenses")]
        public long? NrOfLicenses { get; internal set; }

        /// <summary>
        /// The number of processors that are installed in the server.
        /// </summary>
        [JsonProperty("nrOfProcessors")]
        public long? NrOfProcessors { get; internal set; }

        /// <summary>
        /// The (software) configuration item representing the operating system of this configuration item.
        /// </summary>
        [JsonProperty("operatingSystem")]
        public ConfigurationItem? OperatingSystem { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

        [JsonProperty("problems")]
        internal NodeCollection<Problem>? ProblemsCollection { get; set; }

        /// <summary>
        /// All problems of this configuration item.
        /// </summary>
        public DataList<Problem>? Problems
        {
            get => ProblemsCollection?.Data;
        }

        /// <summary>
        /// Related product.
        /// </summary>
        [JsonProperty("product"), Sdk4meField(true)]
        public Product? Product { get; internal set; }

        /// <summary>
        /// The amount of RAM (in GB) of this configuration item.
        /// </summary>
        [JsonProperty("ramAmount")]
        public long? RamAmount { get; internal set; }

        /// <summary>
        /// Recurrence for maintenance of the configuration item.
        /// </summary>
        [JsonProperty("recurrence")]
        public Recurrence? Recurrence { get; internal set; }

        /// <summary>
        /// Any additional information about the configuration item that might prove useful. When creating a new CI and a value is not specified for this field, it is set to the remarks of the CI's product.
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

        [JsonProperty("requests")]
        internal NodeCollection<Request>? RequestsCollection { get; set; }

        /// <summary>
        /// All requests of this configuration item.
        /// </summary>
        public DataList<Request>? Requests
        {
            get => RequestsCollection?.Data;
        }

        /// <summary>
        /// The Rule set field is automatically set to the rule set of the product category, except when the CI is a license certificate, in which case the rule set is <c>license_certificate</c>.
        /// </summary>
        [JsonProperty("ruleSet"), Sdk4meField(true)]
        public ProductCategoryRuleSet? RuleSet { get; internal set; }

        /// <summary>
        /// Serial number of the configuration item. The concatenation of <c>product</c>'s' <c>brand</c> and <c>serialNr</c> must be unique within a 4me account.
        /// </summary>
        [JsonProperty("serialNr"), Sdk4meField(true)]
        public string? SerialNr { get; internal set; }

        /// <summary>
        /// Which service instance(s) the configuration item is, or will be, a part of. When creating a new CI and a value is not specified for this field, it is set to the service of the CI's product.
        /// </summary>
        [JsonProperty("service"), Sdk4meField(true)]
        public Service? Service { get; internal set; }

        [JsonProperty("serviceInstances")]
        internal NodeCollection<ServiceInstance>? ServiceInstancesCollection { get; set; }

        /// <summary>
        /// All service instances of this configuration item.
        /// </summary>
        public DataList<ServiceInstance>? ServiceInstances
        {
            get => ServiceInstancesCollection?.Data;
        }

        /// <summary>
        /// Where the CI is located, if it concerns a hardware CI.
        /// </summary>
        [JsonProperty("site")]
        public Site? Site { get; internal set; }

        /// <summary>
        /// <c>true</c> for license certificates that may only be used at one or more specific locations.
        /// </summary>
        [JsonProperty("siteLicense")]
        public bool? SiteLicense { get; internal set; }

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
        /// The appropriate status for the configuration item (CI).
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public CiStatus? Status { get; internal set; }

        /// <summary>
        /// The supplier from which the configuration item (CI) has been obtained. When creating a new CI and a value is not specified for this field, it is set to the supplier of the CI's product.
        /// </summary>
        [JsonProperty("supplier")]
        public Organization? Supplier { get; internal set; }

        /// <summary>
        /// The account of the team that supports this configuration item.
        /// </summary>
        [JsonProperty("supportAccount")]
        public Account? SupportAccount { get; internal set; }

        /// <summary>
        /// The team responsible for supporting the configuration item and maintaining its information in the configuration management database (CMDB). When creating a new CI and a value is not specified for this field, it is set to the support team of the CI's product. Optional when status of CI equals "Removed", required otherwise.
        /// </summary>
        [JsonProperty("supportTeam")]
        public Team? SupportTeam { get; internal set; }

        /// <summary>
        /// System identifier of the configuration item.
        /// </summary>
        [JsonProperty("systemID"), Sdk4meField(true)]
        public string? SystemID { get; internal set; }

        /// <summary>
        /// <c>true</c> for license certificates that are not valid indefinitely.
        /// </summary>
        [JsonProperty("temporaryLicense")]
        public bool? TemporaryLicense { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        [JsonProperty("users")]
        internal NodeCollection<Person>? UsersCollection { get; set; }

        /// <summary>
        /// All users of this configuration item.
        /// </summary>
        public DataList<Person>? Users
        {
            get => UsersCollection?.Data;
        }

        /// <summary>
        /// The date through which the warranty coverage for the configuration item is valid. The warranty expires at the end of this day.
        /// </summary>
        [JsonProperty("warrantyExpiryDate")]
#if NET6_0_OR_GREATER
        public DateOnly? WarrantyExpiryDate { get; internal set; }
#else
        public DateTime? WarrantyExpiryDate { get; internal set; }
#endif

        /// <summary>
        /// The person who will be responsible for coordinating the workflows that will be generated automatically in accordance with the recurrence schedule.
        /// </summary>
        [JsonProperty("workflowManager")]
        public Person? WorkflowManager { get; internal set; }

        /// <summary>
        /// The workflow template that is used to periodically maintain the configuration item.
        /// </summary>
        [JsonProperty("workflowTemplate")]
        public WorkflowTemplate? WorkflowTemplate { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(CiRelationsCollection?.GetQueryPageInfo("ciRelations", depth + 1));
            retval.AddRange(ContractsCollection?.GetQueryPageInfo("contracts", depth + 1));
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(InvoicesCollection?.GetQueryPageInfo("invoices", depth + 1));
            retval.AddRange(LicensedSitesCollection?.GetQueryPageInfo("licensedSites", depth + 1));
            retval.AddRange(ProblemsCollection?.GetQueryPageInfo("problems", depth + 1));
            retval.AddRange(RemarksAttachmentsCollection?.GetQueryPageInfo("remarksAttachments", depth + 1));
            retval.AddRange(RequestsCollection?.GetQueryPageInfo("requests", depth + 1));
            retval.AddRange(ServiceInstancesCollection?.GetQueryPageInfo("serviceInstances", depth + 1));
            retval.AddRange(UsersCollection?.GetQueryPageInfo("users", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            CiRelations?.AddRange((data as ConfigurationItem)?.CiRelations);
            Contracts?.AddRange((data as ConfigurationItem)?.Contracts);
            CustomFieldsAttachments?.AddRange((data as ConfigurationItem)?.CustomFieldsAttachments);
            Invoices?.AddRange((data as ConfigurationItem)?.Invoices);
            LicensedSites?.AddRange((data as ConfigurationItem)?.LicensedSites);
            Problems?.AddRange((data as ConfigurationItem)?.Problems);
            RemarksAttachments?.AddRange((data as ConfigurationItem)?.RemarksAttachments);
            Requests?.AddRange((data as ConfigurationItem)?.Requests);
            ServiceInstances?.AddRange((data as ConfigurationItem)?.ServiceInstances);
            Users?.AddRange((data as ConfigurationItem)?.Users);
        }
    }
}
