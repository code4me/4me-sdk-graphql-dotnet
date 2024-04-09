namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing product category.
    /// </summary>
    internal class ProductCategoryUpdateMutation : Mutation<ProductCategoryUpdatePayload, ProductCategoryUpdateInput>
    {
        /// <summary>
        /// Initialize an new ProductCategoryUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The product category response query.</param>
        internal ProductCategoryUpdateMutation(ProductCategoryUpdateInput data, ProductCategoryQuery query)
            : base("productCategoryUpdate", "ProductCategoryUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The product category response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProductCategoryQuery query)
        {
            query.FieldName = "productCategory";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
