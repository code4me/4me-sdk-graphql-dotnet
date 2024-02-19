namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new shop order line.
    /// </summary>
    internal class ShopOrderLineCreateMutation : Mutation<ShopOrderLineCreatePayload, ShopOrderLineCreateInput>
    {
        /// <summary>
        /// Initialize an new ShopOrderLineCreate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ShopOrderLineCreateMutation(ShopOrderLineCreateInput data, ShopOrderLineQuery query)
            : base("shopOrderLineCreate", "ShopOrderLineCreateInput!", data, GetQuery(query))
        {
        }

        /// <summary>
        /// Generates the response query collection.
        /// </summary>
        /// <param name="query">The response query.</param>
        /// <returns>A query collection.</returns>
        private static HashSet<IQuery> GetQuery(ShopOrderLineQuery query)
        {
            query.FieldName = "shopOrderLine";
            query.IsConnection = false;
            return new HashSet<IQuery>() {query};
        }
    }
}
