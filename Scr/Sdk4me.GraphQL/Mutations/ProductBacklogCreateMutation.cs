namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new product backlog.
    /// </summary>
    internal class ProductBacklogCreateMutation : Mutation<ProductBacklogCreatePayload, ProductBacklogCreateInput>
    {
        /// <summary>
        /// Initialize an new ProductBacklogCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ProductBacklogCreateMutation(ProductBacklogCreateInput data, ProductBacklogQuery query)
            : base("productBacklogCreate", "ProductBacklogCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProductBacklogQuery query)
        {
            query.FieldName = "productBacklog";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
