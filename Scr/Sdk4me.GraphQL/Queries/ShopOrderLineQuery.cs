﻿namespace Sdk4me.GraphQL
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
        /// Initialize a new shop order line query instance.
        /// <br>Additional filters and views will be ignored.</br>
        /// </summary>
        /// <param name="id">The ID of the shop order line.</param>
        public ShopOrderLineQuery(string id)
            : base("ShopOrderLine", id, typeof(ShopOrderLine), false)
        {
        }

        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        public ShopOrderLineQuery SelectAccount(AccountQuery query)
        {
            query.FieldName = "account";
            query.IsConnection = false;
            return Select(query);
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
        /// Values of custom fields.
        /// </summary>
        public ShopOrderLineQuery SelectCustomFields(CustomFieldQuery query)
        {
            query.FieldName = "customFields";
            query.IsConnection = false;
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

        /// <summary>
        /// The fulfillment request that is assigned to the provider to fulfil this shop order line.
        /// </summary>
        public ShopOrderLineQuery SelectFulfillmentRequest(RequestQuery query)
        {
            query.FieldName = "fulfillmentRequest";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The fulfillment task of the purchase workflow generated to fulfil this shop order line.
        /// </summary>
        public ShopOrderLineQuery SelectFulfillmentTask(RequestQuery query)
        {
            query.FieldName = "fulfillmentTask";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The request template used to order one of more units of this shop article.
        /// </summary>
        public ShopOrderLineQuery SelectFulfillmentTemplate(RequestTemplateQuery query)
        {
            query.FieldName = "fulfillmentTemplate";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The request for purchase that includes this shop order line.
        /// </summary>
        public ShopOrderLineQuery SelectOrder(RequestQuery query)
        {
            query.FieldName = "order";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// Information from the provider.
        /// </summary>
        public ShopOrderLineQuery SelectProviderOrderLine(ProviderShopOrderLineQuery query)
        {
            query.FieldName = "providerOrderLine";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person creating the shop order line.
        /// </summary>
        public ShopOrderLineQuery SelectRequestedBy(PersonQuery query)
        {
            query.FieldName = "requestedBy";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The person for whom the shop order line was submitted.
        /// </summary>
        public ShopOrderLineQuery SelectRequestedFor(PersonQuery query)
        {
            query.FieldName = "requestedFor";
            query.IsConnection = false;
            return Select(query);
        }

        /// <summary>
        /// The shop article that is ordered.
        /// </summary>
        public ShopOrderLineQuery SelectShopArticle(ShopArticleQuery query)
        {
            query.FieldName = "shopArticle";
            query.IsConnection = false;
            return Select(query);
        }
    }
}
