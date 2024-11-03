using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/webhook/">Webhook</see> object.
    /// </summary>
    public class Webhook : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Description of the webhook's purpose.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; internal set; }

        [JsonProperty("descriptionAttachments")]
        internal NodeCollection<Attachment>? DescriptionAttachmentsCollection { get; set; }

        /// <summary>
        /// Inline images linked to the Description field.
        /// </summary>
        public DataList<Attachment>? DescriptionAttachments
        {
            get => DescriptionAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Whether the webhook will be triggered when the event occurs.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Event that will trigger this webhook.
        /// </summary>
        [JsonProperty("event")]
        public WebhookEvent? Event { get; internal set; }

        /// <summary>
        /// Comma separated list of email addresses who will be informed when the webhook execution fails.
        /// </summary>
        [JsonProperty("mailExceptionsTo")]
        public string? MailExceptionsTo { get; internal set; }

        /// <summary>
        /// Name of this webhook.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// An identifier for the client application submitting the resource or the name of an external system.
        /// </summary>
        [JsonProperty("source")]
        public string? Source { get; internal set; }

        /// <summary>
        /// The unique identifier of the resource in an external system.
        /// </summary>
        [JsonProperty("sourceID")]
        public string? SourceID { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(IsDefaultQueryProperty = true)]
        public DateTime? UpdatedAt { get; internal set; }

        /// <summary>
        /// Publicly accessible URI that Xurrent can use to POST http messages to.
        /// </summary>
        [JsonProperty("uri"), Sdk4meField(IsDefaultQueryProperty = true)]
        public string? Uri { get; internal set; }

        /// <summary>
        /// The webhook policy to use for cryptographic signing of the messages.
        /// </summary>
        [JsonProperty("webhookPolicy")]
        public WebhookPolicy? WebhookPolicy { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(DescriptionAttachmentsCollection?.GetQueryPageInfo("descriptionAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            DescriptionAttachments?.AddRange((data as Webhook)?.DescriptionAttachments);
        }
    }
}
