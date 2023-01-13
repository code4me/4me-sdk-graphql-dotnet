namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="ProductBacklogItem">ProductBacklogItem</see> query.
    /// </summary>
    public class ProductBacklogItemQuery : Query<ProductBacklogItemQuery, ProductBacklogItemField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new product backlog item query instance.
        /// </summary>
        public ProductBacklogItemQuery()
            : base("", typeof(ProductBacklogItem), true)
        {
        }
    }
}
