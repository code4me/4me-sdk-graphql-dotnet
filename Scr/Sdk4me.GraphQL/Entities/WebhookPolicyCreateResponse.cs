namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/webhookpolicycreateresponse/">WebhookPolicyCreateResponse</see> object.
    /// </summary>
    public class WebhookPolicyCreateResponse
    {
        /// <summary>
        /// The account this record belongs to.
        /// </summary>
        [JsonProperty("account"), Sdk4meField(true)]
        public Account? Account { get; internal set; }

        /// <summary>
        /// The date and time at which the record was created.
        /// </summary>
        [JsonProperty("createdAt"), Sdk4meField(true)]
        public DateTime? CreatedAt { get; internal set; }

        /// <summary>
        /// Whether the webhook policy will be applied.
        /// </summary>
        [JsonProperty("disabled"), Sdk4meField(true)]
        public bool? Disabled { get; internal set; }

        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [JsonProperty("id"), Sdk4meField(true)]
        public string? ID { get; internal set; }

        /// <summary>
        /// The algorithm to use for cryptographic signing of webhook messages.
        /// </summary>
        [JsonProperty("jwtAlg"), Sdk4meField(true)]
        public WebhookPolicyJwtAlg? JwtAlg { get; internal set; }

        /// <summary>
        /// The audience claim identifies the recipients that the encrypted message is intended for.
        /// </summary>
        [JsonProperty("jwtAudience"), Sdk4meField(true)]
        public string? JwtAudience { get; internal set; }

        /// <summary>
        /// The number of minutes within which the claim expires.
        /// </summary>
        [JsonProperty("jwtClaimExpiresIn"), Sdk4meField(true)]
        public long? JwtClaimExpiresIn { get; internal set; }

        /// <summary>
        /// Unique identifier of this webhook policy.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// Generated public key for this policy.
        /// </summary>
        [JsonProperty("publicKeyPem"), Sdk4meField(true)]
        public string? PublicKeyPem { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the `createdAt` value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }
    }
}
