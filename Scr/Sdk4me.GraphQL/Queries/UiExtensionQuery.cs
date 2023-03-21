namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving UiExtension records.
    /// </summary>
    public class UiExtensionQuery : Query<UiExtensionQuery, UiExtensionField, UiExtensionView, UiExtensionOrderField>
    {
        /// <summary>
        /// Initialize a new ui extension query instance.
        /// </summary>
        public UiExtensionQuery()
            : base("uiExtensions", typeof(UiExtension), true)
        {
        }

        /// <summary>
        /// Files and inline images linked to the Description field.
        /// </summary>
        public UiExtensionQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        public UiExtensionQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }

        /// <summary>
        /// Versions of the UI extension.
        /// </summary>
        public UiExtensionQuery SelectVersions(UiExtensionVersionQuery query)
        {
            query.FieldName = "versions";
            return Select(query);
        }
    }
}
