using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/webhookcreatepayload/">WebhookCreatePayload</see> object.
    /// </summary>
    public class WebhookCreatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("webhook"), Sdk4meField(true)]
        public Webhook? Webhook { get; internal set; }
    }
}
