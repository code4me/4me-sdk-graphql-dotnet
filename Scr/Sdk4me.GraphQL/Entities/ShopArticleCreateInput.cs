﻿using Newtonsoft.Json;
using System;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/shoparticlecreateinput/">ShopArticleCreateInput</see> object.
    /// </summary>
    public class ShopArticleCreateInput : PropertyChangeSet
    {
        private string? calendarId;
        private string? clientMutationId;
        private long? deliveryDuration;
        private bool? disabled;
        private DateTime? endAt;
        private string? fulfillmentTemplateId;
        private string? fullDescription;
        private long? maxQuantity;
        private string name;
        private string? pictureUri;
        private decimal? price;
        private string? priceCurrency;
        private string? productId;
        private ShopArticleRecurringPeriod? recurringPeriod;
        private decimal? recurringPrice;
        private string? recurringPriceCurrency;
        private string? reference;
        private bool? requiresShipping;
        private string? shortDescription;
        private string? source;
        private string? sourceID;
        private DateTime? startAt;
        private string? timeZone;
        private string? uiExtensionId;

        /// <summary>
        /// Calendar that represents the work hours related to the fulfillment/delivery.
        /// </summary>
        [JsonProperty("calendarId")]
        public string? CalendarId
        {
            get => calendarId;
            set => calendarId = Set("calendarId", value);
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }

        /// <summary>
        /// The number of minutes it usually takes to deliver the shop article.
        /// </summary>
        [JsonProperty("deliveryDuration")]
        public long? DeliveryDuration
        {
            get => deliveryDuration;
            set => deliveryDuration = Set("deliveryDuration", value);
        }

        /// <summary>
        /// Whether the shop article is visible in the shop.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// After this moment the shop article is no longer available in the shop.
        /// </summary>
        [JsonProperty("endAt")]
        public DateTime? EndAt
        {
            get => endAt;
            set => endAt = Set("endAt", value);
        }

        /// <summary>
        /// The request template used to order one of more units of this shop article.
        /// </summary>
        [JsonProperty("fulfillmentTemplateId")]
        public string? FulfillmentTemplateId
        {
            get => fulfillmentTemplateId;
            set => fulfillmentTemplateId = Set("fulfillmentTemplateId", value);
        }

        /// <summary>
        /// The full description of the shop article.
        /// </summary>
        [JsonProperty("fullDescription")]
        public string? FullDescription
        {
            get => fullDescription;
            set => fullDescription = Set("fullDescription", value);
        }

        /// <summary>
        /// The largest number of units that may be bought at once.
        /// </summary>
        [JsonProperty("maxQuantity")]
        public long? MaxQuantity
        {
            get => maxQuantity;
            set => maxQuantity = Set("maxQuantity", value);
        }

        /// <summary>
        /// The display name of the shop article.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsRequiredForMutation = true)]
        public string Name
        {
            get => name;
            set => name = Set("name", value);
        }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri
        {
            get => pictureUri;
            set => pictureUri = Set("pictureUri", value);
        }

        /// <summary>
        /// The price of a single unit.
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price
        {
            get => price;
            set => price = Set("price", value);
        }

        /// <summary>
        /// <br>The currency of the price of this shop article.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("priceCurrency")]
        public string? PriceCurrency
        {
            get => priceCurrency;
            set => priceCurrency = Set("priceCurrency", value);
        }

        /// <summary>
        /// Related product.
        /// </summary>
        [JsonProperty("productId")]
        public string? ProductId
        {
            get => productId;
            set => productId = Set("productId", value);
        }

        /// <summary>
        /// The frequency in which the recurring price is due.
        /// </summary>
        [JsonProperty("recurringPeriod")]
        public ShopArticleRecurringPeriod? RecurringPeriod
        {
            get => recurringPeriod;
            set => recurringPeriod = Set("recurringPeriod", value);
        }

        /// <summary>
        /// The recurring price of a single unit.
        /// </summary>
        [JsonProperty("recurringPrice")]
        public decimal? RecurringPrice
        {
            get => recurringPrice;
            set => recurringPrice = Set("recurringPrice", value);
        }

        /// <summary>
        /// <br>The currency of the recurring price of this shop article.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/currency/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("recurringPriceCurrency")]
        public string? RecurringPriceCurrency
        {
            get => recurringPriceCurrency;
            set => recurringPriceCurrency = Set("recurringPriceCurrency", value);
        }

        /// <summary>
        /// This reference can be used to link the shop article to a shop order line using the Xurrent APIs or the Xurrent Import functionality.
        /// </summary>
        [JsonProperty("reference")]
        public string? Reference
        {
            get => reference;
            set => reference = Set("reference", value);
        }

        /// <summary>
        /// Whether or not this is a physical article that requires shipping.
        /// </summary>
        [JsonProperty("requiresShipping")]
        public bool? RequiresShipping
        {
            get => requiresShipping;
            set => requiresShipping = Set("requiresShipping", value);
        }

        /// <summary>
        /// The shop description of the shop article.
        /// </summary>
        [JsonProperty("shortDescription")]
        public string? ShortDescription
        {
            get => shortDescription;
            set => shortDescription = Set("shortDescription", value);
        }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source
        {
            get => source;
            set => source = Set("source", value);
        }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID
        {
            get => sourceID;
            set => sourceID = Set("sourceID", value);
        }

        /// <summary>
        /// The moment the shop article becomes available in the shop.
        /// </summary>
        [JsonProperty("startAt")]
        public DateTime? StartAt
        {
            get => startAt;
            set => startAt = Set("startAt", value);
        }

        /// <summary>
        /// <br>The Time zone related to the calendar.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/timezone/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("timeZone")]
        public string? TimeZone
        {
            get => timeZone;
            set => timeZone = Set("timeZone", value);
        }

        /// <summary>
        /// UI extension that is to be applied to the record.
        /// </summary>
        [JsonProperty("uiExtensionId")]
        public string? UiExtensionId
        {
            get => uiExtensionId;
            set => uiExtensionId = Set("uiExtensionId", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopArticleCreateInput"/> class without providing the required values.
        /// </summary>
        public ShopArticleCreateInput()
        {
            name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShopArticleCreateInput"/> class.
        /// </summary>
        /// <param name="name">The display name of the shop article.</param>
        public ShopArticleCreateInput(string name)
        {
            this.name = Set("name", name);
        }
    }
}
