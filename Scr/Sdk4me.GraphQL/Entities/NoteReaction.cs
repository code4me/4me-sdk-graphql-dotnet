namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/notereaction/">NoteReaction</see> object.
    /// </summary>
    public class NoteReaction : Node
    {
        /// <summary>
        /// The date and time at which the note reaction was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Note this note reaction belongs to.
        /// </summary>
        [JsonProperty("note")]
        public Note? Note { get; internal set; }

        /// <summary>
        /// Person who added this note reaction.
        /// </summary>
        [JsonProperty("person")]
        public Person? Person { get; internal set; }

        /// <summary>
        /// <br>The type of reaction added to the note. Valid values are:</br>
        /// <br>• 👍</br>
        /// <br>• 👎</br>
        /// <br>• 😀</br>
        /// <br>• 😕</br>
        /// <br>• 🎉</br>
        /// <br>• ❤️</br>
        /// </summary>
        [JsonProperty("reaction"), Sdk4meField(true)]
        public string? Reaction { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
