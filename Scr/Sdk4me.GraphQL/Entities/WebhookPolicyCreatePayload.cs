namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/webhookpolicycreatepayload/">WebhookPolicyCreatePayload</see> object.
    /// </summary>
    public class WebhookPolicyCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("webhookPolicy"), Sdk4meField(true)]
        public WebhookPolicyCreateResponse? WebhookPolicy { get; internal set; }
    }
}
