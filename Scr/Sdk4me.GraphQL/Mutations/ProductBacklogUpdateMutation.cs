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
        internal ProductBacklogUpdateMutation(ProductBacklogUpdateInput data)
            : base("productBacklogUpdate", "ProductBacklogUpdateInput!", data, new HashSet<IQuery>() { new ProductBacklogQuery() { FieldName = "productBacklog", IsConnection = false }.Select("*") })
        {
        }
    }
}
