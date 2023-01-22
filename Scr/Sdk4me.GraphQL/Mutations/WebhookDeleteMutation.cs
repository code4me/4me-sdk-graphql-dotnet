namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Deletes a webhook.
    /// </summary>
    internal class WebhookDeleteMutation : Mutation<WebhookDeleteMutationPayload, WebhookDeleteMutationInput>
    {
        /// <summary>
        /// Initialize an new WebhookDelete mutation instance.
        /// </summary>
        internal WebhookDeleteMutation(WebhookDeleteMutationInput data)
            : base("webhookDelete", "WebhookDeleteMutationInput!", data, new HashSet<IQuery>())
        {
        }
    }
}
