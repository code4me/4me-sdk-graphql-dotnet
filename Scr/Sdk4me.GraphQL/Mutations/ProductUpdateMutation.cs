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
        internal ProductUpdateMutation(ProductUpdateInput data)
            : base("productUpdate", "ProductUpdateInput!", data, new HashSet<IQuery>() { new ProductQuery() { FieldName = "product", IsConnection = false }.Select("*") })
        {
        }
    }
}
