namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new webhook.
    /// </summary>
    internal class WebhookCreateMutation : Mutation<WebhookCreatePayload, WebhookCreateInput>
    {
        /// <summary>
        /// Initialize an new WebhookCreate mutation instance.
        /// </summary>
        internal WebhookCreateMutation(WebhookCreateInput data)
            : base("webhookCreate", "WebhookCreateInput!", data, new HashSet<IQuery>() { new WebhookQuery() { FieldName = "webhook", IsConnection = false }.Select("*") })
        {
        }
    }
}
