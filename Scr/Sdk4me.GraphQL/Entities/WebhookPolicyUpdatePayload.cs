using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/webhookpolicyupdatepayload/">WebhookPolicyUpdatePayload</see> object.
    /// </summary>
    public class WebhookPolicyUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("webhookPolicy"), Sdk4meField(true)]
        public WebhookPolicy? WebhookPolicy { get; internal set; }
    }
}
