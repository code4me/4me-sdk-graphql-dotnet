namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Updates an existing webhook policy.
    /// </summary>
    internal class WebhookPolicyUpdateMutation : Mutation<WebhookPolicyUpdatePayload, WebhookPolicyUpdateInput>
    {
        /// <summary>
        /// Initialize an new WebhookPolicyUpdate mutation instance.
        /// </summary>
        internal WebhookPolicyUpdateMutation(WebhookPolicyUpdateInput data)
            : base("webhookPolicyUpdate", "WebhookPolicyUpdateInput!", data, new HashSet<IQuery>() { new WebhookPolicyQuery() { FieldName = "webhookPolicy", IsConnection = false }.Select("*") })
        {
        }
    }
}
