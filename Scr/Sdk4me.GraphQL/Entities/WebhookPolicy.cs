namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/webhookpolicy/">WebhookPolicy</see> object.
    /// </summary>
    public class WebhookPolicy : Node
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
        /// The algorithm to use for cryptographic signing of webhook messages.
        /// </summary>
        [JsonProperty("jwtAlg")]
        public WebhookPolicyJwtAlg? JwtAlg { get; internal set; }

        /// <summary>
        /// The audience claim identifies the recipients that the encrypted message is intended for.
        /// </summary>
        [JsonProperty("jwtAudience")]
        public string? JwtAudience { get; internal set; }

        /// <summary>
        /// The number of minutes within which the claim expires.
        /// </summary>
        [JsonProperty("jwtClaimExpiresIn")]
        public long? JwtClaimExpiresIn { get; internal set; }

        /// <summary>
        /// Unique identifier of this webhook policy.
        /// </summary>
        [JsonProperty("name"), Sdk4meField(true)]
        public string? Name { get; internal set; }

        /// <summary>
        /// The date and time of the last update of the record. If the record has no updates it contains the `createdAt` value.
        /// </summary>
        [JsonProperty("updatedAt"), Sdk4meField(true)]
        public DateTime? UpdatedAt { get; internal set; }

        internal override HashSet<QueryPageInfo> GetQueryPageInfo(string fieldName, int depth)
        {
            return new HashSet<QueryPageInfo>();
        }

        internal override void AddToCollection(object data)
        {
        }
    }
}
