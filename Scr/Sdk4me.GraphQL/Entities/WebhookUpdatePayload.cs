using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/webhookupdatepayload/">WebhookUpdatePayload</see> object.
    /// </summary>
    public class WebhookUpdatePayload : Payload
    {
        /// <summary>
        /// Record after mutation.
        /// </summary>
        [JsonProperty("webhook"), Sdk4meField(IsDefaultQueryProperty = true)]
        public Webhook? Webhook { get; internal set; }
    }
}
