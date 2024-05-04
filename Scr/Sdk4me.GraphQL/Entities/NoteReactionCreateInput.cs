using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/notereactioncreateinput/">NoteReactionCreateInput</see> object.
    /// </summary>
    public class NoteReactionCreateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private string? noteId;
        private string? reaction;

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
        /// The identifier of the note you want to add a reaction to.
        /// </summary>
        [JsonProperty("noteId")]
        public string? NoteId
        {
            get => noteId;
            set => noteId = Set("noteId", value);
        }

        /// <summary>
        /// <br>The type of reaction to add to the note. Valid values are:</br>
        /// <br>• 👍</br>
        /// <br>• 👎</br>
        /// <br>• 😀</br>
        /// <br>• 😕</br>
        /// <br>• 🎉</br>
        /// <br>• ❤️</br>
        /// </summary>
        [JsonProperty("reaction")]
        public string? Reaction
        {
            get => reaction;
            set => reaction = Set("reaction", value);
        }
    }
}
