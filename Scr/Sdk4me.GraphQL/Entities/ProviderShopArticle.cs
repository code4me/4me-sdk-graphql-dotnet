using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/providershoparticle/">ProviderShopArticle</see> object.
    /// </summary>
    public class ProviderShopArticle : Node
    {
        /// <summary>
        /// Whether the shop article is visible in the shop.
        /// </summary>
        [JsonProperty("disabled"), Sdk4meField(true)]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// After this moment the shop article is no longer available in the shop.
        /// </summary>
        [JsonProperty("endAt"), Sdk4meField(true)]
        public DateTime? EndAt { get; internal set; }

        /// <summary>
        /// The full description of the shop article.
        /// </summary>
        [JsonProperty("fullDescription")]
        public string? FullDescription { get; internal set; }

        /// <summary>
        /// The largest number of units that may be bought at once.
        /// </summary>
        [JsonProperty("maxQuantity"), Sdk4meField(true)]
        public long? MaxQuantity { get; internal set; }

        /// <summary>
        /// The display name of the shop article.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

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
        /// The shop description of the shop article.
        /// </summary>
        [JsonProperty("shortDescription")]
        public string? ShortDescription { get; internal set; }

        /// <summary>
        /// The moment the shop article becomes available in the shop.
        /// </summary>
        [JsonProperty("startAt"), Sdk4meField(true)]
        public DateTime? StartAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
