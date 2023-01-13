namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Creates a new webhook policy.
    /// </summary>
    internal class WebhookPolicyCreateMutation : Mutation<WebhookPolicyCreatePayload, WebhookPolicyCreateInput>
    {
        /// <summary>
        /// Initialize an new WebhookPolicyCreate mutation instance.
        /// </summary>
        internal WebhookPolicyCreateMutation(WebhookPolicyCreateInput data)
            : base("webhookPolicyCreate", "WebhookPolicyCreateInput!", data, new HashSet<IQuery>())
        {
        }
    }
}
