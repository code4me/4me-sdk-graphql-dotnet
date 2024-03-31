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
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ShopArticleCreateMutation(ShopArticleCreateInput data, ShopArticleQuery query)
            : base("shopArticleCreate", "ShopArticleCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ShopArticleQuery query)
        {
            query.FieldName = "shopArticle";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
