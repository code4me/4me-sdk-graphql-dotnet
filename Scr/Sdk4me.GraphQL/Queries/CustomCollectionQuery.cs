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
    }
}
