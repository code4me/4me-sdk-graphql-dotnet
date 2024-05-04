using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new product.
    /// </summary>
    internal class ProductCreateMutation : Mutation<ProductCreatePayload, ProductCreateInput>
    {
        /// <summary>
        /// Initialize an new ProductCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The product response query.</param>
        internal ProductCreateMutation(ProductCreateInput data, ProductQuery query)
            : base("productCreate", "ProductCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The product response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ProductQuery query)
        {
            query.FieldName = "product";
            query.IsConnection = false;
            return new HashSet<IQuery>() { query };
        }
    }
}
