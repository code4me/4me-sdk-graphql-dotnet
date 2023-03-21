namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/translationcreateinput/">TranslationCreateInput</see> object.
    /// </summary>
    public class TranslationCreateInput : PropertyChangeSet
    {
        private string? text;
        private string? field;
        private string? language;
        private string? ownerId;
        private string? clientMutationId;

        /// <summary>
        /// The text of the translation.
        /// </summary>
        [JsonProperty("text")]
        public string? Text
        {
            get => text;
            set => text = Set("text", value);
        }

        /// <summary>
        /// The field of the record from which the translation is obtained.
        /// </summary>
        [JsonProperty("field")]
        public string? Field
        {
            get => field;
            set => field = Set("field", value);
        }

        /// <summary>
        /// <br>The language in which the text is specified.</br>
        /// <br>The complete list is available on the <see href="https://developer.4me.com/graphql/scalar/language/">4me developer site</see>.</br>
        /// </summary>
        [JsonProperty("language")]
        public string? Language
        {
            get => language;
            set => language = Set("language", value);
        }

        /// <summary>
        /// The record from which the translation is obtained.
        /// </summary>
        [JsonProperty("ownerId")]
        public string? OwnerId
        {
            get => ownerId;
            set => ownerId = Set("ownerId", value);
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
        }
    }
}
