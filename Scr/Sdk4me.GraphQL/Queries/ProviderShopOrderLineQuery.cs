namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see cref="ProviderShopOrderLine">ProviderShopOrderLine</see> query.
    /// </summary>
    public class ProviderShopOrderLineQuery : Query<ProviderShopOrderLineQuery, ProviderShopOrderLineField, DefaultView, DefaultOrderField>
    {
        /// <summary>
        /// Initialize a new provider shop order line query instance.
        /// </summary>
        public ProviderShopOrderLineQuery()
            : base("", typeof(ProviderShopOrderLine), false)
        {
        }
    }
}
