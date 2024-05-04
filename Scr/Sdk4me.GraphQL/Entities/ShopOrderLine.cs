using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/shoporderline/">ShopOrderLine</see> object.
    /// </summary>
    public class ShopOrderLine : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        [JsonProperty("addresses")]
        internal NodeCollection<Address>? AddressesCollection { get; set; }

        /// <summary>
        /// Addresses of the record.
        /// </summary>
        public DataList<Address>? Addresses
        {
            get => AddressesCollection?.Data;
        }

        /// <summary>
        /// Automatically set to the date and time at which the shop order line is saved with the status "Completed".
        /// </summary>
        [JsonProperty("completedAt")]
        public DateTime? CompletedAt { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Values of custom fields.
        /// </summary>
        [JsonProperty("customFields")]
        public CustomFieldCollection? CustomFields { get; internal set; }

        [JsonProperty("customFieldsAttachments")]
        internal NodeCollection<Attachment>? CustomFieldsAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to one of the custom fields.
        /// </summary>
        public DataList<Attachment>? CustomFieldsAttachments
        {
            get => CustomFieldsAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The fulfillment request that is assigned to the provider to fulfil this shop order line.
        /// </summary>
        [JsonProperty("fulfillmentRequest")]
        public Request? FulfillmentRequest { get; internal set; }

        /// <summary>
        /// The fulfillment task of the purchase workflow generated to fulfil this shop order line.
        /// </summary>
        [JsonProperty("fulfillmentTask")]
        public Request? FulfillmentTask { get; internal set; }

        /// <summary>
        /// The request template used to order one of more units of this shop article.
        /// </summary>
        [JsonProperty("fulfillmentTemplate")]
        public RequestTemplate? FulfillmentTemplate { get; internal set; }

        /// <summary>
        /// The name of the shop article.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; internal set; }

        /// <summary>
        /// The request for purchase that includes this shop order line.
        /// </summary>
        [JsonProperty("order")]
        public Request? Order { get; internal set; }

        /// <summary>
        /// After this moment the shop article is no longer available in the shop.
        /// </summary>
        [JsonProperty("orderedAt")]
        public DateTime? OrderedAt { get; internal set; }

        /// <summary>
        /// The price of a single unit.
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; internal set; }

        /// <summary>
        /// <br>The currency of the price of this shop article.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("priceCurrency")]
        public string? PriceCurrency { get; internal set; }

        /// <summary>
        /// Information from the provider.
        /// </summary>
        [JsonProperty("providerOrderLine")]
        public ProviderShopOrderLine? ProviderOrderLine { get; internal set; }

        /// <summary>
        /// The number units ordered.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; internal set; }

        /// <summary>
        /// The frequency in which the recurring price is due.
        /// </summary>
        [JsonProperty("recurringPeriod")]
        public ShopArticleRecurringPeriod? RecurringPeriod { get; internal set; }

        /// <summary>
        /// The recurring price of a single unit.
        /// </summary>
        [JsonProperty("recurringPrice")]
        public decimal? RecurringPrice { get; internal set; }

        /// <summary>
        /// <br>The currency of the recurring price of this shop article.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("recurringPriceCurrency")]
        public string? RecurringPriceCurrency { get; internal set; }

        /// <summary>
        /// The person creating the shop order line.
        /// </summary>
        [JsonProperty("requestedBy")]
        public Person? RequestedBy { get; internal set; }

        /// <summary>
        /// The person for whom the shop order line was submitted.
        /// </summary>
        [JsonProperty("requestedFor"), Sdk4meField(true)]
        public Person? RequestedFor { get; internal set; }

        /// <summary>
        /// The shop article that is ordered.
        /// </summary>
        [JsonProperty("shopArticle"), Sdk4meField(true)]
        public ShopArticle? ShopArticle { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source"), Sdk4meField(true)]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID"), Sdk4meField(true)]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The status of the shop order line.
        /// </summary>
        [JsonProperty("status"), Sdk4meField(true)]
        public ShopOrderLineStatus? Status { get; internal set; }

        /// <summary>
        /// The total price of a all units.
        /// </summary>
        [JsonProperty("totalPrice")]
        public decimal? TotalPrice { get; internal set; }

        /// <summary>
        /// The recurring price of a all units.
        /// </summary>
        [JsonProperty("totalRecurringPrice")]
        public decimal? TotalRecurringPrice { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(AddressesCollection?.GetQueryPageInfo("addresses", depth + 1));
            retval.AddRange(CustomFieldsAttachmentsCollection?.GetQueryPageInfo("customFieldsAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            Addresses?.AddRange((data as ShopOrderLine)?.Addresses);
            CustomFieldsAttachments?.AddRange((data as ShopOrderLine)?.CustomFieldsAttachments);
        }
    }
}
