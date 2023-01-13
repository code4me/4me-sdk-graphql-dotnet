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
        internal ProductCreateMutation(ProductCreateInput data)
            : base("productCreate", "ProductCreateInput!", data, new HashSet<IQuery>() { new ProductQuery() { FieldName = "product", IsConnection = false }.Select("*") })
        {
        }
    }
}
