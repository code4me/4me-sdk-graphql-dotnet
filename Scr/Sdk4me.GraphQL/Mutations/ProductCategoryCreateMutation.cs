using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new product category.
    /// </summary>
    internal class ProductCategoryCreateMutation : Mutation<ProductCategoryCreatePayload, ProductCategoryCreateInput>
    {
        /// <summary>
        /// Initialize an new ProductCategoryCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The product category response query.</param>
        internal ProductCategoryCreateMutation(ProductCategoryCreateInput data, ProductCategoryQuery query)
            : base("productCategoryCreate", "ProductCategoryCreateInput!", data, GetQuery(query))
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
