namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/input_object/webhookpolicycreateinput/">WebhookPolicyCreateInput</see> object.
    /// </summary>
    public class WebhookPolicyCreateInput : PropertyChangeSet
    {
        private bool? disabled;
        private long? jwtClaimExpiresIn;
        private string? jwtAudience;
        private string? clientMutationId;
        private WebhookPolicyJwtAlg? jwtAlg;

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
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        [JsonProperty("clientMutationId")]
        public string? ClientMutationId
        {
            get => clientMutationId;
            set => clientMutationId = Set("clientMutationId", value);
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
    }
}
