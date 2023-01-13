namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing webhook.
    /// </summary>
    internal class WebhookUpdateMutation : Mutation<WebhookUpdatePayload, WebhookUpdateInput>
    {
        /// <summary>
        /// Initialize an new WebhookUpdate mutation instance.
        /// </summary>
        internal WebhookUpdateMutation(WebhookUpdateInput data)
            : base("webhookUpdate", "WebhookUpdateInput!", data, new HashSet<IQuery>() { new WebhookQuery() { FieldName = "webhook", IsConnection = false }.Select("*") })
        {
        }
    }
}
