namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/shoparticlecategory/">ShopArticleCategory</see> object.
    /// </summary>
    public class ShopArticleCategory : Node
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account")]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// The full description of the shop article category.
        /// </summary>
        [JsonProperty("fullDescription")]
        public bool? FullDescription { get; internal set; }

        [JsonProperty("fullDescriptionAttachments")]
        internal NodeCollection<Attachment>? FullDescriptionAttachmentsCollection { get; set; }

        /// <summary>
        /// The attachments used in the <c>fullDescription</c> field.
        /// </summary>
        public DataList<Attachment>? FullDescriptionAttachments
        {
            get => FullDescriptionAttachmentsCollection?.Data;
        }

        /// <summary>
        /// The display name of the shop article category.
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; internal set; }

        /// <summary>
        /// The category's parent category.
        /// </summary>
        [JsonProperty("parent")]
        public ShopArticleCategory? Parent { get; internal set; }

        /// <summary>
        /// The hyperlink to the image file for the record.
        /// </summary>
        [JsonProperty("pictureUri")]
        public string? PictureUri { get; internal set; }

        /// <summary>
        /// The shop description of the shop article category.
        /// </summary>
        [JsonProperty("shortDescription")]
        public string? ShortDescription { get; internal set; }

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
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(FullDescriptionAttachmentsCollection?.GetQueryPageInfo("fullDescriptionAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            FullDescriptionAttachments?.AddRange((data as ShopArticleCategory)?.FullDescriptionAttachments);
        }
    }
}
