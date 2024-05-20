using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/organization/">Organization</see> object.
    /// </summary>
    public class Organization : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Account? Account { get; internal set; }

        [JsonProperty("addresses")]
        internal NodeCollection<Address>? AddressesCollection { get; set; }

        /// <summary>
        /// Addresses of the record.
        /// </summary>
        public DataList<Address>? Addresses
        {
            get => AddressesCollection?.Data;
        }

        /// <summary>
        /// Whether the organization needs to be treated as a separate entity from a reporting perspective. This checkbox is only available for internal organizations.
        /// </summary>
        [JsonProperty("businessUnit")]
        public bool? BusinessUnit { get; internal set; }

        /// <summary>
        /// Refers to itself if the organization is a business unit, or refers to the business unit that the organization belongs to.
        /// </summary>
        [JsonProperty("businessUnitOrganization")]
        public Organization? BusinessUnitOrganization { get; internal set; }

        [JsonProperty("childOrganizations")]
        internal NodeCollection<Organization>? ChildOrganizationsCollection { get; set; }

        /// <summary>
        /// Child organizations of this organization, i.e. organizations that have this organization as their parent.
        /// </summary>
        public DataList<Organization>? ChildOrganizations
        {
            get => ChildOrganizationsCollection?.Data;
        }

        [JsonProperty("contacts")]
        internal NodeCollection<Contact>? ContactsCollection { get; set; }

        /// <summary>
        /// Contact details for this entity.
        /// </summary>
        public DataList<Contact>? Contacts
        {
            get => ContactsCollection?.Data;
        }

        [JsonProperty("contracts")]
        internal NodeCollection<Contract>? ContractsCollection { get; set; }

        /// <summary>
        /// Contracts of this organization.
        /// </summary>
        public DataList<Contract>? Contracts
        {
            get => ContractsCollection?.Data;
        }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(IsDefaultQueryProperty = true)]
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
        /// Whether the organization may no longer be related to other records.
        /// </summary>
        [JsonProperty("disabled"), Sdk4meField(IsDefaultQueryProperty = true)]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// The unique identifier by which the organization is known in the financial system.
        /// </summary>
        [JsonProperty("financialID"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? FinancialID { get; internal set; }

        /// <summary>
        /// The manager of the organization.
        /// </summary>
        [JsonProperty("manager")]
        public Person? Manager { get; internal set; }

        /// <summary>
        /// The full name of the organization.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// Refers to the order template that is used for purchases of people defined in this organization or its descendants.
        /// </summary>
        [JsonProperty("orderTemplate")]
        public RequestTemplate? OrderTemplate { get; internal set; }

        /// <summary>
        /// The organization's parent organization.
        /// </summary>
        [JsonProperty("parent")]
        public Organization? Parent { get; internal set; }

        [JsonProperty("people")]
        internal NodeCollection<Person>? PeopleCollection { get; set; }

        /// <summary>
        /// People of this organization.
        /// </summary>
        public DataList<Person>? People
        {
            get => PeopleCollection?.Data;
        }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

        /// <summary>
        /// <br>Which region the organization belongs to.</br>
        /// <br>Examples of commonly used region names are:</br>
        /// <br></br>
        /// <br>- Asia Pacific (APAC)</br>
        /// <br>- Europe, Middle East &amp; Africa (EMEA)</br>
        /// <br>- North America (NA)</br>
        /// </summary>
        [JsonProperty("region")]
        public string? Region { get; internal set; }

        /// <summary>
        /// Any additional information about the organization that might prove useful.
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

        [JsonProperty("risks")]
        internal NodeCollection<Risk>? RisksCollection { get; set; }

        /// <summary>
        /// Risks of this organization.
        /// </summary>
        public DataList<Risk>? Risks
        {
            get => RisksCollection?.Data;
        }

        [JsonProperty("serviceLevelAgreements")]
        internal NodeCollection<ServiceLevelAgreement>? ServiceLevelAgreementsCollection { get; set; }

        /// <summary>
        /// Service level agreements which coverage field is set to <c>organizations</c> and which cover the organization.
        /// </summary>
        public DataList<ServiceLevelAgreement>? ServiceLevelAgreements
        {
            get => ServiceLevelAgreementsCollection?.Data;
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The person who acts as the substitute of the organization's manager.
        /// </summary>
        [JsonProperty("substitute")]
        public Person? Substitute { get; internal set; }

        [JsonProperty("timeAllocations")]
        internal NodeCollection<TimeAllocation>? TimeAllocationsCollection { get; set; }

        /// <summary>
        /// Time allocations of this organization.
        /// </summary>
        public DataList<TimeAllocation>? TimeAllocations
        {
            get => TimeAllocationsCollection?.Data;
        }

        /// <summary>
        /// UI extension that is linked to the record.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(AddressesCollection?.GetQueryPageInfo("addresses", depth + 1));
            retval.AddRange(ChildOrganizationsCollection?.GetQueryPageInfo("childOrganizations", depth + 1));
            retval.AddRange(ContactsCollection?.GetQueryPageInfo("contacts", depth + 1));
            retval.AddRange(ContractsCollection?.GetQueryPageInfo("contracts", depth + 1));
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            retval.AddRange(PeopleCollection?.GetQueryPageInfo("people", depth + 1));
            retval.AddRange(RemarksAttachmentsCollection?.GetQueryPageInfo("remarksAttachments", depth + 1));
            retval.AddRange(RisksCollection?.GetQueryPageInfo("risks", depth + 1));
            retval.AddRange(ServiceLevelAgreementsCollection?.GetQueryPageInfo("serviceLevelAgreements", depth + 1));
            retval.AddRange(TimeAllocationsCollection?.GetQueryPageInfo("timeAllocations", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Addresses?.AddRange((data as Organization)?.Addresses);
            ChildOrganizations?.AddRange((data as Organization)?.ChildOrganizations);
            Contacts?.AddRange((data as Organization)?.Contacts);
            Contracts?.AddRange((data as Organization)?.Contracts);
            CustomFieldsAttachments?.AddRange((data as Organization)?.CustomFieldsAttachments);
            People?.AddRange((data as Organization)?.People);
            RemarksAttachments?.AddRange((data as Organization)?.RemarksAttachments);
            Risks?.AddRange((data as Organization)?.Risks);
            ServiceLevelAgreements?.AddRange((data as Organization)?.ServiceLevelAgreements);
            TimeAllocations?.AddRange((data as Organization)?.TimeAllocations);
        }
    }
}
