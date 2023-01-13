namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="ProviderShopArticle">ProviderShopArticle</see> query.
    /// </summary>
    public class ProviderShopArticleQuery : Query<ProviderShopArticleQuery, ProviderShopArticleField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new provider shop article query instance.
        /// </summary>
        public ProviderShopArticleQuery()
            : base("", typeof(ProviderShopArticle), false)
        {
        }
    }
}
