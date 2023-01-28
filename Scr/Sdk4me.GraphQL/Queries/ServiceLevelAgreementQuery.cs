namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ServiceLevelAgreement records.
    /// </summary>
    public class ServiceLevelAgreementQuery : Query<ServiceLevelAgreementQuery, ServiceLevelAgreementField, ServiceLevelAgreementView, ServiceLevelAgreementOrderField>
    {
        /// <summary>
        /// Initialize a new service level agreement query instance.
        /// </summary>
        public ServiceLevelAgreementQuery()
            : base("serviceLevelAgreements", typeof(ServiceLevelAgreement), true)
        {
        }

        /// <summary>
        /// The people who represent the customer organization for the service level agreement.
        /// </summary>
        public ServiceLevelAgreementQuery SelectCustomerRepresentatives(PersonQuery query)
        {
            query.FieldName = "customerRepresentatives";
            return Select(query);
        }

        /// <summary>
        /// The Charge IDs are the unique identifiers by which an effort class that is linked to a time entry when an activity was performed through the coverage of the service level agreement is known in the billing system of the service provider.
        /// </summary>
        public ServiceLevelAgreementQuery SelectEffortClassChargeIDs(EffortClassChargeIDQuery query)
        {
            query.FieldName = "effortClassChargeIDs";
            return Select(query);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        public ServiceLevelAgreementQuery SelectInvoices(InvoiceQuery query)
        {
            query.FieldName = "invoices";
            return Select(query);
        }

        /// <summary>
        /// Organizations of the service level agreement. Only available for service level agreements where the `coverage` field is set to `organizations_and_descendants`, `organizations` or `organizations_and_sites`.
        /// </summary>
        public ServiceLevelAgreementQuery SelectOrganizations(OrganizationQuery query)
        {
            query.FieldName = "organizations";
            return Select(query);
        }

        /// <summary>
        /// People of the service level agreement. Only available for service level agreements where the `coverage` field is set to `people`.
        /// </summary>
        public ServiceLevelAgreementQuery SelectPeople(PersonQuery query)
        {
            query.FieldName = "people";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public ServiceLevelAgreementQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }

        /// <summary>
        /// The service instances that consume the service instance for which the service level agreement is registered. Only available for service level agreements where the `coverage` field is set to `service_instances`.
        /// </summary>
        public ServiceLevelAgreementQuery SelectServiceInstances(ParentServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// Sites of the service level agreement. Only available for service level agreements where the `coverage` field is set to `sites` or `organizations_and_sites`.
        /// </summary>
        public ServiceLevelAgreementQuery SelectSites(SiteQuery query)
        {
            query.FieldName = "sites";
            return Select(query);
        }

        /// <summary>
        /// Skill pools of the service level agreement. Only available for service level agreements where the `coverage` field is set to `skill_pools`.
        /// </summary>
        public ServiceLevelAgreementQuery SelectSkillPools(SkillPoolQuery query)
        {
            query.FieldName = "skillPools";
            return Select(query);
        }

        /// <summary>
        /// Represents the activityIDs for standard service requests. The Activity identifier is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        public ServiceLevelAgreementQuery SelectStandardServiceRequestActivityIDs(StandardServiceRequestActivityIDQuery query)
        {
            query.FieldName = "standardServiceRequestActivityIDs";
            return Select(query);
        }
    }
}
