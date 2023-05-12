namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/attachment/">Attachment</see> object.
    /// </summary>
    public class Attachment : Node
    {
        /// <summary>
        /// A temporary expiring URL that can be used to access the attachment.
        /// </summary>
        [JsonProperty("expiringUrl"), Sdk4meField(true)]
        public string? ExpiringUrl { get; internal set; }

        /// <summary>
        /// The name of the attachment.
        /// </summary>
        [JsonProperty("filename"), Sdk4meField(true)]
        public string? Filename { get; internal set; }

        /// <summary>
        /// Whether the attachment is an inline image.
        /// </summary>
        [JsonProperty("inline"), Sdk4meField(true)]
        public bool? Inline { get; internal set; }

        /// <summary>
        /// Key of the attachment that can be used to match the attachment to an inline image included in a rich text field.
        /// </summary>
        [JsonProperty("key"), Sdk4meField(true)]
        public string? Key { get; internal set; }

        /// <summary>
        /// The size of the attachment in bytes.
        /// </summary>
        [JsonProperty("size"), Sdk4meField(true)]
        public long? Size { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
