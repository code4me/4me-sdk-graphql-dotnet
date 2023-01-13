namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving Product records.
    /// </summary>
    public class ProductQuery : Query<ProductQuery, ProductField, ProductView, ProductOrderField>
    {
        /// <summary>
        /// Initialize a new product query instance.
        /// </summary>
        public ProductQuery()
            : base("products", typeof(Product), true)
        {
        }

        /// <summary>
        /// Configuration items of the product.
        /// </summary>
        public ProductQuery SelectConfigurationItems(ConfigurationItemQuery query)
        {
            query.FieldName = "configurationItems";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ProductQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to the Remarks field.
        /// </summary>
        public ProductQuery SelectRemarksAttachments(AttachmentQuery query)
        {
            query.FieldName = "remarksAttachments";
            return Select(query);
        }
    }
}
