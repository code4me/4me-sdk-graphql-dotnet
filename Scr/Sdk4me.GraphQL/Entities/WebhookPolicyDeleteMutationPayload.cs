using Newtonsoft.Json;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/webhookpolicydeletemutationpayload/">WebhookPolicyDeleteMutationPayload</see> object.
    /// </summary>
    public class WebhookPolicyDeleteMutationPayload : Payload
    {
        /// <summary>
        /// <c>true</c> when the record was successfully deleted, <c>false</c> otherwise.
        /// </summary>
        [JsonProperty("success"), Sdk4meField(IsDefaultQueryProperty = true)]
        public bool? Success { get; internal set; }
    }
}
