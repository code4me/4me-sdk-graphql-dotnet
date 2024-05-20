using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/notereactioncreateinput/">NoteReactionCreateInput</see> object.
    /// </summary>
    public class NoteReactionCreateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private string noteId;
        private string reaction;

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
        [JsonProperty("noteId"), Sdk4meField(IsRequiredForMutation = true)]
        public string NoteId
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
        [JsonProperty("reaction"), Sdk4meField(IsRequiredForMutation = true)]
        public string Reaction
        {
            get => reaction;
            set => reaction = Set("reaction", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoteReactionCreateInput"/> class without providing the required values.
        /// </summary>
        public NoteReactionCreateInput()
        {
            noteId = string.Empty;
            reaction = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoteReactionCreateInput"/> class.
        /// </summary>
        /// <param name="noteId">The identifier of the note you want to add a reaction to.</param>
        /// <param name="reaction">
        /// <br>The type of reaction to add to the note. Valid values are:</br>
        /// <br>• 👍</br>
        /// <br>• 👎</br>
        /// <br>• 😀</br>
        /// <br>• 😕</br>
        /// <br>• 🎉</br>
        /// <br>• ❤️</br>
        /// </param>
        public NoteReactionCreateInput(string noteId, string reaction)
        {
            this.noteId = Set("noteId", noteId);
            this.reaction = Set("reaction", reaction);
        }
    }
}
