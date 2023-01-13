namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ServiceOffering records.
    /// </summary>
    public class ServiceOfferingQuery : Query<ServiceOfferingQuery, ServiceOfferingField, ServiceOfferingView, ServiceOfferingOrderField>
    {
        /// <summary>
        /// Initialize a new service offering query instance.
        /// </summary>
        public ServiceOfferingQuery()
            : base("serviceOfferings", typeof(ServiceOffering), true)
        {
        }

        /// <summary>
        /// Inline images linked to the Charges field.
        /// </summary>
        public ServiceOfferingQuery SelectChargesAttachments(AttachmentQuery query)
        {
            query.FieldName = "chargesAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Continuity field.
        /// </summary>
        public ServiceOfferingQuery SelectContinuityAttachments(AttachmentQuery query)
        {
            query.FieldName = "continuityAttachments";
            return Select(query);
        }

        /// <summary>
        /// Effort classes of the service offering.
        /// </summary>
        public ServiceOfferingQuery SelectEffortClasses(EffortClassQuery query)
        {
            query.FieldName = "effortClasses";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Limitations field.
        /// </summary>
        public ServiceOfferingQuery SelectLimitationsAttachments(AttachmentQuery query)
        {
            query.FieldName = "limitationsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Penalties field.
        /// </summary>
        public ServiceOfferingQuery SelectPenaltiesAttachments(AttachmentQuery query)
        {
            query.FieldName = "penaltiesAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Performance field.
        /// </summary>
        public ServiceOfferingQuery SelectPerformanceAttachments(AttachmentQuery query)
        {
            query.FieldName = "performanceAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Prerequisites field.
        /// </summary>
        public ServiceOfferingQuery SelectPrerequisitesAttachments(AttachmentQuery query)
        {
            query.FieldName = "prerequisitesAttachments";
            return Select(query);
        }

        /// <summary>
        /// Service level agreements of the service offering.
        /// </summary>
        public ServiceOfferingQuery SelectServiceLevelAgreements(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "serviceLevelAgreements";
            return Select(query);
        }

        /// <summary>
        /// Shop articles related to the service offering.
        /// </summary>
        public ServiceOfferingQuery SelectShopArticles(ShopArticleQuery query)
        {
            query.FieldName = "shopArticles";
            return Select(query);
        }

        /// <summary>
        /// Standard service requests of the service offering.
        /// </summary>
        public ServiceOfferingQuery SelectStandardServiceRequests(StandardServiceRequestQuery query)
        {
            query.FieldName = "standardServiceRequests";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Summary field.
        /// </summary>
        public ServiceOfferingQuery SelectSummaryAttachments(AttachmentQuery query)
        {
            query.FieldName = "summaryAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Termination field.
        /// </summary>
        public ServiceOfferingQuery SelectTerminationAttachments(AttachmentQuery query)
        {
            query.FieldName = "terminationAttachments";
            return Select(query);
        }
    }
}
