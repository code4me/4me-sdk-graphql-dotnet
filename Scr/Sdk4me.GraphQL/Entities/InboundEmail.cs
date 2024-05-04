using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/inboundemail/">InboundEmail</see> object.
    /// </summary>
    public class InboundEmail : Node
    {
        /// <summary>
        /// The account that received the inbound email.
        /// </summary>
        [JsonProperty("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The first 255 characters of the body of the inbound email.
        /// </summary>
        [JsonProperty("bodyStart")]
        public string? BodyStart { get; internal set; }

        /// <summary>
        /// The value of the CC field of the inbound email.
        /// </summary>
        [JsonProperty("cc")]
        public string? Cc { get; internal set; }

        /// <summary>
        /// The date and time at which the inbound email was received.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// When the inbound email did not process successfully, contains the reason why processing failed.
        /// </summary>
        [JsonProperty("failureReason")]
        public string? FailureReason { get; internal set; }

        /// <summary>
        /// The sender of the inbound email.
        /// </summary>
        [JsonProperty("from")]
        public string? From { get; internal set; }

        /// <summary>
        /// The value of the Message-ID header of the inbound email.
        /// </summary>
        [JsonProperty("messageId")]
        public string? MessageId { get; internal set; }

        /// <summary>
        /// The note that was created from the inbound email.
        /// </summary>
        [JsonProperty("note")]
        public Note? Note { get; internal set; }

        /// <summary>
        /// The record that was created or updated from the inbound email.
        /// </summary>
        [JsonProperty("record")]
        public IHasNotes? Record { get; internal set; }

        /// <summary>
        /// Expiring URL to download the source of the inbound email.
        /// </summary>
        [JsonProperty("sourceUri")]
        public string? SourceUri { get; internal set; }

        /// <summary>
        /// The subject of the inbound email.
        /// </summary>
        [JsonProperty("subject")]
        public string? Subject { get; internal set; }

        /// <summary>
        /// The recipient of the inbound email.
        /// </summary>
        [JsonProperty("to")]
        public string? To { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
