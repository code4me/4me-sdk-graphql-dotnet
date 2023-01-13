namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new shop article.
    /// </summary>
    internal class ShopArticleCreateMutation : Mutation<ShopArticleCreatePayload, ShopArticleCreateInput>
    {
        /// <summary>
        /// Initialize an new ShopArticleCreate mutation instance.
        /// </summary>
        internal ShopArticleCreateMutation(ShopArticleCreateInput data)
            : base("shopArticleCreate", "ShopArticleCreateInput!", data, new HashSet<IQuery>() { new ShopArticleQuery() { FieldName = "shopArticle", IsConnection = false }.Select("*") })
        {
        }
    }
}
