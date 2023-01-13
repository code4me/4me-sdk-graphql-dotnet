namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Organization records.
    /// </summary>
    public class OrganizationQuery : Query<OrganizationQuery, OrganizationField, OrganizationView, OrganizationOrderField>
    {
        /// <summary>
        /// Initialize a new organization query instance.
        /// </summary>
        public OrganizationQuery()
            : base("organizations", typeof(Organization), true)
        {
        }

        /// <summary>
        /// Addresses of the record.
        /// </summary>
        public OrganizationQuery SelectAddresses(AddressQuery query)
        {
            query.FieldName = "addresses";
            return Select(query);
        }

        /// <summary>
        /// Child organizations of this organization, i.e. organizations that have this organization as their parent.
        /// </summary>
        public OrganizationQuery SelectChildOrganizations(OrganizationQuery query)
        {
            query.FieldName = "childOrganizations";
            return Select(query);
        }

        /// <summary>
        /// Contact details for this entity.
        /// </summary>
        public OrganizationQuery SelectContacts(ContactQuery query)
        {
            query.FieldName = "contacts";
            return Select(query);
        }

        /// <summary>
        /// Contracts of this organization.
        /// </summary>
        public OrganizationQuery SelectContracts(ContractQuery query)
        {
            query.FieldName = "contracts";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public OrganizationQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// People of this organization.
        /// </summary>
        public OrganizationQuery SelectPeople(PersonQuery query)
        {
            query.FieldName = "people";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public OrganizationQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }

        /// <summary>
        /// Risks of this organization.
        /// </summary>
        public OrganizationQuery SelectRisks(RiskQuery query)
        {
            query.FieldName = "risks";
            return Select(query);
        }

        /// <summary>
        /// Service level agreements which coverage field is set to `organizations` and which cover the organization.
        /// </summary>
        public OrganizationQuery SelectServiceLevelAgreements(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "serviceLevelAgreements";
            return Select(query);
        }

        /// <summary>
        /// Time allocations of this organization.
        /// </summary>
        public OrganizationQuery SelectTimeAllocations(TimeAllocationQuery query)
        {
            query.FieldName = "timeAllocations";
            return Select(query);
        }
    }
}
