namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving UiExtension records.
    /// </summary>
    public class UiExtensionQuery : Query<UiExtensionQuery, UiExtensionField, UiExtensionView, UiExtensionFilter, UiExtensionOrderField>
    {
        /// <summary>
        /// Initialize a new ui extension query instance.
        /// </summary>
        public UiExtensionQuery()
            : base("uiExtensions", typeof(UiExtension), true)
        {
        }

        /// <summary>
        /// Initialize a new ui extension query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the ui extension.</param>
        public UiExtensionQuery(string id)
            : base("UiExtension", id, typeof(UiExtension), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public UiExtensionQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The version with Status <c>active</c>.
        /// </summary>
        /// <param name="query">The ui extension version query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public UiExtensionQuery SelectActiveVersion(UiExtensionVersionQuery query)
        {
            query.FieldName = "activeVersion";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person who created the UI extension.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public UiExtensionQuery SelectCreatedBy(PersonQuery query)
        {
            query.FieldName = "createdBy";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Description field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public UiExtensionQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// Translations associated with this object.
        /// </summary>
        /// <param name="query">The translation query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public UiExtensionQuery SelectTranslations(TranslationQuery query)
        {
            query.FieldName = "translations";
            return Select(query);
        }

        /// <summary>
        /// The person who last updated the UI extension.
        /// </summary>
        /// <param name="query">The person query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public UiExtensionQuery SelectUpdatedBy(PersonQuery query)
        {
            query.FieldName = "updatedBy";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Versions of the UI extension.
        /// </summary>
        /// <param name="query">The ui extension version query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public UiExtensionQuery SelectVersions(UiExtensionVersionQuery query)
        {
            query.FieldName = "versions";
            return Select(query);
        }
    }
}
