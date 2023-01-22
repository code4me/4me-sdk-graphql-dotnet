namespace Sdk4me.GraphQL
{
    /// <summary>
    /// The <see href="https://developer.4me.com/graphql/object/webhookdeletemutationpayload/">WebhookDeleteMutationPayload</see> object.
    /// </summary>
    public class WebhookDeleteMutationPayload : Payload
    {
        /// <summary>
        /// `true` when the record was successfully deleted, `false` otherwise.
        /// </summary>
        [JsonProperty("success"), Sdk4meField(true)]
        public bool? Success { get; internal set; }
    }
}
