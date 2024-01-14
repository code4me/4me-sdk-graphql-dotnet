namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ShopArticleCategory records.
    /// </summary>
    public class ShopArticleCategoryQuery : Query<ShopArticleCategoryQuery, ShopArticleCategoryField, ShopArticleCategoryView, ShopArticleCategoryOrderField>
    {
        /// <summary>
        /// Initialize a new shop article category query instance.
        /// </summary>
        public ShopArticleCategoryQuery()
            : base("shopArticleCategories", typeof(ShopArticleCategory), true)
        {
        }

        /// <summary>
        /// Initialize a new shop article category query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the shop article category.</param>
        public ShopArticleCategoryQuery(string id)
            : base("ShopArticleCategory", id, typeof(ShopArticleCategory), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public ShopArticleCategoryQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The attachments used in the <c>fullDescription</c> field.
        /// </summary>
        public ShopArticleCategoryQuery SelectFullDescriptionAttachments(AttachmentQuery query)
        {
            query.FieldName = "fullDescriptionAttachments";
            return Select(query);
        }

        /// <summary>
        /// The category's parent category.
        /// </summary>
        public ShopArticleCategoryQuery SelectParent(ShopArticleCategoryQuery query)
        {
            query.FieldName = "parent";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
