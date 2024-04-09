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

        /// <summary>
        /// Product backlog this item is placed on.
        /// </summary>
        /// <param name="query">The product backlog query.</param>
        /// <returns>Returns an <see cref="IQuery"/>.</returns>
        public ProductBacklogItemQuery SelectProductBacklog(ProductBacklogQuery query)
        {
            query.FieldName = "productBacklog";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
