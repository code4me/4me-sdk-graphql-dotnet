namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/translationupdateinput/">TranslationUpdateInput</see> object.
    /// </summary>
    public class TranslationUpdateInput : PropertyChangeSet
    {
        private string? text;
        private string? id;
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
        /// The node identifier of the record to update.
        /// </summary>
        [JsonProperty("id")]
        public string? ID
        {
            get => id;
            set => id = Set("id", value);
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
