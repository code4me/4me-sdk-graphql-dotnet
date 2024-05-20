using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/notereactioncreatepayload/">NoteReactionCreatePayload</see> object.
    /// </summary>
    public class NoteReactionCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("noteReaction"), Sdk4meField(IsDefaultQueryProperty = true)]
        public NoteReaction? NoteReaction { get; internal set; }
    }
}
