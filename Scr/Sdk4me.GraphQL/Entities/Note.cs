namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/note/">Note</see> object.
    /// </summary>
    public class Note : Node
    {
        /// <summary>
        /// The account.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the note was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the notes is internal or not.
        /// </summary>
        [JsonProperty("internal"), Sdk4meField(true)]
        public bool? Internal { get; internal set; }

        /// <summary>
        /// The medium used to add the note.
        /// </summary>
        [JsonProperty("medium"), Sdk4meField(true)]
        public NoteMedium? Medium { get; internal set; }

        /// <summary>
        /// Person who added this note.
        /// </summary>
        [JsonProperty("person"), Sdk4meField(true)]
        public Person? Person { get; internal set; }

        /// <summary>
        /// Text of this note.
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; internal set; }

        [JsonProperty("textAttachments")]
        internal NodeCollection<Attachment>? TextAttachmentsCollection { get; set; }

        /// <summary>
        /// Files and inline images linked to the Text field.
        /// </summary>
        public DataList<Attachment>? TextAttachments
        {
            get => TextAttachmentsCollection?.Data;
        }

        /// <summary>
        /// Visibility of this note.
        /// </summary>
        [JsonProperty("visibility")]
        public NoteVisibility? Visibility { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            HashSet<QueryPageInfo> retval = new();
            retval.AddRange(TextAttachmentsCollection?.GetQueryPageInfo("textAttachments", depth + 1));
            return retval;
        }

        internal override void AddToCollection(object data)
        {
            TextAttachments?.AddRange((data as Note)?.TextAttachments);
        }
    }
}
