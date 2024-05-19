using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/translationupdateinput/">TranslationUpdateInput</see> object.
    /// </summary>
    public class TranslationUpdateInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private string id;
        private string text;

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
        /// The node ID of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// The text of the translation.
        /// </summary>
        [JsonProperty("text")]
        public string Text
        {
            get => text;
            set => text = Set("text", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationUpdateInput"/> class without providing the required values.
        /// </summary>
        public TranslationUpdateInput()
        {
            id = string.Empty;
            text = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationUpdateInput"/> class.
        /// </summary>
        /// <param name="id">The node ID of the record to update.</param>
        /// <param name="text">The text of the translation.</param>
        public TranslationUpdateInput(string id, string text)
        {
            this.id = Set("id", id);
            this.text = Set("text", text);
        }
    }
}
