using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing product backlog.
    /// </summary>
    internal class ProductBacklogUpdateMutation : Mutation<ProductBacklogUpdatePayload, ProductBacklogUpdateInput>
    {
        /// <summary>
        /// Initialize an new ProductBacklogUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The product backlog response query.</param>
        internal ProductBacklogUpdateMutation(ProductBacklogUpdateInput data, ProductBacklogQuery query)
            : base("productBacklogUpdate", "ProductBacklogUpdateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The product backlog response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProductBacklogQuery query)
        {
            query.FieldName = "productBacklog";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
