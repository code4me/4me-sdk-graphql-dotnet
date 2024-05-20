using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/providershoporderline/">ProviderShopOrderLine</see> object.
    /// </summary>
    public class ProviderShopOrderLine : Node
    {
        /// <summary>
        /// After this moment the shop article is no longer available in the shop.
        /// </summary>
        [JsonProperty("orderedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? OrderedAt { get; internal set; }

        /// <summary>
        /// The price of a single unit.
        /// </summary>
        [JsonProperty("price"), Sdk4meField(IsDefaultQueryProperty = true)]
        public decimal? Price { get; internal set; }

        /// <summary>
        /// <br>The currency of the price of this shop article.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("priceCurrency"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? PriceCurrency { get; internal set; }

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
        /// The total price of a all units.
        /// </summary>
        [JsonProperty("totalPrice"), Sdk4meField(IsDefaultQueryProperty = true)]
        public decimal? TotalPrice { get; internal set; }

        /// <summary>
        /// The recurring price of a all units.
        /// </summary>
        [JsonProperty("totalRecurringPrice")]
        public decimal? TotalRecurringPrice { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
