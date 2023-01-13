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
        internal ProductCategoryCreateMutation(ProductCategoryCreateInput data)
            : base("productCategoryCreate", "ProductCategoryCreateInput!", data, new HashSet<IQuery>() { new ProductCategoryQuery() { FieldName = "productCategory", IsConnection = false }.Select("*") })
        {
        }
    }
}
