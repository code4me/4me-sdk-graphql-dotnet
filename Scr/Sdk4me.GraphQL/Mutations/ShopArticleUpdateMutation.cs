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
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ShopArticleUpdateMutation(ShopArticleUpdateInput data, ShopArticleQuery query)
            : base("shopArticleUpdate", "ShopArticleUpdateInput!", data, GetQuery(query))
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
