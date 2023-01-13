namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ServiceInstance records.
    /// </summary>
    public class ServiceInstanceQuery : Query<ServiceInstanceQuery, ServiceInstanceField, ServiceInstanceView, ServiceInstanceOrderField>
    {
        /// <summary>
        /// Initialize a new service instance query instance.
        /// </summary>
        public ServiceInstanceQuery()
            : base("serviceInstances", typeof(ServiceInstance), true)
        {
        }

        /// <summary>
        /// Children of the service instance.
        /// </summary>
        public ServiceInstanceQuery SelectChildServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "childServiceInstances";
            return Select(query);
        }

        /// <summary>
        /// Configuration items of the service instance.
        /// </summary>
        public ServiceInstanceQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItems";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ServiceInstanceQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Parents of the service instance.
        /// </summary>
        public ServiceInstanceQuery SelectParentServiceInstances(ServiceInstanceQuery query)
        {
            query.FieldName = "parentServiceInstances";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Remarks field.
        /// </summary>
        public ServiceInstanceQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }

        /// <summary>
        /// Service level agreements of the service instance.
        /// </summary>
        public ServiceInstanceQuery SelectServiceLevelAgreements(ServiceLevelAgreementQuery query)
        {
            query.FieldName = "serviceLevelAgreements";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public ServiceInstanceQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
