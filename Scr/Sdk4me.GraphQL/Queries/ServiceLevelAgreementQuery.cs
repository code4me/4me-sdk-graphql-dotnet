namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ServiceLevelAgreement records.
    /// </summary>
    public class ServiceLevelAgreementQuery : Query<ServiceLevelAgreementQuery, ServiceLevelAgreementField, ServiceLevelAgreementView, ServiceLevelAgreementFilter, ServiceLevelAgreementOrderField>
    {
        /// <summary>
        /// Initialize a new service level agreement query instance.
        /// </summary>
        public ServiceLevelAgreementQuery()
            : base("serviceLevelAgreements", typeof(ServiceLevelAgreement), true)
        {
        }

        /// <summary>
        /// Initialize a new service level agreement query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the service level agreement.</param>
        public ServiceLevelAgreementQuery(string id)
            : base("ServiceLevelAgreement", id, typeof(ServiceLevelAgreement), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider. This contains the activityIDs related to request categories.
        /// </summary>
        /// <param name="query">The activity iD query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectActivityID(ActivityIDQuery query)
        {
            query.FieldName = "activityID";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Coverage groups of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>coverage_groups</c>.
        /// </summary>
        /// <param name="query">The sla coverage group query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectCoverageGroups(SlaCoverageGroupQuery query)
        {
            query.FieldName = "coverageGroups";
            return Select(query);
        }

        /// <summary>
        /// The organization that pays for the agreement.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectCustomer(OrganizationQuery query)
        {
            query.FieldName = "customer";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The customer account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectCustomerAccount(AccountQuery query)
        {
            query.FieldName = "customerAccount";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The people who represent the customer organization for the service level agreement.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectCustomerRepresentatives(PersonQuery query)
        {
            query.FieldName = "customerRepresentatives";
            return Select(query);
        }

        /// <summary>
        /// The Rate IDs are the unique identifiers by which an effort class that is linked to a time entry when an activity was performed through the coverage of the SLA is known in the billing system of the service provider.
        /// </summary>
        /// <param name="query">The effort class rate iD query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectEffortClassRateIDs(EffortClassRateIDQuery query)
        {
            query.FieldName = "effortClassRateIDs";
            return Select(query);
        }

        /// <summary>
        /// Invoices associated with this object.
        /// </summary>
        /// <param name="query">The invoice query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectInvoices(InvoiceQuery query)
        {
            query.FieldName = "invoices";
            return Select(query);
        }

        /// <summary>
        /// Organizations of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>organizations_and_descendants</c>, <c>organizations</c> or <c>organizations_and_sites</c>.
        /// </summary>
        /// <param name="query">The organization query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectOrganizations(OrganizationQuery query)
        {
            query.FieldName = "organizations";
            return Select(query);
        }

        /// <summary>
        /// People of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>people</c>.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectPeople(PersonQuery query)
        {
            query.FieldName = "people";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }

        /// <summary>
        /// The service instance that will be used to provide the service to the customer of the service level agreement. Only service instances that are linked to the same service as the selected service offering can be selected.
        /// </summary>
        /// <param name="query">The service instance query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectServiceInstance(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstance";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The service instances that consume the service instance for which the service level agreement is registered. Only available for service level agreements where the <c>coverage</c> field is set to <c>service_instances</c>.
        /// </summary>
        /// <param name="query">The parent service instance query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectServiceInstances(ParentServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// The person of the service provider organization who acts as the service level manager for the customer of the service level agreement.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectServiceLevelManager(PersonQuery query)
        {
            query.FieldName = "serviceLevelManager";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Service offering that specifies the conditions that apply to the service level agreement.
        /// </summary>
        /// <param name="query">The service offering query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectServiceOffering(ServiceOfferingQuery query)
        {
            query.FieldName = "serviceOffering";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Sites of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>sites</c> or <c>organizations_and_sites</c>.
        /// </summary>
        /// <param name="query">The site query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectSites(SiteQuery query)
        {
            query.FieldName = "sites";
            return Select(query);
        }

        /// <summary>
        /// Skill pools of the service level agreement. Only available for service level agreements where the <c>coverage</c> field is set to <c>skill_pools</c>.
        /// </summary>
        /// <param name="query">The skill pool query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectSkillPools(SkillPoolQuery query)
        {
            query.FieldName = "skillPools";
            return Select(query);
        }

        /// <summary>
        /// Represents the activityIDs for standard service requests. The Activity ID is the unique identifier by which an activity that is performed in the context of a service offering is known in the billing system of the service provider.
        /// </summary>
        /// <param name="query">The standard service request activity iD query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectStandardServiceRequestActivityIDs(StandardServiceRequestActivityIDQuery query)
        {
            query.FieldName = "standardServiceRequestActivityIDs";
            return Select(query);
        }

        /// <summary>
        /// The support domain account that offers the support to users covered by this the service level agreement.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceLevelAgreementQuery SelectSupportDomain(AccountQuery query)
        {
            query.FieldName = "supportDomain";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
