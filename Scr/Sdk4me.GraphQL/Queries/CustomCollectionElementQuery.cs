namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving CustomCollectionElement records.
    /// </summary>
    public class CustomCollectionElementQuery : Query<CustomCollectionElementQuery, CustomCollectionElementField, CustomCollectionElementView, CustomCollectionElementOrderField>
    {
        /// <summary>
        /// Initialize a new custom collection element query instance.
        /// </summary>
        public CustomCollectionElementQuery()
            : base("customCollectionElements", typeof(CustomCollectionElement), true)
        {
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public CustomCollectionElementQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Information field.
        /// </summary>
        public CustomCollectionElementQuery SelectInformationAttachments(AttachmentQuery query)
        {
            query.FieldName = "informationAttachments";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public CustomCollectionElementQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }
    }
}
