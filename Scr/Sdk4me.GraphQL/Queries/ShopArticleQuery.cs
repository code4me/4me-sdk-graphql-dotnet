namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ShopArticle records.
    /// </summary>
    public class ShopArticleQuery : Query<ShopArticleQuery, ShopArticleField, ShopArticleView, ShopArticleOrderField>
    {
        /// <summary>
        /// Initialize a new shop article query instance.
        /// </summary>
        public ShopArticleQuery()
            : base("shopArticles", typeof(ShopArticle), true)
        {
        }
    }
}
