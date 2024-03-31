namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing shop order line.
    /// </summary>
    internal class ShopOrderLineUpdateMutation : Mutation<ShopOrderLineUpdatePayload, ShopOrderLineUpdateInput>
    {
        /// <summary>
        /// Initialize an new ShopOrderLineUpdate mutation instance.
        /// </summary>
        /// <param name="data">The input data.</param>
        /// <param name="query">The response query.</param>
        internal ShopOrderLineUpdateMutation(ShopOrderLineUpdateInput data, ShopOrderLineQuery query)
            : base("shopOrderLineUpdate", "ShopOrderLineUpdateInput!", data, GetQuery(query))
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
            return new HashSet<IQuery>() { query };
        }
    }
}
