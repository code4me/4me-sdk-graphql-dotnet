namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/webhookpolicyupdateinput/">WebhookPolicyUpdateInput</see> object.
    /// </summary>
    public class WebhookPolicyUpdateInput : PropertyChangeSet
    {
        private bool? disabled;
        private WebhookPolicyJwtAlg? jwtAlg;
        private long? jwtClaimExpiresIn;
        private string? jwtAudience;
        private string? id;
        private string? clientMutationId;

        /// <summary>
        /// Whether the webhook policy will be applied.
        /// </summary>
        [JsonProperty("disabled")]
        public bool? Disabled
        {
            get => disabled;
            set => disabled = Set("disabled", value);
        }

        /// <summary>
        /// The algorithm to use for cryptographic signing of webhook messages.
        /// </summary>
        [JsonProperty("jwtAlg")]
        public WebhookPolicyJwtAlg? JwtAlg
        {
            get => jwtAlg;
            set => jwtAlg = Set("jwtAlg", value);
        }

        /// <summary>
        /// The number of minutes within which the claim expires.
        /// </summary>
        [JsonProperty("jwtClaimExpiresIn")]
        public long? JwtClaimExpiresIn
        {
            get => jwtClaimExpiresIn;
            set => jwtClaimExpiresIn = Set("jwtClaimExpiresIn", value);
        }

        /// <summary>
        /// The audience claim identifies the recipients that the encrypted message is intended for.
        /// </summary>
        [JsonProperty("jwtAudience")]
        public string? JwtAudience
        {
            get => jwtAudience;
            set => jwtAudience = Set("jwtAudience", value);
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
