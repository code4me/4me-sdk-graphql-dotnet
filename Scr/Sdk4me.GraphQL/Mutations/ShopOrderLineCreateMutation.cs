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
        internal ShopOrderLineCreateMutation(ShopOrderLineCreateInput data)
            : base("shopOrderLineCreate", "ShopOrderLineCreateInput!", data, new HashSet<IQuery>() { new ShopOrderLineQuery() { FieldName = "shopOrderLine", IsConnection = false }.Select("*") })
        {
        }
    }
}
