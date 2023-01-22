namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/webhookpolicydeletemutationinput/">WebhookPolicyDeleteMutationInput</see> object.
    /// </summary>
    public class WebhookPolicyDeleteMutationInput : PropertyChangeSet
    {
        private string? id;
        private string? clientMutationId;

        /// <summary>
        /// The node identifier of the record to delete.
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
