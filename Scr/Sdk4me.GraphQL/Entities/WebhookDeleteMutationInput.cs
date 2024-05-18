using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/webhookdeletemutationinput/">WebhookDeleteMutationInput</see> object.
    /// </summary>
    public class WebhookDeleteMutationInput : PropertyChangeSet
    {
        private string? clientMutationId;
        private string id;

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
        /// The node ID of the record to delete.
        /// </summary>
        [JsonProperty("id")]
        public string ID
        {
            get => id;
            set => id = Set("id", value);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeleteMutationInput"/> class.
        /// </summary>
        /// <param name="id">The node ID of the record to delete.</param>
        public WebhookDeleteMutationInput(string id)
        {
            this.id = Set("id", id);
        }
    }
}
