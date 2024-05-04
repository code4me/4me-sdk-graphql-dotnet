using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/broadcasttranslation/">BroadcastTranslation</see> object.
    /// </summary>
    public class BroadcastTranslation : Node
    {
        /// <summary>
        /// The date and time at which the broadcast translation was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// <br>The language of the broadcast message.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/language/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("language")]
        public string? Language { get; internal set; }

        /// <summary>
        /// Content of the broadcast in the language.
        /// </summary>
        [JsonProperty("message")]
        public string? Message { get; internal set; }

        [JsonProperty("messageAttachments")]
        internal NodeCollection<Attachment>? MessageAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the <c>message</c> field.
        /// </summary>
        public DataList<Attachment>? MessageAttachments
        {
            get => MessageAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The date and time of the last update of the  broadcast translation. If it has no updates it contains the <c>createdAt</c> value.
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(MessageAttachmentsCollection?.GetQueryPageInfo("messageAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            MessageAttachments?.AddRange((data as BroadcastTranslation)?.MessageAttachments);
        }
    }
}
