namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ServiceCategory records.
    /// </summary>
    public class ServiceCategoryQuery : Query<ServiceCategoryQuery, ServiceCategoryField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new service category query instance.
        /// </summary>
        public ServiceCategoryQuery()
            : base("serviceCategories", typeof(ServiceCategory), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public ServiceCategoryQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        public ServiceCategoryQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Services of the service category.
        /// </summary>
        public ServiceCategoryQuery SelectServices(ServiceQuery query)
        {
            query.FieldName = "services";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public ServiceCategoryQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
