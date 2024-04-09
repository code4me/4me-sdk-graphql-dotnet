namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new shop article category.
    /// </summary>
    internal class ShopArticleCategoryCreateMutation : Mutation<ShopArticleCategoryCreatePayload, ShopArticleCategoryCreateInput>
    {
        /// <summary>
        /// Initialize an new ShopArticleCategoryCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The shop article category response query.</param>
        internal ShopArticleCategoryCreateMutation(ShopArticleCategoryCreateInput data, ShopArticleCategoryQuery query)
            : base("shopArticleCategoryCreate", "ShopArticleCategoryCreateInput!", data, GetQuery(query))
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
