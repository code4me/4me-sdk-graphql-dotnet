namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving CustomCollection records.
    /// </summary>
    public class CustomCollectionQuery : Query<CustomCollectionQuery, CustomCollectionField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new custom collection query instance.
        /// </summary>
        public CustomCollectionQuery()
            : base("customCollections", typeof(CustomCollection), true)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public CustomCollectionQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Elements of this custom collection.
        /// </summary>
        public CustomCollectionQuery SelectCollectionElements(CustomCollectionElementQuery query)
        {
            query.FieldName = "collectionElements";
            return Select(query);
        }

        /// <summary>
        /// Files and inline images linked to the Description field.
        /// </summary>
        public CustomCollectionQuery SelectDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "descriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// UI extension that is linked to the collection.
        /// </summary>
        public CustomCollectionQuery SelectUiExtension(UiExtensionQuery query)
        {
            query.FieldName = "uiExtension";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
