namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Service records.
    /// </summary>
    public class ServiceQuery : Query<ServiceQuery, ServiceField, ServiceView, ServiceOrderField>
    {
        /// <summary>
        /// Initialize a new service query instance.
        /// </summary>
        public ServiceQuery()
            : base("services", typeof(Service), true)
        {
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ServiceQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        public ServiceQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Service instances related to this service.
        /// </summary>
        public ServiceQuery SelectServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "serviceInstances";
            return Select(query);
        }

        /// <summary>
        /// Service level agreements related to this service through the service offering.
        /// </summary>
        public ServiceQuery SelectServiceLevelAgreements(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "serviceLevelAgreements";
            return Select(query);
        }

        /// <summary>
        /// Service offerings related to this service.
        /// </summary>
        public ServiceQuery SelectServiceOfferings(ServiceOfferingQuery query)
        {
            query.FieldName = "serviceOfferings";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public ServiceQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
