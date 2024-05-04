using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/shoparticle/">ShopArticle</see> object.
    /// </summary>
    public class ShopArticle : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// Calendar that represents the work hours related to the fulfillment/delivery.
        /// </summary>
        [JsonProperty("calendar")]
        public Calendar? Calendar { get; internal set; }

        /// <summary>
        /// Related category.
        /// </summary>
        [JsonProperty("category")]
        public ShopArticleCategory? Category { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The number of minutes it usually takes to deliver the shop article.
        /// </summary>
        [JsonProperty("deliveryDuration")]
        public long? DeliveryDuration { get; internal set; }

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
        /// The request template used to order one of more units of this shop article.
        /// </summary>
        [JsonProperty("fulfillmentTemplate")]
        public RequestTemplate? FulfillmentTemplate { get; internal set; }

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
        /// Related product.
        /// </summary>
        [JsonProperty("product")]
        public Product? Product { get; internal set; }

        /// <summary>
        /// Information from the provider.
        /// </summary>
        [JsonProperty("providerShopArticle")]
        public ProviderShopArticle? ProviderShopArticle { get; internal set; }

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
        /// This reference can be used to link the shop article to a shop order line using the 4me APIs or the 4me Import functionality.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference { get; internal set; }

        /// <summary>
        /// Whether or not this is a physical article that requires shipping.
        /// </summary>
        [JsonProperty("requiresShipping")]
        public bool? RequiresShipping { get; internal set; }

        /// <summary>
        /// The shop description of the shop article.
        /// </summary>
        [JsonProperty("shortDescription")]
        public string? ShortDescription { get; internal set; }

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
        /// The moment the shop article becomes available in the shop.
        /// </summary>
        [JsonProperty("startAt"), Sdk4meField(true)]
        public DateTime? StartAt { get; internal set; }

        /// <summary>
        /// <br>The Time zone related to the calendar.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone { get; internal set; }

        /// <summary>
        /// UI extension that is to be used when the shop article is ordered.
        /// </summary>
        [JsonProperty("uiExtension")]
        public UiExtension? UiExtension { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
