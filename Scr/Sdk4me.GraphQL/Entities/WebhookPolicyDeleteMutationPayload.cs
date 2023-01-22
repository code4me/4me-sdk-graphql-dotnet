namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/webhookpolicydeletemutationpayload/">WebhookPolicyDeleteMutationPayload</see> object.
    /// </summary>
    public class WebhookPolicyDeleteMutationPayload : Payload
    {
        /// <summary>
        /// `true` when the record was successfully deleted, `false` otherwise.
        /// </summary>
        [JsonProperty("success"), Sdk4meField(true)]
        public bool? Success { get; internal set; }
    }
}
