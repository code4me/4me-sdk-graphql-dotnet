namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing product.
    /// </summary>
    internal class ProductUpdateMutation : Mutation<ProductUpdatePayload, ProductUpdateInput>
    {
        /// <summary>
        /// Initialize an new ProductUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ProductUpdateMutation(ProductUpdateInput data, ProductQuery query)
            : base("productUpdate", "ProductUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProductQuery query)
        {
            query.FieldName = "product";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
