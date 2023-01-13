namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing shop article.
    /// </summary>
    internal class ShopArticleUpdateMutation : Mutation<ShopArticleUpdatePayload, ShopArticleUpdateInput>
    {
        /// <summary>
        /// Initialize an new ShopArticleUpdate mutation instance.
        /// </summary>
        internal ShopArticleUpdateMutation(ShopArticleUpdateInput data)
            : base("shopArticleUpdate", "ShopArticleUpdateInput!", data, new HashSet<IQuery>() { new ShopArticleQuery() { FieldName = "shopArticle", IsConnection = false }.Select("*") })
        {
        }
    }
}
