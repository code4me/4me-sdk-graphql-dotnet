namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving UiExtension records.
    /// </summary>
    public class UiExtensionQuery : Query<UiExtensionQuery, UiExtensionField, UiExtensionView, UiExtensionOrderField>
    {
        /// <summary>
        /// Initialize a new user interface extension query instance.
        /// </summary>
        public UiExtensionQuery()
            : base("uiExtensions", typeof(UiExtension), true)
        {
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
        /// Versions of the user interface extension.
        /// </summary>
        public UiExtensionQuery SelectVersions(UiExtensionVersionQuery query)
        {
            query.FieldName = "versions";
            return Select(query);
        }
    }
}
