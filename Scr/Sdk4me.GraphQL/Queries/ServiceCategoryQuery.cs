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
        /// Initialize a new service category query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the service category.</param>
        public ServiceCategoryQuery(string id)
            : base("ServiceCategory", id, typeof(ServiceCategory), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceCategoryQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceCategoryQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Services of the service category.
        /// </summary>
        /// <param name="query">The service query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceCategoryQuery SelectServices(ServiceQuery query)
        {
            query.FieldName = "services";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translation query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ServiceCategoryQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
