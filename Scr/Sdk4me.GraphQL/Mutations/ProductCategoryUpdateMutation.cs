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
        internal ProductCategoryUpdateMutation(ProductCategoryUpdateInput data)
            : base("productCategoryUpdate", "ProductCategoryUpdateInput!", data, new HashSet<IQuery>() { new ProductCategoryQuery() { FieldName = "productCategory", IsConnection = false }.Select("*") })
        {
        }
    }
}
