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
        internal ProductBacklogCreateMutation(ProductBacklogCreateInput data)
            : base("productBacklogCreate", "ProductBacklogCreateInput!", data, new HashSet<IQuery>() { new ProductBacklogQuery() { FieldName = "productBacklog", IsConnection = false }.Select("*") })
        {
        }
    }
}
