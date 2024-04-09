namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing shop article category.
    /// </summary>
    internal class ShopArticleCategoryUpdateMutation : Mutation<ShopArticleCategoryUpdatePayload, ShopArticleCategoryUpdateInput>
    {
        /// <summary>
        /// Initialize an new ShopArticleCategoryUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The shop article category response query.</param>
        internal ShopArticleCategoryUpdateMutation(ShopArticleCategoryUpdateInput data, ShopArticleCategoryQuery query)
            : base("shopArticleCategoryUpdate", "ShopArticleCategoryUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The shop article category response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ShopArticleCategoryQuery query)
        {
            query.FieldName = "shopArticleCategory";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
