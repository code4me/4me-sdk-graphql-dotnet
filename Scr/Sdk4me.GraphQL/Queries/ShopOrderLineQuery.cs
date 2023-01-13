namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Root connection for retrieving ShopOrderLine records.
    /// </summary>
    public class ShopOrderLineQuery : Query<ShopOrderLineQuery, ShopOrderLineField, ShopOrderLineView, ShopOrderLineOrderField>
    {
        /// <summary>
        /// Initialize a new shop order line query instance.
        /// </summary>
        public ShopOrderLineQuery()
            : base("shopOrderLines", typeof(ShopOrderLine), true)
        {
        }

        /// <summary>
        /// Addresses of the record.
        /// </summary>
        public ShopOrderLineQuery SelectAddresses(AddressQuery query)
        {
            query.FieldName = "addresses";
            return Select(query);
        }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public ShopOrderLineQuery SelectCustomFieldsAttachments(AttachmentQuery query)
        {
            query.FieldName = "customFieldsAttachments";
            return Select(query);
        }
    }
}
