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
        internal ShopOrderLineUpdateMutation(ShopOrderLineUpdateInput data)
            : base("shopOrderLineUpdate", "ShopOrderLineUpdateInput!", data, new HashSet<IQuery>() { new ShopOrderLineQuery() { FieldName = "shopOrderLine", IsConnection = false }.Select("*") })
        {
        }
    }
}
