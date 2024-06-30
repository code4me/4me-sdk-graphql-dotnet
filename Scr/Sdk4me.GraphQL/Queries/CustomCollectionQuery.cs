namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving CustomCollection records.
    /// </summary>
    public class CustomCollectionQuery : Query<CustomCollectionQuery, CustomCollectionField, DefaultView, CustomCollectionFilter, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new custom collection query instance.
        /// </summary>
        public CustomCollectionQuery()
            : base("customCollections", typeof(CustomCollection), true)
        {
        }

        /// <summary>
        /// Initialize a new custom collection query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the custom collection.</param>
        public CustomCollectionQuery(string id)
            : base("CustomCollection", id, typeof(CustomCollection), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        /// <param name="query">The account query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public CustomCollectionQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Elements of this custom collection.
        /// </summary>
        /// <param name="query">The custom collection element query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public CustomCollectionQuery SelectCollectionElements(CustomCollectionElementQuery query)
        {
            query.FieldName = "collectionElements";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Description field.
        /// </summary>
        /// <param name="query">The attachment query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public CustomCollectionQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// UI extension that is linked to the collection.
        /// </summary>
        /// <param name="query">The ui extension query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public CustomCollectionQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
